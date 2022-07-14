using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Collections.Specialized;

namespace WhatsappMan
{
    public partial class Main : Form
    {
        private static IEnumerable<string> _telefonlar;
        private static string _gonderilecekdosya;
        private static int _gruplanacaksayi;
        private static int _beklemesuresi;

        public Main()
        {
            InitializeComponent();

            //Arka plan işçisi
            arkaplaniscisi.WorkerReportsProgress = true;
            arkaplaniscisi.WorkerSupportsCancellation = true;

            //Gönderilecek dosya seçici
            gonderilecekdosyayolu.Multiselect = false;
            gonderilecekdosyayolu.CheckFileExists = true;
            gonderilecekdosyayolu.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            gonderilecekdosyayolu.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png|PDF Dosyaları|*.pdf|Video Dosyaları|*.mp4;*.mpeg";

            //Gönderilecek telefon numaraları listesi
            telefonnumaralari.Multiselect = false;
            telefonnumaralari.CheckFileExists = true;
            telefonnumaralari.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            telefonnumaralari.Filter = "Telefon Listesi|*.txt";

            //Log kaydedici
            logdosyasikaydet.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            logdosyasikaydet.Filter = "Log Dosyası|*.txt";

            txt_console.Text = DateTime.Now + " > Program başlatıldı.";
        }

        private void gonderilecekdosyayolu_FileOk(object sender, CancelEventArgs e)
        {
            txt_gonderilecekdosyayolu.Text = gonderilecekdosyayolu.FileName;
        }

        private void btn_gonderilecekdosyayolu_Click(object sender, EventArgs e)
        {
            gonderilecekdosyayolu.ShowDialog();
        }

        private void telefonnumaralari_FileOk(object sender, CancelEventArgs e)
        {
            txt_telefonnumaralari.Text = telefonnumaralari.FileName;
        }

        private void btn_telefonnumaralari_Click(object sender, EventArgs e)
        {
            telefonnumaralari.ShowDialog();
        }
        [STAThread]
        private void btn_baslat_Click(object sender, EventArgs e)
        {
            if (arkaplaniscisi.IsBusy != true)
            {
                _telefonlar = File.ReadLines(txt_telefonnumaralari.Text);
                _gonderilecekdosya = txt_gonderilecekdosyayolu.Text;
                _gruplanacaksayi = Convert.ToInt32(paketadeti.Value);
                _beklemesuresi = Convert.ToInt32(beklemesuresi.Value);

                StringCollection paths = new StringCollection();
                paths.Add(_gonderilecekdosya);
                Clipboard.SetFileDropList(paths);

                DialogResult result = MessageBox.Show(_telefonlar.Count() + " adet numaraya gönderim sağlanacak. Onaylıyor musunuz?", "Onay", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                if(result == DialogResult.OK)
                {
                    arkaplaniscisi.RunWorkerAsync();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Şu an bir işlem devam ediyor. Ne yapmak istiyorsunuz?", "Uyarı", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort)
                {
                    arkaplaniscisi.CancelAsync();
                }
                else if(result == DialogResult.Retry) 
                {
                    arkaplaniscisi.CancelAsync();
                    arkaplaniscisi.RunWorkerAsync();
                }
            }
        }

        private void logekle(string log)
        {
            this.Invoke(new MethodInvoker(delegate { txt_console.Text += log; txt_console.ScrollToCaret(); }));
        }

        private void durumcubugu(decimal biten, decimal toplam)
        {
            this.Invoke(new MethodInvoker(delegate { toolStripProgressBar.Value = (int)((biten / toplam) * 100); ; }));
        }

        private void arkaplaniscisi_DoWork(object sender, DoWorkEventArgs e)
        {
            logekle(Environment.NewLine + "##########LOGBAŞI##########");
            logekle(Environment.NewLine + _telefonlar.Count().ToString() + " adet kullanıcı için gönderim işlemi başatıldı.");
            logekle(Environment.NewLine + "#telefon listesi: " + txt_telefonnumaralari.Text);
            logekle(Environment.NewLine + "#gönderilecek dosya: " + txt_gonderilecekdosyayolu.Text);
            logekle(Environment.NewLine + "#başlangıç: " + DateTime.Now);
            logekle(Environment.NewLine);

            BackgroundWorker isci = sender as BackgroundWorker;

            ChromeOptions ayarlar = new ChromeOptions();
            ayarlar.AddArguments(@"user-data-dir=C:/ChromeDriver");
            ayarlar.AddArguments("disable-infobars");

            IWebDriver driver = new ChromeDriver(ayarlar);

            driver.Url = "https://web.whatsapp.com";

            try
            {
                var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div/div[4]/div/div/div[2]/div[1]/h1")));

                int total = 0;
                int sent = 0;

                foreach (var line in _telefonlar)
                {
                    total++;
                    if(total % _gruplanacaksayi == 0) { System.Threading.Thread.Sleep(_beklemesuresi*60*1000); }

                    if (isci.CancellationPending == true)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        try
                        {
                            driver.Url = "https://web.whatsapp.com/send?phone=" + line + "&text&type=phone_number&app_absent=0";

                            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p")));
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p")).SendKeys(OpenQA.Selenium.Keys.Control + "v");
                            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[2]/div[2]/div/div/span")));
                            driver.FindElement(By.XPath("/html/body/div[1]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[2]/div[2]/div/div/span")).Click();
                            System.Threading.Thread.Sleep(10000);
                            logekle(Environment.NewLine + line + " numarasına gönderim başarılı.");
                            sent++;
                        }
                        catch (Exception ex)
                        {
                            logekle(Environment.NewLine + "!!! " + line + " numarasına gönderim sağlanamadı. Hata: " + ex.Message);
                        }
                    }
                    durumcubugu(total, _telefonlar.Count());
                }
            }
            catch (Exception ex)
            {
                logekle(Environment.NewLine + "!!! Programdan çıkış yapılıyor. Hata: " + ex.Message);
            }
            finally
            {
                driver.Quit();
                logekle(Environment.NewLine);
                logekle(Environment.NewLine + "#bitiş: " + DateTime.Now);
                logekle(Environment.NewLine + "##########LOGSONU##########");
            }
        }

        private void btn_logudisaaktar_Click(object sender, EventArgs e)
        {
            logdosyasikaydet.ShowDialog();
        }

        private void logdosyasikaydet_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(logdosyasikaydet.FileName, txt_console.Text);
        }
    }
}
