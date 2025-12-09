namespace KutuphaneOtomasyon
{
    partial class uyelerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyelerForm));
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeSayim = new System.Windows.Forms.Button();
            this.btnBloke = new System.Windows.Forms.Button();
            this.btnKisiAra = new System.Windows.Forms.Button();
            this.btnOducIslemleri = new System.Windows.Forms.Button();
            this.btnKitapListesi = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnYeniKisiEkle = new System.Windows.Forms.Button();
            this.btnKisiSil = new System.Windows.Forms.Button();
            this.btnKisiDuzenle = new System.Windows.Forms.Button();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.txtAranacakDeger = new System.Windows.Forms.TextBox();
            this.lblKisiAranacakDeger = new System.Windows.Forms.Label();
            this.lblKisiAramaTuru = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKisiEklenmeTarihi = new System.Windows.Forms.TextBox();
            this.lblKisiEklenmeTarihi = new System.Windows.Forms.Label();
            this.rctxtKisiAdres = new System.Windows.Forms.RichTextBox();
            this.lblKisiAdres = new System.Windows.Forms.Label();
            this.txtKisiEposta = new System.Windows.Forms.TextBox();
            this.txtKisiTelNo = new System.Windows.Forms.TextBox();
            this.txtKisiCinsiyet = new System.Windows.Forms.TextBox();
            this.txtKisiDogumTarihi = new System.Windows.Forms.TextBox();
            this.txtKisiSoyad = new System.Windows.Forms.TextBox();
            this.txtKisiAd = new System.Windows.Forms.TextBox();
            this.txtTckNo = new System.Windows.Forms.TextBox();
            this.lblKisiEposta = new System.Windows.Forms.Label();
            this.lblKisiTelefon = new System.Windows.Forms.Label();
            this.lblKisiCinsiyet = new System.Windows.Forms.Label();
            this.lblKisiDogumTarihi = new System.Windows.Forms.Label();
            this.lblKisiSoyad = new System.Windows.Forms.Label();
            this.lblKisiAd = new System.Windows.Forms.Label();
            this.lblKisiTCKimlik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Location = new System.Drawing.Point(0, 194);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.Size = new System.Drawing.Size(962, 499);
            this.dgvUyeler.TabIndex = 0;
            this.dgvUyeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.btnUyeSayim);
            this.groupBox1.Controls.Add(this.btnBloke);
            this.groupBox1.Controls.Add(this.btnKisiAra);
            this.groupBox1.Controls.Add(this.btnOducIslemleri);
            this.groupBox1.Controls.Add(this.btnKitapListesi);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Controls.Add(this.btnYeniKisiEkle);
            this.groupBox1.Controls.Add(this.btnKisiSil);
            this.groupBox1.Controls.Add(this.btnKisiDuzenle);
            this.groupBox1.Controls.Add(this.cmbAramaTuru);
            this.groupBox1.Controls.Add(this.txtAranacakDeger);
            this.groupBox1.Controls.Add(this.lblKisiAranacakDeger);
            this.groupBox1.Controls.Add(this.lblKisiAramaTuru);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // btnUyeSayim
            // 
            this.btnUyeSayim.Image = ((System.Drawing.Image)(resources.GetObject("btnUyeSayim.Image")));
            this.btnUyeSayim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUyeSayim.Location = new System.Drawing.Point(119, 77);
            this.btnUyeSayim.Name = "btnUyeSayim";
            this.btnUyeSayim.Size = new System.Drawing.Size(58, 26);
            this.btnUyeSayim.TabIndex = 20;
            this.btnUyeSayim.Text = "Sayım";
            this.btnUyeSayim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUyeSayim.UseVisualStyleBackColor = true;
            this.btnUyeSayim.Click += new System.EventHandler(this.btnUyeSayim_Click);
            // 
            // btnBloke
            // 
            this.btnBloke.Image = ((System.Drawing.Image)(resources.GetObject("btnBloke.Image")));
            this.btnBloke.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBloke.Location = new System.Drawing.Point(38, 77);
            this.btnBloke.Name = "btnBloke";
            this.btnBloke.Size = new System.Drawing.Size(75, 26);
            this.btnBloke.TabIndex = 21;
            this.btnBloke.Text = "Bloke";
            this.btnBloke.UseVisualStyleBackColor = true;
            this.btnBloke.Click += new System.EventHandler(this.btnBloke_Click);
            // 
            // btnKisiAra
            // 
            this.btnKisiAra.Image = ((System.Drawing.Image)(resources.GetObject("btnKisiAra.Image")));
            this.btnKisiAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKisiAra.Location = new System.Drawing.Point(119, 103);
            this.btnKisiAra.Name = "btnKisiAra";
            this.btnKisiAra.Size = new System.Drawing.Size(75, 23);
            this.btnKisiAra.TabIndex = 3;
            this.btnKisiAra.Text = "Ara";
            this.btnKisiAra.UseVisualStyleBackColor = true;
            this.btnKisiAra.Click += new System.EventHandler(this.btnKisiAra_Click);
            // 
            // btnOducIslemleri
            // 
            this.btnOducIslemleri.Location = new System.Drawing.Point(119, 154);
            this.btnOducIslemleri.Name = "btnOducIslemleri";
            this.btnOducIslemleri.Size = new System.Drawing.Size(111, 23);
            this.btnOducIslemleri.TabIndex = 3;
            this.btnOducIslemleri.Text = "Ödünç İşlemleri";
            this.btnOducIslemleri.UseVisualStyleBackColor = true;
            this.btnOducIslemleri.Click += new System.EventHandler(this.btnOducIslemleri_Click);
            // 
            // btnKitapListesi
            // 
            this.btnKitapListesi.Location = new System.Drawing.Point(15, 128);
            this.btnKitapListesi.Name = "btnKitapListesi";
            this.btnKitapListesi.Size = new System.Drawing.Size(97, 23);
            this.btnKitapListesi.TabIndex = 4;
            this.btnKitapListesi.Text = "Kitap Listesi";
            this.btnKitapListesi.UseVisualStyleBackColor = true;
            this.btnKitapListesi.Click += new System.EventHandler(this.btnKitapListesi_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(2, 76);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(31, 26);
            this.btnYenile.TabIndex = 18;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnYeniKisiEkle
            // 
            this.btnYeniKisiEkle.Location = new System.Drawing.Point(119, 128);
            this.btnYeniKisiEkle.Name = "btnYeniKisiEkle";
            this.btnYeniKisiEkle.Size = new System.Drawing.Size(97, 23);
            this.btnYeniKisiEkle.TabIndex = 6;
            this.btnYeniKisiEkle.Text = "Yeni Kişi Ekle";
            this.btnYeniKisiEkle.UseVisualStyleBackColor = true;
            this.btnYeniKisiEkle.Click += new System.EventHandler(this.btnYeniKisiEkle_Click);
            // 
            // btnKisiSil
            // 
            this.btnKisiSil.Location = new System.Drawing.Point(38, 154);
            this.btnKisiSil.Name = "btnKisiSil";
            this.btnKisiSil.Size = new System.Drawing.Size(75, 23);
            this.btnKisiSil.TabIndex = 5;
            this.btnKisiSil.Text = "Kişiyi Sil";
            this.btnKisiSil.UseVisualStyleBackColor = true;
            this.btnKisiSil.Click += new System.EventHandler(this.btnKisiSil_Click);
            // 
            // btnKisiDuzenle
            // 
            this.btnKisiDuzenle.Location = new System.Drawing.Point(2, 103);
            this.btnKisiDuzenle.Name = "btnKisiDuzenle";
            this.btnKisiDuzenle.Size = new System.Drawing.Size(111, 23);
            this.btnKisiDuzenle.TabIndex = 4;
            this.btnKisiDuzenle.Text = "Kişiyi Düzenle";
            this.btnKisiDuzenle.UseVisualStyleBackColor = true;
            this.btnKisiDuzenle.Click += new System.EventHandler(this.btnKisiDuzenle_Click);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Items.AddRange(new object[] {
            "TC NO",
            "Ad",
            "Soyad",
            "Doğum Tarihi",
            "Cinsiyet",
            "Telefon Numarası",
            "E-Posta",
            "Adres"});
            this.cmbAramaTuru.Location = new System.Drawing.Point(104, 29);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(100, 21);
            this.cmbAramaTuru.TabIndex = 0;
            this.cmbAramaTuru.Text = "TC NO";
            this.cmbAramaTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAramaTuru_SelectedIndexChanged);
            // 
            // txtAranacakDeger
            // 
            this.txtAranacakDeger.Location = new System.Drawing.Point(104, 57);
            this.txtAranacakDeger.Name = "txtAranacakDeger";
            this.txtAranacakDeger.Size = new System.Drawing.Size(100, 20);
            this.txtAranacakDeger.TabIndex = 3;
            this.txtAranacakDeger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAranacakDeger_KeyDown);
            // 
            // lblKisiAranacakDeger
            // 
            this.lblKisiAranacakDeger.AutoSize = true;
            this.lblKisiAranacakDeger.Location = new System.Drawing.Point(12, 60);
            this.lblKisiAranacakDeger.Name = "lblKisiAranacakDeger";
            this.lblKisiAranacakDeger.Size = new System.Drawing.Size(91, 13);
            this.lblKisiAranacakDeger.TabIndex = 1;
            this.lblKisiAranacakDeger.Text = "Aranacak Değer :";
            // 
            // lblKisiAramaTuru
            // 
            this.lblKisiAramaTuru.AutoSize = true;
            this.lblKisiAramaTuru.Location = new System.Drawing.Point(30, 32);
            this.lblKisiAramaTuru.Name = "lblKisiAramaTuru";
            this.lblKisiAramaTuru.Size = new System.Drawing.Size(68, 13);
            this.lblKisiAramaTuru.TabIndex = 0;
            this.lblKisiAramaTuru.Text = "Arama Türü :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.txtKisiEklenmeTarihi);
            this.groupBox2.Controls.Add(this.lblKisiEklenmeTarihi);
            this.groupBox2.Controls.Add(this.rctxtKisiAdres);
            this.groupBox2.Controls.Add(this.lblKisiAdres);
            this.groupBox2.Controls.Add(this.txtKisiEposta);
            this.groupBox2.Controls.Add(this.txtKisiTelNo);
            this.groupBox2.Controls.Add(this.txtKisiCinsiyet);
            this.groupBox2.Controls.Add(this.txtKisiDogumTarihi);
            this.groupBox2.Controls.Add(this.txtKisiSoyad);
            this.groupBox2.Controls.Add(this.txtKisiAd);
            this.groupBox2.Controls.Add(this.txtTckNo);
            this.groupBox2.Controls.Add(this.lblKisiEposta);
            this.groupBox2.Controls.Add(this.lblKisiTelefon);
            this.groupBox2.Controls.Add(this.lblKisiCinsiyet);
            this.groupBox2.Controls.Add(this.lblKisiDogumTarihi);
            this.groupBox2.Controls.Add(this.lblKisiSoyad);
            this.groupBox2.Controls.Add(this.lblKisiAd);
            this.groupBox2.Controls.Add(this.lblKisiTCKimlik);
            this.groupBox2.Location = new System.Drawing.Point(237, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 194);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Bilgileri";
            // 
            // txtKisiEklenmeTarihi
            // 
            this.txtKisiEklenmeTarihi.Location = new System.Drawing.Point(435, 54);
            this.txtKisiEklenmeTarihi.Name = "txtKisiEklenmeTarihi";
            this.txtKisiEklenmeTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtKisiEklenmeTarihi.TabIndex = 19;
            // 
            // lblKisiEklenmeTarihi
            // 
            this.lblKisiEklenmeTarihi.AutoSize = true;
            this.lblKisiEklenmeTarihi.Location = new System.Drawing.Point(441, 32);
            this.lblKisiEklenmeTarihi.Name = "lblKisiEklenmeTarihi";
            this.lblKisiEklenmeTarihi.Size = new System.Drawing.Size(83, 13);
            this.lblKisiEklenmeTarihi.TabIndex = 16;
            this.lblKisiEklenmeTarihi.Text = "Eklenme Tarihi :";
            // 
            // rctxtKisiAdres
            // 
            this.rctxtKisiAdres.Location = new System.Drawing.Point(302, 81);
            this.rctxtKisiAdres.Name = "rctxtKisiAdres";
            this.rctxtKisiAdres.Size = new System.Drawing.Size(100, 96);
            this.rctxtKisiAdres.TabIndex = 15;
            this.rctxtKisiAdres.Text = "";
            // 
            // lblKisiAdres
            // 
            this.lblKisiAdres.AutoSize = true;
            this.lblKisiAdres.Location = new System.Drawing.Point(256, 84);
            this.lblKisiAdres.Name = "lblKisiAdres";
            this.lblKisiAdres.Size = new System.Drawing.Size(40, 13);
            this.lblKisiAdres.TabIndex = 14;
            this.lblKisiAdres.Text = "Adres :";
            // 
            // txtKisiEposta
            // 
            this.txtKisiEposta.Location = new System.Drawing.Point(302, 55);
            this.txtKisiEposta.Name = "txtKisiEposta";
            this.txtKisiEposta.Size = new System.Drawing.Size(100, 20);
            this.txtKisiEposta.TabIndex = 13;
            // 
            // txtKisiTelNo
            // 
            this.txtKisiTelNo.Location = new System.Drawing.Point(302, 32);
            this.txtKisiTelNo.Name = "txtKisiTelNo";
            this.txtKisiTelNo.Size = new System.Drawing.Size(100, 20);
            this.txtKisiTelNo.TabIndex = 12;
            // 
            // txtKisiCinsiyet
            // 
            this.txtKisiCinsiyet.Location = new System.Drawing.Point(82, 135);
            this.txtKisiCinsiyet.Name = "txtKisiCinsiyet";
            this.txtKisiCinsiyet.Size = new System.Drawing.Size(100, 20);
            this.txtKisiCinsiyet.TabIndex = 11;
            // 
            // txtKisiDogumTarihi
            // 
            this.txtKisiDogumTarihi.Location = new System.Drawing.Point(82, 107);
            this.txtKisiDogumTarihi.Name = "txtKisiDogumTarihi";
            this.txtKisiDogumTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtKisiDogumTarihi.TabIndex = 10;
            // 
            // txtKisiSoyad
            // 
            this.txtKisiSoyad.Location = new System.Drawing.Point(82, 80);
            this.txtKisiSoyad.Name = "txtKisiSoyad";
            this.txtKisiSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtKisiSoyad.TabIndex = 9;
            this.txtKisiSoyad.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtKisiAd
            // 
            this.txtKisiAd.Location = new System.Drawing.Point(82, 57);
            this.txtKisiAd.Name = "txtKisiAd";
            this.txtKisiAd.Size = new System.Drawing.Size(100, 20);
            this.txtKisiAd.TabIndex = 8;
            // 
            // txtTckNo
            // 
            this.txtTckNo.Location = new System.Drawing.Point(82, 29);
            this.txtTckNo.Name = "txtTckNo";
            this.txtTckNo.Size = new System.Drawing.Size(100, 20);
            this.txtTckNo.TabIndex = 7;
            // 
            // lblKisiEposta
            // 
            this.lblKisiEposta.AutoSize = true;
            this.lblKisiEposta.Location = new System.Drawing.Point(246, 57);
            this.lblKisiEposta.Name = "lblKisiEposta";
            this.lblKisiEposta.Size = new System.Drawing.Size(50, 13);
            this.lblKisiEposta.TabIndex = 6;
            this.lblKisiEposta.Text = "E-Posta :";
            // 
            // lblKisiTelefon
            // 
            this.lblKisiTelefon.AutoSize = true;
            this.lblKisiTelefon.Location = new System.Drawing.Point(200, 30);
            this.lblKisiTelefon.Name = "lblKisiTelefon";
            this.lblKisiTelefon.Size = new System.Drawing.Size(96, 13);
            this.lblKisiTelefon.TabIndex = 5;
            this.lblKisiTelefon.Text = "Telefon Numarası :";
            // 
            // lblKisiCinsiyet
            // 
            this.lblKisiCinsiyet.AutoSize = true;
            this.lblKisiCinsiyet.Location = new System.Drawing.Point(30, 138);
            this.lblKisiCinsiyet.Name = "lblKisiCinsiyet";
            this.lblKisiCinsiyet.Size = new System.Drawing.Size(49, 13);
            this.lblKisiCinsiyet.TabIndex = 4;
            this.lblKisiCinsiyet.Text = "Cinsiyet :";
            // 
            // lblKisiDogumTarihi
            // 
            this.lblKisiDogumTarihi.AutoSize = true;
            this.lblKisiDogumTarihi.Location = new System.Drawing.Point(6, 114);
            this.lblKisiDogumTarihi.Name = "lblKisiDogumTarihi";
            this.lblKisiDogumTarihi.Size = new System.Drawing.Size(76, 13);
            this.lblKisiDogumTarihi.TabIndex = 3;
            this.lblKisiDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // lblKisiSoyad
            // 
            this.lblKisiSoyad.AutoSize = true;
            this.lblKisiSoyad.Location = new System.Drawing.Point(36, 83);
            this.lblKisiSoyad.Name = "lblKisiSoyad";
            this.lblKisiSoyad.Size = new System.Drawing.Size(43, 13);
            this.lblKisiSoyad.TabIndex = 2;
            this.lblKisiSoyad.Text = "Soyad :";
            // 
            // lblKisiAd
            // 
            this.lblKisiAd.AutoSize = true;
            this.lblKisiAd.Location = new System.Drawing.Point(53, 56);
            this.lblKisiAd.Name = "lblKisiAd";
            this.lblKisiAd.Size = new System.Drawing.Size(26, 13);
            this.lblKisiAd.TabIndex = 1;
            this.lblKisiAd.Text = "Ad :";
            // 
            // lblKisiTCKimlik
            // 
            this.lblKisiTCKimlik.AutoSize = true;
            this.lblKisiTCKimlik.Location = new System.Drawing.Point(29, 29);
            this.lblKisiTCKimlik.Name = "lblKisiTCKimlik";
            this.lblKisiTCKimlik.Size = new System.Drawing.Size(46, 13);
            this.lblKisiTCKimlik.TabIndex = 0;
            this.lblKisiTCKimlik.Text = "TC NO :";
            // 
            // uyelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUyeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "uyelerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeler Form";
            this.Load += new System.EventHandler(this.uyelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.TextBox txtAranacakDeger;
        private System.Windows.Forms.Label lblKisiAranacakDeger;
        private System.Windows.Forms.Label lblKisiAramaTuru;
        private System.Windows.Forms.Button btnYeniKisiEkle;
        private System.Windows.Forms.Button btnKisiSil;
        private System.Windows.Forms.Button btnKisiDuzenle;
        private System.Windows.Forms.Label lblKisiTCKimlik;
        private System.Windows.Forms.Label lblKisiTelefon;
        private System.Windows.Forms.Label lblKisiCinsiyet;
        private System.Windows.Forms.Label lblKisiDogumTarihi;
        private System.Windows.Forms.Label lblKisiSoyad;
        private System.Windows.Forms.Label lblKisiAd;
        private System.Windows.Forms.RichTextBox rctxtKisiAdres;
        private System.Windows.Forms.Label lblKisiAdres;
        private System.Windows.Forms.TextBox txtKisiEposta;
        private System.Windows.Forms.TextBox txtKisiTelNo;
        private System.Windows.Forms.TextBox txtKisiCinsiyet;
        private System.Windows.Forms.TextBox txtKisiDogumTarihi;
        private System.Windows.Forms.TextBox txtKisiSoyad;
        private System.Windows.Forms.TextBox txtKisiAd;
        private System.Windows.Forms.TextBox txtTckNo;
        private System.Windows.Forms.Label lblKisiEposta;
        private System.Windows.Forms.Label lblKisiEklenmeTarihi;
        private System.Windows.Forms.TextBox txtKisiEklenmeTarihi;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnOducIslemleri;
        private System.Windows.Forms.Button btnKitapListesi;
        private System.Windows.Forms.Button btnKisiAra;
        private System.Windows.Forms.Button btnUyeSayim;
        private System.Windows.Forms.Button btnBloke;
    }
}