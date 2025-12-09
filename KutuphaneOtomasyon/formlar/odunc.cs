using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace KutuphaneOtomasyon
{
    public partial class odunc : Form
    {
        public odunc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void TeslimGunuListesiniGoster()
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = @"
        SELECT 
            OI.Islem_Id, OI.TC_Kimlik_No, K.ISBN_No,
            U.Ad + ' ' + U.Soyad AS Uye_AdSoyad, K.Kitap_Adi,
            OI.Verilme_Tarihi, OI.Teslim_Tarihi, OI.Durum, OI.Ceza_Ucreti
        FROM OduncIslemleri OI
        JOIN Uyeler U ON OI.TC_Kimlik_No = U.TC_Kimlik_No
        JOIN Kitaplar K ON OI.ISBN_No = K.ISBN_No
        WHERE 
            OI.Durum = 'Ödünçte' AND 
            OI.Teslim_Tarihi = CONVERT(DATE, GETDATE()) -- KRİTİK FİLTRE
        ORDER BY OI.Teslim_Tarihi ASC";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                  
                }
                catch (Exception ex)
                {
                    
                }
            }
        }

        private void OduncIstatistikleriniGoster()
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorguBugun = "SELECT COUNT(*) FROM OduncIslemleri WHERE CAST(Teslim_Tarihi AS DATE) = CAST(GETDATE() AS DATE) AND Durum = 'Ödünçte'";

            string sorguGecikmis = "SELECT COUNT(*) FROM OduncIslemleri WHERE CAST(Teslim_Tarihi AS DATE) < CAST(GETDATE() AS DATE) AND Durum = 'Ödünçte'";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();

                    int bugunSayisi = Convert.ToInt32(new SqlCommand(sorguBugun, baglanti).ExecuteScalar());
                    int gecikmisSayisi = Convert.ToInt32(new SqlCommand(sorguGecikmis, baglanti).ExecuteScalar());

                    lblBugunAlinacak.Text = $"BUGÜN ALINACAK\n{bugunSayisi}";
                    lblGecikmis.Text = $"GECİKMİŞ KİTAPLAR\n{gecikmisSayisi}";
                }
                catch (Exception ex)
                {
                    lblBugunAlinacak.Text = "Hata";
                    lblGecikmis.Text = "Hata";
                }
            }
        }
        private void odunc_Load(object sender, EventArgs e)
        {
            OduncIstatistikleriniGoster();
            TeslimGunuListesiniGoster();
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = @"
        SELECT 
O.TC_Kimlik_No,
O.ISBN_No,
            O.Islem_Id, 
            U.Ad + ' ' + U.Soyad AS Uye_AdSoyad, 
            K.Kitap_Adi, 
            O.Verilme_Tarihi, 
            O.Teslim_Tarihi, 
            O.Durum,
            O.Ceza_Ucreti
        FROM OduncIslemleri O
        JOIN Uyeler U ON O.TC_Kimlik_No = U.TC_Kimlik_No
        JOIN Kitaplar K ON O.ISBN_No = K.ISBN_No
      
        ORDER BY O.Teslim_Tarihi ASC";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();

                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    dgvOduncListesi.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Şu anda aktif ödünç kaydı bulunmamaktadır.", "Bilgi");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: Ödünç listesi yüklenemedi. Bağlantıyı kontrol edin. Detay: " + ex.Message, "Veritabanı Hatası");
                }
            }

            cmbAramaTuru.Items.Clear();
            cmbAramaTuru.Items.Add("TC NO");
            cmbAramaTuru.Items.Add("Ad Soyad");
            cmbAramaTuru.Items.Add("Cinsiyet");
            cmbAramaTuru.Items.Add("Verilme Tarihi");
            cmbAramaTuru.Items.Add("Teslim Durumu");
            cmbAramaTuru.Items.Add("ISBN");
            cmbAramaTuru.Items.Add("Kitap Adı");
            cmbAramaTuru.Items.Add("Kitabın Yazarı");
            cmbAramaTuru.Items.Add("Alınacak Tarih");

            cmbAramaTuru.SelectedIndex = 0;
            SatirlariRenklendir();
        }

        private void SatirlariRenklendir()
        {
            if (dgvOduncListesi.Rows.Count == 0) return;

            DateTime bugun = DateTime.Now.Date;

            foreach (DataGridViewRow row in dgvOduncListesi.Rows)
            {
                if (row.IsNewRow) continue;

                string durum = row.Cells["Durum"].Value?.ToString();
                object tarihDegeri = row.Cells["Teslim_Tarihi"].Value;

                if (tarihDegeri == null || tarihDegeri == DBNull.Value) continue;

                DateTime teslimTarihi = Convert.ToDateTime(tarihDegeri).Date;

                if (durum == "Ödünçte" && teslimTarihi < bugun)
                {
                    TimeSpan gecikmeSuresi = bugun - teslimTarihi;
                    int gecikmeGun = gecikmeSuresi.Days;
                    decimal anlikCeza = gecikmeGun * 10;

                    row.Cells["Ceza_Ucreti"].Value = anlikCeza;
                }
                else if (durum == "Ödünçte")
                {
                    row.Cells["Ceza_Ucreti"].Value = 0;
                }

                if (durum == "Teslim Edildi")
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (teslimTarihi < bugun)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (teslimTarihi == bugun)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else 
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void txtTckno_TextChanged(object sender, EventArgs e)
        {
            string tckn = txtTckNo.Text.Trim();

            if (tckn.Length != 11)
            {
                txtAdSoyad.Text = "TCKN eksik.";
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT Ad, Soyad, Blokeli_Durum FROM Uyeler WHERE TC_Kimlik_No = @tckn";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@tckn", tckn);
                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = komut.ExecuteReader();

                        if (reader.Read())
                        {
                            string adSoyad = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                            bool blokeli = Convert.ToBoolean(reader["Blokeli_Durum"]);

                            txtAdSoyad.Text = adSoyad;

                            if (blokeli)
                            {
                                MessageBox.Show("BU ÜYE BLOKELİDİR. Ödünç Verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // btnOduncVer.Enabled = true;
                            }
                        }
                        else
                        {
                            txtAdSoyad.Text = "Üye Bulunamadı.";
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            string isbn = txtIsbn.Text.Trim();

            if (isbn.Length != 20)
            {
                txtKitapAdi.Text = "ISBN eksik.";
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT Kitap_Adi, Yazarlar, Stok FROM Kitaplar WHERE ISBN_No = @isbn";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@isbn", isbn);
                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = komut.ExecuteReader();

                        if (reader.Read())
                        {
                            txtKitapAdi.Text = reader["Kitap_Adi"].ToString();
                            txtKitapYazari.Text = reader["Yazarlar"].ToString();
                            int mevcutStok = Convert.ToInt32(reader["Stok"]);

                            if (mevcutStok <= 0)
                            {
                                MessageBox.Show("Bu kitap stokta yok. Ödünç Verilemez.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            txtKitapAdi.Text = "Kitap Bulunamadı.";
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kitap Çekme Hatası: {ex.Message}", "Hata");
                    }
                }
            }
        }
        private void btnKitapListesi_Click(object sender, EventArgs e)
        {
            Form1 kitaplarFormu = new Form1();
            kitaplarFormu.Show();
            this.Hide();
        }

        private void btnUyeler_Click(object sender, EventArgs e)
        {
            uyelerForm uyelerFormu = new uyelerForm();
            uyelerFormu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvOduncListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvOduncListesi.Rows.Count - 1)
            {
                return;
            }

            try
            {
                DataGridViewRow secilenSatir = dgvOduncListesi.Rows[e.RowIndex];
                string tckn = secilenSatir.Cells["TC_Kimlik_No"].Value?.ToString() ?? string.Empty;
                string isbn = secilenSatir.Cells["ISBN_No"].Value?.ToString() ?? string.Empty;

                txtTckNo.Text = tckn;
                txtIsbn.Text = isbn;

                UyeDetaylariniGetirVeDoldur(tckn);
                KitapDetaylariniGetirVeDoldur(isbn);

                txtVerilmeTarihi.Text = GetFormattedDate(secilenSatir.Cells["Verilme_Tarihi"].Value);
                txtTeslimDurumu.Text = secilenSatir.Cells["Durum"].Value?.ToString() ?? string.Empty;
                txtAlinacakTarih.Text = GetFormattedDate(secilenSatir.Cells["Teslim_Tarihi"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Detay Aktarımı Hatası. Sütun adlarını ve kontrolleri kontrol edin. Detay: {ex.Message}", "Hata");
            }
        }

        private string GetFormattedDate(object dateValue)
        {
            if (dateValue != null && DateTime.TryParse(dateValue.ToString(), out DateTime date))
            {
                return date.ToString("dd.MM.yyyy");
            }
            return "";
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            OduncVer oduncVerFormu = new OduncVer();
            oduncVerFormu.ShowDialog();
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvOduncListesi.CurrentRow == null)
            {
                MessageBox.Show("Lütfen teslim alınacak ödünç kaydını listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int islemId = Convert.ToInt32(dgvOduncListesi.CurrentRow.Cells["Islem_Id"].Value);
                string isbn = dgvOduncListesi.CurrentRow.Cells["ISBN_No"].Value.ToString();
                DateTime beklenenTeslimTarihi = Convert.ToDateTime(dgvOduncListesi.CurrentRow.Cells["Teslim_Tarihi"].Value);

                DateTime gercekTeslimTarihi = DateTime.Now.Date;
                decimal cezaUcreti = 0;

                if (gercekTeslimTarihi > beklenenTeslimTarihi)
                {
                    TimeSpan gecikme = gercekTeslimTarihi - beklenenTeslimTarihi;
                    int gecikmeGunSayisi = gecikme.Days;
                    cezaUcreti = gecikmeGunSayisi * 10;

                    if (MessageBox.Show($"Kitap {gecikmeGunSayisi} gün gecikti. Toplam Ceza Ücreti: {cezaUcreti:C2} TL.\nDevam etmek istiyor musunuz?",
                                        "Gecikme Cezası", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                    {
                        baglanti.Open();

                        string oduncGuncelleSorgu = @"
                    UPDATE OduncIslemleri SET 
                    Durum = 'Teslim Edildi', 
                    Gercek_Teslim_Tarihi = @gercekTarih, 
                    Ceza_Ucreti = @ceza 
                    WHERE Islem_Id = @id";

                        using (SqlCommand komutGuncelle = new SqlCommand(oduncGuncelleSorgu, baglanti))
                        {
                            komutGuncelle.Parameters.AddWithValue("@gercekTarih", gercekTeslimTarihi.ToString("yyyy-MM-dd"));
                            komutGuncelle.Parameters.AddWithValue("@ceza", cezaUcreti);
                            komutGuncelle.Parameters.AddWithValue("@id", islemId);
                            komutGuncelle.ExecuteNonQuery();
                        }

                        string stokArtirSorgu = "UPDATE Kitaplar SET Stok = Stok + 1 WHERE ISBN_No = @isbn";

                        using (SqlCommand komutStokArtir = new SqlCommand(stokArtirSorgu, baglanti))
                        {
                            komutStokArtir.Parameters.AddWithValue("@isbn", isbn);
                            komutStokArtir.ExecuteNonQuery();
                        }

                        scope.Complete();

                        MessageBox.Show("Kitap başarıyla teslim alındı. " + (cezaUcreti > 0 ? $"Hesaplanan Ceza: {cezaUcreti:C2} TL." : "Ceza Yok."), "Teslim Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Teslim alma işlemi sırasında hata oluştu: {ex.Message}", "Kritik Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OduncListesiniDoldur();
            OduncIstatistikleriniGoster();
        }
private void DetaylariDoldur(DataGridViewRow secilenSatir)
{
    txtTckNo.Text = secilenSatir.Cells["TC_Kimlik_No"].Value.ToString();
    
    string ad = secilenSatir.Cells["Ad"].Value.ToString();
    string soyad = secilenSatir.Cells["Soyad"].Value.ToString();
    txtAdSoyad.Text = ad + " " + soyad; 
    
    txtKitapAdi.Text = secilenSatir.Cells["Kitap_Adi"].Value.ToString();
    txtIsbn.Text = secilenSatir.Cells["ISBN_No"].Value.ToString(); 

    txtVerilmeTarihi.Text = secilenSatir.Cells["Verilme_Tarihi"].Value.ToString();
    
    txtAlinacakTarih.Text = secilenSatir.Cells["Teslim_Tarihi"].Value.ToString();
    txtTeslimDurumu.Text = secilenSatir.Cells["Durum"].Value.ToString();
    

}


        private void btnAra_Click(object sender, EventArgs e)
        {
            string arananDeger = txtArama.Text.Trim();
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = @"
    SELECT 
        OI.Islem_Id, 
        U.TC_Kimlik_No, 
        U.Ad, U.Soyad, 
        K.Kitap_Adi, 
        OI.Verilme_Tarihi, 
        OI.Teslim_Tarihi, 
        OI.Durum
    FROM 
        OduncIslemleri OI
    INNER JOIN 
        Uyeler U ON OI.TC_Kimlik_No = U.TC_Kimlik_No
    INNER JOIN 
        Kitaplar K ON OI.ISBN_No = K.ISBN_No
    WHERE 
        OI.Durum = 'Ödünçte' AND 
        (OI.TC_Kimlik_No LIKE '%' + @arama + '%'  
         OR U.Ad LIKE '%' + @arama + '%'         -- Ad sütununda ara
         OR U.Soyad LIKE '%' + @arama + '%'       -- Soyad sütununda ara
         OR K.Kitap_Adi LIKE '%' + @arama + '%')";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@arama", arananDeger);

                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvOduncListesi.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödünç listesi aranırken hata oluştu: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SatirlariRenklendir();
        }
        public void OduncListesiniDoldur()
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT * FROM OduncIslemleri ";

            try
            {
                using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                {
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    dgvOduncListesi.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenirken hata oluştu: " + ex.Message, "Veritabanı Hatası");
            }
            SatirlariRenklendir();
        }

        
        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtTckNo.Clear();
            txtAdSoyad.Clear();
            txtCinsiyet.Clear();

            txtIsbn.Clear();
            txtKitapAdi.Clear();
            txtKitapYazari.Clear();

            txtVerilmeTarihi.Clear();
            txtAlinacakTarih.Clear();
            txtTeslimDurumu.Clear();

            if (Controls.Find("txtAramaTCKN", true).Length > 0)
            {
                ((TextBox)Controls.Find("txtAramaTCKN", true)[0]).Clear();
            }
            if (Controls.Find("txtAramaISBN", true).Length > 0)
            {
                ((TextBox)Controls.Find("txtAramaISBN", true)[0]).Clear();
            }
            if (Controls.Find("txtAramaKitapAdi", true).Length > 0)
            {
                ((TextBox)Controls.Find("txtAramaKitapAdi", true)[0]).Clear();
            }

            OduncListesiniDoldur();
            OduncIstatistikleriniGoster();
        }
        private void UyeDetaylariniGetirVeDoldur(string tckn)
        {
            if (tckn.Length != 11)
            {
                txtAdSoyad.Text = "TCKN eksik.";
                txtCinsiyet.Text = "";
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT Ad, Soyad, Cinsiyet FROM Uyeler WHERE TC_Kimlik_No = @tckn";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@tckn", tckn);
                try
                {
                    baglanti.Open();
                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string adSoyad = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                            txtAdSoyad.Text = adSoyad;
                            txtCinsiyet.Text = reader["Cinsiyet"].ToString();
                        }
                        else
                        {
                            txtAdSoyad.Text = "Üye Bulunamadı.";
                            txtCinsiyet.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Üye Detay Çekme Hatası: {ex.Message}", "Veritabanı Hatası");
                }
            }
        }
        private void KitapDetaylariniGetirVeDoldur(string isbn)
        {
            if (string.IsNullOrEmpty(isbn))
            {
                txtKitapAdi.Text = "ISBN eksik.";
                txtKitapYazari.Text = "";
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT Kitap_Adi, Yazarlar FROM Kitaplar WHERE ISBN_No = @isbn";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
            {
                komut.Parameters.AddWithValue("@isbn", isbn);
                try
                {
                    baglanti.Open();
                    using (SqlDataReader reader = komut.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtKitapAdi.Text = reader["Kitap_Adi"].ToString();
                            txtKitapYazari.Text = reader["Yazarlar"].ToString();
                        }
                        else
                        {
                            txtKitapAdi.Text = "Kitap Bulunamadı.";
                            txtKitapYazari.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kitap Detay Çekme Hatası: {ex.Message}", "Veritabanı Hatası");
                }
            }
        }

        private void btnExceleAktar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dgvOduncListesi;

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak ödünç kaydı bulunmamaktadır.", "Uyarı");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "OduncListesi_" + DateTime.Now.ToString("yyyyMMdd");
            saveFileDialog.Title = "Ödünç Listesini Excel'e Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                try
                {
                    for (int i = 1; i < dgv.Columns.Count + 1; i++)
                    {
                        excelApp.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            if (dgv.Rows[i].Cells[j].Value != null)
                            {
                                excelApp.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                    excelApp.ActiveWorkbook.Saved = true;
                    excelApp.Visible = true;

                    MessageBox.Show("Ödünç Listesi Excel'e başarıyla aktarıldı.", "Başarılı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel'e aktarımda hata oluştu. Detay: {ex.Message}", "Hata");
                }
                finally
                {
                    excelApp.Quit();
                }
            }
        }
    }
}
