namespace WhatsappMan
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.gonderilecekdosyayolu = new System.Windows.Forms.OpenFileDialog();
            this.btn_gonderilecekdosyayolu = new System.Windows.Forms.Button();
            this.txt_gonderilecekdosyayolu = new System.Windows.Forms.TextBox();
            this.telefonnumaralari = new System.Windows.Forms.OpenFileDialog();
            this.btn_telefonnumaralari = new System.Windows.Forms.Button();
            this.txt_telefonnumaralari = new System.Windows.Forms.TextBox();
            this.lbl_gonderilecekdosyayolu = new System.Windows.Forms.Label();
            this.lbl_telefonnumaralari = new System.Windows.Forms.Label();
            this.grp_gonderimbilgileri = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.arkaplaniscisi = new System.ComponentModel.BackgroundWorker();
            this.txt_console = new System.Windows.Forms.TextBox();
            this.paketadeti = new System.Windows.Forms.NumericUpDown();
            this.beklemesuresi = new System.Windows.Forms.NumericUpDown();
            this.statusband = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.btn_logudisaaktar = new System.Windows.Forms.Button();
            this.logdosyasikaydet = new System.Windows.Forms.SaveFileDialog();
            this.grp_gonderimbilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paketadeti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklemesuresi)).BeginInit();
            this.statusband.SuspendLayout();
            this.SuspendLayout();
            // 
            // gonderilecekdosyayolu
            // 
            this.gonderilecekdosyayolu.FileName = "openFileDialog1";
            this.gonderilecekdosyayolu.FileOk += new System.ComponentModel.CancelEventHandler(this.gonderilecekdosyayolu_FileOk);
            // 
            // btn_gonderilecekdosyayolu
            // 
            this.btn_gonderilecekdosyayolu.Location = new System.Drawing.Point(460, 60);
            this.btn_gonderilecekdosyayolu.Name = "btn_gonderilecekdosyayolu";
            this.btn_gonderilecekdosyayolu.Size = new System.Drawing.Size(75, 23);
            this.btn_gonderilecekdosyayolu.TabIndex = 0;
            this.btn_gonderilecekdosyayolu.Text = "Gözat";
            this.btn_gonderilecekdosyayolu.UseVisualStyleBackColor = true;
            this.btn_gonderilecekdosyayolu.Click += new System.EventHandler(this.btn_gonderilecekdosyayolu_Click);
            // 
            // txt_gonderilecekdosyayolu
            // 
            this.txt_gonderilecekdosyayolu.Location = new System.Drawing.Point(28, 61);
            this.txt_gonderilecekdosyayolu.Name = "txt_gonderilecekdosyayolu";
            this.txt_gonderilecekdosyayolu.ReadOnly = true;
            this.txt_gonderilecekdosyayolu.Size = new System.Drawing.Size(426, 20);
            this.txt_gonderilecekdosyayolu.TabIndex = 1;
            // 
            // telefonnumaralari
            // 
            this.telefonnumaralari.FileName = "openFileDialog1";
            this.telefonnumaralari.FileOk += new System.ComponentModel.CancelEventHandler(this.telefonnumaralari_FileOk);
            // 
            // btn_telefonnumaralari
            // 
            this.btn_telefonnumaralari.Location = new System.Drawing.Point(460, 121);
            this.btn_telefonnumaralari.Name = "btn_telefonnumaralari";
            this.btn_telefonnumaralari.Size = new System.Drawing.Size(75, 23);
            this.btn_telefonnumaralari.TabIndex = 2;
            this.btn_telefonnumaralari.Text = "Gözat";
            this.btn_telefonnumaralari.UseVisualStyleBackColor = true;
            this.btn_telefonnumaralari.Click += new System.EventHandler(this.btn_telefonnumaralari_Click);
            // 
            // txt_telefonnumaralari
            // 
            this.txt_telefonnumaralari.Location = new System.Drawing.Point(28, 122);
            this.txt_telefonnumaralari.Name = "txt_telefonnumaralari";
            this.txt_telefonnumaralari.ReadOnly = true;
            this.txt_telefonnumaralari.Size = new System.Drawing.Size(426, 20);
            this.txt_telefonnumaralari.TabIndex = 3;
            // 
            // lbl_gonderilecekdosyayolu
            // 
            this.lbl_gonderilecekdosyayolu.AutoSize = true;
            this.lbl_gonderilecekdosyayolu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gonderilecekdosyayolu.Location = new System.Drawing.Point(28, 43);
            this.lbl_gonderilecekdosyayolu.Name = "lbl_gonderilecekdosyayolu";
            this.lbl_gonderilecekdosyayolu.Size = new System.Drawing.Size(121, 13);
            this.lbl_gonderilecekdosyayolu.TabIndex = 4;
            this.lbl_gonderilecekdosyayolu.Text = "Gönderilecek Dosya";
            // 
            // lbl_telefonnumaralari
            // 
            this.lbl_telefonnumaralari.AutoSize = true;
            this.lbl_telefonnumaralari.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_telefonnumaralari.Location = new System.Drawing.Point(28, 104);
            this.lbl_telefonnumaralari.Name = "lbl_telefonnumaralari";
            this.lbl_telefonnumaralari.Size = new System.Drawing.Size(114, 13);
            this.lbl_telefonnumaralari.TabIndex = 5;
            this.lbl_telefonnumaralari.Text = "Telefon Numaraları";
            // 
            // grp_gonderimbilgileri
            // 
            this.grp_gonderimbilgileri.Controls.Add(this.beklemesuresi);
            this.grp_gonderimbilgileri.Controls.Add(this.paketadeti);
            this.grp_gonderimbilgileri.Controls.Add(this.label2);
            this.grp_gonderimbilgileri.Controls.Add(this.label1);
            this.grp_gonderimbilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_gonderimbilgileri.Location = new System.Drawing.Point(12, 12);
            this.grp_gonderimbilgileri.Name = "grp_gonderimbilgileri";
            this.grp_gonderimbilgileri.Size = new System.Drawing.Size(540, 214);
            this.grp_gonderimbilgileri.TabIndex = 6;
            this.grp_gonderimbilgileri.TabStop = false;
            this.grp_gonderimbilgileri.Text = "Gönderim Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bekleme Süresi (dk)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gruplama Adeti";
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(12, 232);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(540, 23);
            this.btn_baslat.TabIndex = 7;
            this.btn_baslat.Text = "Başlat / Durdur";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // arkaplaniscisi
            // 
            this.arkaplaniscisi.DoWork += new System.ComponentModel.DoWorkEventHandler(this.arkaplaniscisi_DoWork);
            // 
            // txt_console
            // 
            this.txt_console.Location = new System.Drawing.Point(13, 262);
            this.txt_console.Multiline = true;
            this.txt_console.Name = "txt_console";
            this.txt_console.ReadOnly = true;
            this.txt_console.Size = new System.Drawing.Size(539, 176);
            this.txt_console.TabIndex = 8;
            // 
            // paketadeti
            // 
            this.paketadeti.Location = new System.Drawing.Point(16, 171);
            this.paketadeti.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.paketadeti.Name = "paketadeti";
            this.paketadeti.Size = new System.Drawing.Size(120, 20);
            this.paketadeti.TabIndex = 4;
            this.paketadeti.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // beklemesuresi
            // 
            this.beklemesuresi.Location = new System.Drawing.Point(154, 171);
            this.beklemesuresi.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.beklemesuresi.Name = "beklemesuresi";
            this.beklemesuresi.Size = new System.Drawing.Size(120, 20);
            this.beklemesuresi.TabIndex = 5;
            this.beklemesuresi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // statusband
            // 
            this.statusband.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar});
            this.statusband.Location = new System.Drawing.Point(0, 474);
            this.statusband.Name = "statusband";
            this.statusband.Size = new System.Drawing.Size(565, 22);
            this.statusband.TabIndex = 9;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Step = 1;
            // 
            // btn_logudisaaktar
            // 
            this.btn_logudisaaktar.Location = new System.Drawing.Point(460, 445);
            this.btn_logudisaaktar.Name = "btn_logudisaaktar";
            this.btn_logudisaaktar.Size = new System.Drawing.Size(92, 23);
            this.btn_logudisaaktar.TabIndex = 10;
            this.btn_logudisaaktar.Text = "Dışa Aktar";
            this.btn_logudisaaktar.UseVisualStyleBackColor = true;
            this.btn_logudisaaktar.Click += new System.EventHandler(this.btn_logudisaaktar_Click);
            // 
            // logdosyasikaydet
            // 
            this.logdosyasikaydet.FileOk += new System.ComponentModel.CancelEventHandler(this.logdosyasikaydet_FileOk);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 496);
            this.Controls.Add(this.btn_logudisaaktar);
            this.Controls.Add(this.statusband);
            this.Controls.Add(this.txt_console);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.lbl_telefonnumaralari);
            this.Controls.Add(this.lbl_gonderilecekdosyayolu);
            this.Controls.Add(this.txt_telefonnumaralari);
            this.Controls.Add(this.btn_telefonnumaralari);
            this.Controls.Add(this.txt_gonderilecekdosyayolu);
            this.Controls.Add(this.btn_gonderilecekdosyayolu);
            this.Controls.Add(this.grp_gonderimbilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "WhatsappMan";
            this.grp_gonderimbilgileri.ResumeLayout(false);
            this.grp_gonderimbilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paketadeti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beklemesuresi)).EndInit();
            this.statusband.ResumeLayout(false);
            this.statusband.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog gonderilecekdosyayolu;
        private System.Windows.Forms.Button btn_gonderilecekdosyayolu;
        private System.Windows.Forms.TextBox txt_gonderilecekdosyayolu;
        private System.Windows.Forms.OpenFileDialog telefonnumaralari;
        private System.Windows.Forms.Button btn_telefonnumaralari;
        private System.Windows.Forms.TextBox txt_telefonnumaralari;
        private System.Windows.Forms.Label lbl_gonderilecekdosyayolu;
        private System.Windows.Forms.Label lbl_telefonnumaralari;
        private System.Windows.Forms.GroupBox grp_gonderimbilgileri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_baslat;
        private System.ComponentModel.BackgroundWorker arkaplaniscisi;
        private System.Windows.Forms.TextBox txt_console;
        private System.Windows.Forms.NumericUpDown beklemesuresi;
        private System.Windows.Forms.NumericUpDown paketadeti;
        private System.Windows.Forms.StatusStrip statusband;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Button btn_logudisaaktar;
        private System.Windows.Forms.SaveFileDialog logdosyasikaydet;
    }
}

