namespace KutuphaneOtomasyon
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVeriCek = new System.Windows.Forms.Button();
            this.dgvKitapListesi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbAramaTuru = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnUyeler = new System.Windows.Forms.Button();
            this.btnKitabiSil = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.btnKitabiDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtAranacakDeger = new System.Windows.Forms.TextBox();
            this.lblAranacakDeger = new System.Windows.Forms.Label();
            this.lblAramaTuru = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbYayinEvi = new System.Windows.Forms.ComboBox();
            this.cmbYazar = new System.Windows.Forms.ComboBox();
            this.lblMevcut = new System.Windows.Forms.Label();
            this.lblOduncte = new System.Windows.Forms.Label();
            this.lblToplamStok = new System.Windows.Forms.Label();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.txtEklenmeTarihi = new System.Windows.Forms.TextBox();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtBagislayan = new System.Windows.Forms.TextBox();
            this.txtTeminTarihi = new System.Windows.Forms.TextBox();
            this.txtTeminTuru = new System.Windows.Forms.TextBox();
            this.txtKitapTuru = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.lblBagislayan = new System.Windows.Forms.Label();
            this.lblTeminTarihi = new System.Windows.Forms.Label();
            this.lblTeminTuru = new System.Windows.Forms.Label();
            this.lblKitapTuru = new System.Windows.Forms.Label();
            this.txtSayfaSayisi = new System.Windows.Forms.TextBox();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblYayinEvi = new System.Windows.Forms.Label();
            this.lblSayfaSayisi = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblKitapAdi = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListesi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVeriCek
            // 
            this.btnVeriCek.Location = new System.Drawing.Point(112, 140);
            this.btnVeriCek.Name = "btnVeriCek";
            this.btnVeriCek.Size = new System.Drawing.Size(100, 36);
            this.btnVeriCek.TabIndex = 0;
            this.btnVeriCek.Text = "Yeni Kitap Ekle";
            this.btnVeriCek.UseVisualStyleBackColor = true;
            // 
            // dgvKitapListesi
            // 
            this.dgvKitapListesi.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvKitapListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapListesi.Location = new System.Drawing.Point(0, 216);
            this.dgvKitapListesi.Name = "dgvKitapListesi";
            this.dgvKitapListesi.Size = new System.Drawing.Size(1141, 460);
            this.dgvKitapListesi.TabIndex = 1;
            this.dgvKitapListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitapListesi_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.cmbAramaTuru);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnUyeler);
            this.groupBox1.Controls.Add(this.btnKitabiSil);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.btnKitabiDuzenle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtAranacakDeger);
            this.groupBox1.Controls.Add(this.lblAranacakDeger);
            this.groupBox1.Controls.Add(this.lblAramaTuru);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ara";
            // 
            // btnAra
            // 
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.Location = new System.Drawing.Point(51, 80);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(49, 36);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            this.btnAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAranacakDeger_KeyDown);
            // 
            // cmbAramaTuru
            // 
            this.cmbAramaTuru.FormattingEnabled = true;
            this.cmbAramaTuru.Location = new System.Drawing.Point(97, 19);
            this.cmbAramaTuru.Name = "cmbAramaTuru";
            this.cmbAramaTuru.Size = new System.Drawing.Size(101, 21);
            this.cmbAramaTuru.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "Ödünç İşlemleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnUyeler
            // 
            this.btnUyeler.Location = new System.Drawing.Point(7, 122);
            this.btnUyeler.Name = "btnUyeler";
            this.btnUyeler.Size = new System.Drawing.Size(75, 23);
            this.btnUyeler.TabIndex = 8;
            this.btnUyeler.Text = "Üyeler";
            this.btnUyeler.UseVisualStyleBackColor = true;
            this.btnUyeler.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKitabiSil
            // 
            this.btnKitabiSil.Location = new System.Drawing.Point(106, 162);
            this.btnKitabiSil.Name = "btnKitabiSil";
            this.btnKitabiSil.Size = new System.Drawing.Size(75, 23);
            this.btnKitabiSil.TabIndex = 6;
            this.btnKitabiSil.Text = "Kitabı Sil";
            this.btnKitabiSil.UseVisualStyleBackColor = true;
            this.btnKitabiSil.Click += new System.EventHandler(this.btnKitabiSil_Click);
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(107, 87);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 7;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // btnKitabiDuzenle
            // 
            this.btnKitabiDuzenle.Location = new System.Drawing.Point(88, 117);
            this.btnKitabiDuzenle.Name = "btnKitabiDuzenle";
            this.btnKitabiDuzenle.Size = new System.Drawing.Size(94, 36);
            this.btnKitabiDuzenle.TabIndex = 4;
            this.btnKitabiDuzenle.Text = "Kitabı Düzenle";
            this.btnKitabiDuzenle.UseVisualStyleBackColor = true;
            this.btnKitabiDuzenle.Click += new System.EventHandler(this.btnKitabiDuzenle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 80);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(48, 36);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Menü";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtAranacakDeger
            // 
            this.txtAranacakDeger.Location = new System.Drawing.Point(98, 54);
            this.txtAranacakDeger.Name = "txtAranacakDeger";
            this.txtAranacakDeger.Size = new System.Drawing.Size(100, 20);
            this.txtAranacakDeger.TabIndex = 4;
            // 
            // lblAranacakDeger
            // 
            this.lblAranacakDeger.AutoSize = true;
            this.lblAranacakDeger.Location = new System.Drawing.Point(4, 57);
            this.lblAranacakDeger.Name = "lblAranacakDeger";
            this.lblAranacakDeger.Size = new System.Drawing.Size(88, 13);
            this.lblAranacakDeger.TabIndex = 2;
            this.lblAranacakDeger.Text = "Aranacak Değer:";
            // 
            // lblAramaTuru
            // 
            this.lblAramaTuru.AutoSize = true;
            this.lblAramaTuru.Location = new System.Drawing.Point(27, 24);
            this.lblAramaTuru.Name = "lblAramaTuru";
            this.lblAramaTuru.Size = new System.Drawing.Size(65, 13);
            this.lblAramaTuru.TabIndex = 1;
            this.lblAramaTuru.Text = "Arama Türü:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.cmbYayinEvi);
            this.groupBox2.Controls.Add(this.cmbYazar);
            this.groupBox2.Controls.Add(this.lblMevcut);
            this.groupBox2.Controls.Add(this.lblOduncte);
            this.groupBox2.Controls.Add(this.lblToplamStok);
            this.groupBox2.Controls.Add(this.btnExcelAktar);
            this.groupBox2.Controls.Add(this.btnYenile);
            this.groupBox2.Controls.Add(this.txtEklenmeTarihi);
            this.groupBox2.Controls.Add(this.lblEklenmeTarihi);
            this.groupBox2.Controls.Add(this.txtStok);
            this.groupBox2.Controls.Add(this.txtBagislayan);
            this.groupBox2.Controls.Add(this.txtTeminTarihi);
            this.groupBox2.Controls.Add(this.txtTeminTuru);
            this.groupBox2.Controls.Add(this.txtKitapTuru);
            this.groupBox2.Controls.Add(this.lblStok);
            this.groupBox2.Controls.Add(this.lblBagislayan);
            this.groupBox2.Controls.Add(this.lblTeminTarihi);
            this.groupBox2.Controls.Add(this.lblTeminTuru);
            this.groupBox2.Controls.Add(this.lblKitapTuru);
            this.groupBox2.Controls.Add(this.txtSayfaSayisi);
            this.groupBox2.Controls.Add(this.txtKitapAd);
            this.groupBox2.Controls.Add(this.txtISBN);
            this.groupBox2.Controls.Add(this.lblYayinEvi);
            this.groupBox2.Controls.Add(this.lblSayfaSayisi);
            this.groupBox2.Controls.Add(this.lblYazar);
            this.groupBox2.Controls.Add(this.lblKitapAdi);
            this.groupBox2.Controls.Add(this.lblISBN);
            this.groupBox2.Location = new System.Drawing.Point(218, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 216);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap Bilgileri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbYayinEvi
            // 
            this.cmbYayinEvi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbYayinEvi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYayinEvi.FormattingEnabled = true;
            this.cmbYayinEvi.Location = new System.Drawing.Point(95, 149);
            this.cmbYayinEvi.Name = "cmbYayinEvi";
            this.cmbYayinEvi.Size = new System.Drawing.Size(100, 21);
            this.cmbYayinEvi.TabIndex = 29;
            // 
            // cmbYazar
            // 
            this.cmbYazar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbYazar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbYazar.FormattingEnabled = true;
            this.cmbYazar.Location = new System.Drawing.Point(95, 84);
            this.cmbYazar.Name = "cmbYazar";
            this.cmbYazar.Size = new System.Drawing.Size(100, 21);
            this.cmbYazar.TabIndex = 28;
            // 
            // lblMevcut
            // 
            this.lblMevcut.AutoSize = true;
            this.lblMevcut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMevcut.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMevcut.Location = new System.Drawing.Point(390, 117);
            this.lblMevcut.Name = "lblMevcut";
            this.lblMevcut.Size = new System.Drawing.Size(41, 13);
            this.lblMevcut.TabIndex = 27;
            this.lblMevcut.Text = "label3";
            // 
            // lblOduncte
            // 
            this.lblOduncte.AutoSize = true;
            this.lblOduncte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOduncte.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblOduncte.Location = new System.Drawing.Point(390, 91);
            this.lblOduncte.Name = "lblOduncte";
            this.lblOduncte.Size = new System.Drawing.Size(41, 13);
            this.lblOduncte.TabIndex = 26;
            this.lblOduncte.Text = "label2";
            // 
            // lblToplamStok
            // 
            this.lblToplamStok.AutoSize = true;
            this.lblToplamStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamStok.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblToplamStok.Location = new System.Drawing.Point(390, 68);
            this.lblToplamStok.Name = "lblToplamStok";
            this.lblToplamStok.Size = new System.Drawing.Size(41, 13);
            this.lblToplamStok.TabIndex = 25;
            this.lblToplamStok.Text = "label1";
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelAktar.Image")));
            this.btnExcelAktar.Location = new System.Drawing.Point(436, 142);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(35, 34);
            this.btnExcelAktar.TabIndex = 23;
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.LightCyan;
            this.btnYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnYenile.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.Image")));
            this.btnYenile.Location = new System.Drawing.Point(393, 140);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(37, 36);
            this.btnYenile.TabIndex = 22;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // txtEklenmeTarihi
            // 
            this.txtEklenmeTarihi.Location = new System.Drawing.Point(413, 36);
            this.txtEklenmeTarihi.Name = "txtEklenmeTarihi";
            this.txtEklenmeTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtEklenmeTarihi.TabIndex = 21;
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(410, 20);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(80, 13);
            this.lblEklenmeTarihi.TabIndex = 20;
            this.lblEklenmeTarihi.Text = "Eklenme Tarihi:";
            this.lblEklenmeTarihi.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(284, 152);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 20);
            this.txtStok.TabIndex = 19;
            // 
            // txtBagislayan
            // 
            this.txtBagislayan.Location = new System.Drawing.Point(284, 117);
            this.txtBagislayan.Name = "txtBagislayan";
            this.txtBagislayan.Size = new System.Drawing.Size(100, 20);
            this.txtBagislayan.TabIndex = 18;
            // 
            // txtTeminTarihi
            // 
            this.txtTeminTarihi.Location = new System.Drawing.Point(284, 87);
            this.txtTeminTarihi.Name = "txtTeminTarihi";
            this.txtTeminTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtTeminTarihi.TabIndex = 17;
            // 
            // txtTeminTuru
            // 
            this.txtTeminTuru.Location = new System.Drawing.Point(284, 50);
            this.txtTeminTuru.Name = "txtTeminTuru";
            this.txtTeminTuru.Size = new System.Drawing.Size(100, 20);
            this.txtTeminTuru.TabIndex = 16;
            // 
            // txtKitapTuru
            // 
            this.txtKitapTuru.Location = new System.Drawing.Point(284, 17);
            this.txtKitapTuru.Name = "txtKitapTuru";
            this.txtKitapTuru.Size = new System.Drawing.Size(100, 20);
            this.txtKitapTuru.TabIndex = 15;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(246, 155);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 13);
            this.lblStok.TabIndex = 14;
            this.lblStok.Text = "Stok:";
            // 
            // lblBagislayan
            // 
            this.lblBagislayan.AutoSize = true;
            this.lblBagislayan.Location = new System.Drawing.Point(217, 120);
            this.lblBagislayan.Name = "lblBagislayan";
            this.lblBagislayan.Size = new System.Drawing.Size(61, 13);
            this.lblBagislayan.TabIndex = 13;
            this.lblBagislayan.Text = "Bağışlayan:";
            // 
            // lblTeminTarihi
            // 
            this.lblTeminTarihi.AutoSize = true;
            this.lblTeminTarihi.Location = new System.Drawing.Point(210, 90);
            this.lblTeminTarihi.Name = "lblTeminTarihi";
            this.lblTeminTarihi.Size = new System.Drawing.Size(68, 13);
            this.lblTeminTarihi.TabIndex = 12;
            this.lblTeminTarihi.Text = "Temin Tarihi:";
            // 
            // lblTeminTuru
            // 
            this.lblTeminTuru.AutoSize = true;
            this.lblTeminTuru.Location = new System.Drawing.Point(214, 57);
            this.lblTeminTuru.Name = "lblTeminTuru";
            this.lblTeminTuru.Size = new System.Drawing.Size(64, 13);
            this.lblTeminTuru.TabIndex = 11;
            this.lblTeminTuru.Text = "Temin Türü:";
            // 
            // lblKitapTuru
            // 
            this.lblKitapTuru.AutoSize = true;
            this.lblKitapTuru.Location = new System.Drawing.Point(219, 20);
            this.lblKitapTuru.Name = "lblKitapTuru";
            this.lblKitapTuru.Size = new System.Drawing.Size(59, 13);
            this.lblKitapTuru.TabIndex = 10;
            this.lblKitapTuru.Text = "Kitap Türü:";
            // 
            // txtSayfaSayisi
            // 
            this.txtSayfaSayisi.Location = new System.Drawing.Point(95, 117);
            this.txtSayfaSayisi.Name = "txtSayfaSayisi";
            this.txtSayfaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtSayfaSayisi.TabIndex = 8;
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(95, 50);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(100, 20);
            this.txtKitapAd.TabIndex = 6;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(95, 17);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // lblYayinEvi
            // 
            this.lblYayinEvi.AutoSize = true;
            this.lblYayinEvi.Location = new System.Drawing.Point(26, 155);
            this.lblYayinEvi.Name = "lblYayinEvi";
            this.lblYayinEvi.Size = new System.Drawing.Size(54, 13);
            this.lblYayinEvi.TabIndex = 4;
            this.lblYayinEvi.Text = "Yayın Evi:";
            // 
            // lblSayfaSayisi
            // 
            this.lblSayfaSayisi.AutoSize = true;
            this.lblSayfaSayisi.Location = new System.Drawing.Point(17, 120);
            this.lblSayfaSayisi.Name = "lblSayfaSayisi";
            this.lblSayfaSayisi.Size = new System.Drawing.Size(67, 13);
            this.lblSayfaSayisi.TabIndex = 3;
            this.lblSayfaSayisi.Text = "Sayfa Sayısı:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(43, 90);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(37, 13);
            this.lblYazar.TabIndex = 2;
            this.lblYazar.Text = "Yazar:";
            // 
            // lblKitapAdi
            // 
            this.lblKitapAdi.AutoSize = true;
            this.lblKitapAdi.Location = new System.Drawing.Point(28, 57);
            this.lblKitapAdi.Name = "lblKitapAdi";
            this.lblKitapAdi.Size = new System.Drawing.Size(52, 13);
            this.lblKitapAdi.TabIndex = 1;
            this.lblKitapAdi.Text = "Kitap Adı:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(47, 20);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(762, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVeriCek);
            this.Controls.Add(this.dgvKitapListesi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapListesi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeriCek;
        private System.Windows.Forms.DataGridView dgvKitapListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAranacakDeger;
        private System.Windows.Forms.Label lblAranacakDeger;
        private System.Windows.Forms.Label lblAramaTuru;
        private System.Windows.Forms.Button btnKitabiDuzenle;
        private System.Windows.Forms.TextBox txtEklenmeTarihi;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtBagislayan;
        private System.Windows.Forms.TextBox txtTeminTarihi;
        private System.Windows.Forms.TextBox txtTeminTuru;
        private System.Windows.Forms.TextBox txtKitapTuru;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label lblBagislayan;
        private System.Windows.Forms.Label lblTeminTarihi;
        private System.Windows.Forms.Label lblTeminTuru;
        private System.Windows.Forms.Label lblKitapTuru;
        private System.Windows.Forms.TextBox txtSayfaSayisi;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblYayinEvi;
        private System.Windows.Forms.Label lblSayfaSayisi;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblKitapAdi;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Button btnKitabiSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnUyeler;
        private System.Windows.Forms.ComboBox cmbAramaTuru;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Label lblMevcut;
        private System.Windows.Forms.Label lblOduncte;
        private System.Windows.Forms.Label lblToplamStok;
        private System.Windows.Forms.ComboBox cmbYayinEvi;
        private System.Windows.Forms.ComboBox cmbYazar;
    }
}

