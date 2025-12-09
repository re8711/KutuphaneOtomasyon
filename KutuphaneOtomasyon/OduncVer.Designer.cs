namespace KutuphaneOtomasyon
{
    partial class OduncVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncVer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTcknoAra = new System.Windows.Forms.ComboBox();
            this.cmbIsbnAra = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.dtpAlinacakTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpVerilmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBarkodOkuyucuİleOkut = new System.Windows.Forms.Button();
            this.btnGirdileriTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKameraİleOkut = new System.Windows.Forms.Button();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtKitapYazari = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.cmbTcknoAra);
            this.groupBox1.Controls.Add(this.cmbIsbnAra);
            this.groupBox1.Controls.Add(this.cmbCinsiyet);
            this.groupBox1.Controls.Add(this.dtpAlinacakTarih);
            this.groupBox1.Controls.Add(this.dtpVerilmeTarihi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnBarkodOkuyucuİleOkut);
            this.groupBox1.Controls.Add(this.btnGirdileriTemizle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.btnKameraİleOkut);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.txtKitapYazari);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ödünç Ver";
            // 
            // cmbTcknoAra
            // 
            this.cmbTcknoAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTcknoAra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbTcknoAra.FormattingEnabled = true;
            this.cmbTcknoAra.Location = new System.Drawing.Point(404, 50);
            this.cmbTcknoAra.Name = "cmbTcknoAra";
            this.cmbTcknoAra.Size = new System.Drawing.Size(121, 21);
            this.cmbTcknoAra.TabIndex = 27;
            this.cmbTcknoAra.TextChanged += new System.EventHandler(this.cmbTcknoAra_TextChanged);
            this.cmbTcknoAra.Leave += new System.EventHandler(this.cmbTcknoAra_Leave);
            // 
            // cmbIsbnAra
            // 
            this.cmbIsbnAra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbIsbnAra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cmbIsbnAra.FormattingEnabled = true;
            this.cmbIsbnAra.Location = new System.Drawing.Point(113, 48);
            this.cmbIsbnAra.Name = "cmbIsbnAra";
            this.cmbIsbnAra.Size = new System.Drawing.Size(121, 21);
            this.cmbIsbnAra.TabIndex = 26;
            this.cmbIsbnAra.TextChanged += new System.EventHandler(this.cmbIsbnAra_TextChanged);
            this.cmbIsbnAra.Leave += new System.EventHandler(this.cmbIsbnAra_Leave);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(403, 103);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(201, 21);
            this.cmbCinsiyet.TabIndex = 25;
            // 
            // dtpAlinacakTarih
            // 
            this.dtpAlinacakTarih.Location = new System.Drawing.Point(404, 133);
            this.dtpAlinacakTarih.Name = "dtpAlinacakTarih";
            this.dtpAlinacakTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpAlinacakTarih.TabIndex = 24;
            // 
            // dtpVerilmeTarihi
            // 
            this.dtpVerilmeTarihi.Location = new System.Drawing.Point(113, 133);
            this.dtpVerilmeTarihi.Name = "dtpVerilmeTarihi";
            this.dtpVerilmeTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpVerilmeTarihi.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(338, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "bilgi: Eğer girilen ISBN veya TC no kayıtlı ise bilgiler otomatik doldurulur";
            // 
            // btnBarkodOkuyucuİleOkut
            // 
            this.btnBarkodOkuyucuİleOkut.Location = new System.Drawing.Point(164, 188);
            this.btnBarkodOkuyucuİleOkut.Name = "btnBarkodOkuyucuİleOkut";
            this.btnBarkodOkuyucuİleOkut.Size = new System.Drawing.Size(111, 58);
            this.btnBarkodOkuyucuİleOkut.TabIndex = 21;
            this.btnBarkodOkuyucuİleOkut.Text = "Barkod okuyucu ile ISBN okut";
            this.btnBarkodOkuyucuİleOkut.UseVisualStyleBackColor = true;
            // 
            // btnGirdileriTemizle
            // 
            this.btnGirdileriTemizle.Location = new System.Drawing.Point(404, 186);
            this.btnGirdileriTemizle.Name = "btnGirdileriTemizle";
            this.btnGirdileriTemizle.Size = new System.Drawing.Size(109, 60);
            this.btnGirdileriTemizle.TabIndex = 20;
            this.btnGirdileriTemizle.Text = "Girdileri Temizle";
            this.btnGirdileriTemizle.UseVisualStyleBackColor = true;
            this.btnGirdileriTemizle.Click += new System.EventHandler(this.btnGirdileriTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(519, 186);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(109, 60);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnKameraİleOkut
            // 
            this.btnKameraİleOkut.Location = new System.Drawing.Point(47, 186);
            this.btnKameraİleOkut.Name = "btnKameraİleOkut";
            this.btnKameraİleOkut.Size = new System.Drawing.Size(111, 60);
            this.btnKameraİleOkut.TabIndex = 18;
            this.btnKameraİleOkut.Text = "Kamera ile ISBN okut";
            this.btnKameraİleOkut.UseVisualStyleBackColor = true;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(113, 77);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 20);
            this.txtKitapAdi.TabIndex = 17;
            // 
            // txtKitapYazari
            // 
            this.txtKitapYazari.Location = new System.Drawing.Point(113, 103);
            this.txtKitapYazari.Name = "txtKitapYazari";
            this.txtKitapYazari.Size = new System.Drawing.Size(200, 20);
            this.txtKitapYazari.TabIndex = 16;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(403, 77);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(201, 20);
            this.txtAdSoyad.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Alınacak Tarih:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ad Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(354, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TC NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Verilme Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap Yazarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            // 
            // OduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 335);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OduncVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Ver";
            this.Load += new System.EventHandler(this.OduncVer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKameraİleOkut;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtKitapYazari;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarkodOkuyucuİleOkut;
        private System.Windows.Forms.Button btnGirdileriTemizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.DateTimePicker dtpAlinacakTarih;
        private System.Windows.Forms.DateTimePicker dtpVerilmeTarihi;
        private System.Windows.Forms.ComboBox cmbTcknoAra;
        private System.Windows.Forms.ComboBox cmbIsbnAra;
    }
}