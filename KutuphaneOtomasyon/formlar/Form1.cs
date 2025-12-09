using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace KutuphaneOtomasyon
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private const string BaglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

        private void ComboBoxlariDoldur()
        {
            cmbYazar.Items.Clear();
            cmbYayinEvi.Items.Clear();

            string sorguYazar = "SELECT DISTINCT Yazarlar FROM Kitaplar WHERE Yazarlar IS NOT NULL AND Yazarlar <> '' ORDER BY Yazarlar ASC";
            string sorguYayin = "SELECT DISTINCT Yayin_Evi FROM Kitaplar WHERE Yayin_Evi IS NOT NULL AND Yayin_Evi <> '' ORDER BY Yayin_Evi ASC";

            using (SqlConnection baglanti = new SqlConnection(BaglantiStr))
            {
                try
                {
                    baglanti.Open();

                    SqlCommand komutYazar = new SqlCommand(sorguYazar, baglanti);
                    SqlDataReader okuyucuYazar = komutYazar.ExecuteReader();
                    while (okuyucuYazar.Read())
                    {
                        cmbYazar.Items.Add(okuyucuYazar["Yazarlar"].ToString());
                    }
                    okuyucuYazar.Close();

                    SqlCommand komutYayin = new SqlCommand(sorguYayin, baglanti);
                    SqlDataReader okuyucuYayin = komutYayin.ExecuteReader();
                    while (okuyucuYayin.Read())
                    {
                        cmbYayinEvi.Items.Add(okuyucuYayin["Yayin_Evi"].ToString());
                    }
                    okuyucuYayin.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeler doldurulurken hata oluştu: " + ex.Message);
                }
            }
        }
        private void eklebtn_Click(object sender, EventArgs e)
        {
            
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT ISBN_No, Kitap_Adi, Yazarlar, Yayin_Evi, Sayfa_Sayisi,  Kitap_Turu, Stok, Temin_Turu, Temin_Tarihi, Eklenme_Tarihi, Bagislayan FROM Kitaplar";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvKitapListesi.DataSource = dt;

                    MessageBox.Show("Kitap Verileri Başarıyla Yüklendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: Kitaplar tablosu çekilemedi! Bağlantı dizesini ve tablo adını kontrol edin. \nDetay: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
        }



        private void dgvKitapListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            try
            {
                DataGridViewRow secilenSatir = dgvKitapListesi.Rows[e.RowIndex];
                txtISBN.Text = secilenSatir.Cells["ISBN_No"].Value.ToString();
                txtKitapAd.Text = secilenSatir.Cells["Kitap_Adi"].Value.ToString();
                cmbYazar.Text = secilenSatir.Cells["Yazarlar"].Value.ToString();
                cmbYayinEvi.Text = secilenSatir.Cells["Yayin_Evi"].Value.ToString();
                txtSayfaSayisi.Text = secilenSatir.Cells["Sayfa_Sayisi"].Value.ToString();
                txtKitapTuru.Text = secilenSatir.Cells["Kitap_Turu"].Value.ToString();
                txtBagislayan.Text = secilenSatir.Cells["Bagislayan"].Value.ToString();
                txtStok.Text = secilenSatir.Cells["Stok"].Value.ToString();
                txtTeminTuru.Text = secilenSatir.Cells["Temin_Turu"].Value.ToString();
                txtTeminTarihi.Text = secilenSatir.Cells["Temin_Tarihi"].Value.ToString();
                txtEklenmeTarihi.Text = secilenSatir.Cells["Eklenme_Tarihi"].Value.ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Veri aktarımı sırasında hata: " + ex.Message);
                MessageBox.Show("Aktarım Hatası: Sütun isimlerin veya kontrol tiplerini kontrol edin.");
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (btnKitabiSil.Visible == false)
            {
                btnKitapEkle.Visible = true;
                btnUyeler.Visible = true;
                btnKitabiDuzenle.Visible = true;
                btnKitabiSil.Visible = true;
                button3.Visible = true;

            }
            else
            {
                btnKitapEkle.Visible = false;
                btnUyeler.Visible = false;
                btnKitabiDuzenle.Visible = false;
                btnKitabiSil.Visible = false;
                button3.Visible = false;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyelerForm uyeler = new uyelerForm();
            uyeler.Show();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            cmbAramaTuru.Items.Add("ISBN");
            cmbAramaTuru.Items.Add("Kitap Adı");
            cmbAramaTuru.Items.Add("Yazar");
            cmbAramaTuru.Items.Add("Sayfa Sayısı");
            cmbAramaTuru.Items.Add("Yayın Evi");
            cmbAramaTuru.Items.Add("Kitap Türü");
            cmbAramaTuru.Items.Add("Temin Türü");
            cmbAramaTuru.Items.Add("Temin Tarihi");
            cmbAramaTuru.Items.Add("Bağışlayan");
            cmbAramaTuru.Items.Add("Stok");
            cmbAramaTuru.Items.Add("Eklenme Tarihi");
            cmbAramaTuru.SelectedIndex = 0;

            btnKitapEkle.Visible = false;
            btnUyeler.Visible = false;
            btnKitabiDuzenle.Visible = false;
            btnKitabiSil.Visible = false;
            button3.Visible = false;

            
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT * FROM Kitaplar";
            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvKitapListesi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Kitaplar tablosu çekilemedi! Bağlantı dizesini ve tablo adını kontrol edin. \nDetay: " + ex.Message);
                }
            }
            ComboBoxlariDoldur();
            KitapSayilariniGoster();

        }
        private void KitapSayilariniGoster()
        {
            string sorguToplamStok = "SELECT ISNULL(SUM(Stok), 0) FROM Kitaplar";
            string sorguOduncSayisi = "SELECT COUNT(*) FROM OduncIslemleri";

            using (SqlConnection baglanti = new SqlConnection(BaglantiStr))
            {
                try
                {
                    baglanti.Open();

                    int toplamStok = Convert.ToInt32(new SqlCommand(sorguToplamStok, baglanti).ExecuteScalar());
                    int oduncSayisi = Convert.ToInt32(new SqlCommand(sorguOduncSayisi, baglanti).ExecuteScalar());

                    int kutuphanedekiSayi = toplamStok - oduncSayisi;

                    lblToplamStok.Text = $"Toplam Kitap Sayısı: {toplamStok}";
                    lblOduncte.Text = $"Ödünçteki Kitaplar: {oduncSayisi}";
                    lblMevcut.Text = $"Raftaki Mevcut Kitap: {kutuphanedekiSayi}";
                }
                catch (Exception ex)
                {

                    lblToplamStok.Text = "-";
                    lblOduncte.Text = "-";
                    lblMevcut.Text = "-";
                }
            }
        }

        private void btnKitabiSil_Click(object sender, EventArgs e)
        {
            string silinecekISBN = txtISBN.Text;

            if (string.IsNullOrEmpty(silinecekISBN))
            {
                MessageBox.Show("Lütfen önce listeden silinecek kitabı seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult onay = MessageBox.Show($"{silinecekISBN} " +
                $"ISBN numaralı kitabı kalıcı olarak silmek istediğinizden emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                
                string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
                string sorgu = "DELETE FROM Kitaplar WHERE ISBN_No = @isbn";

                
                using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                {
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@isbn", silinecekISBN);
                        try
                        {
                            baglanti.Open();
                            int etkilenenSatir = komut.ExecuteNonQuery();

                            if (etkilenenSatir > 0)
                            {
                                eklebtn_Click(null, null);
                            }
                            else
                            {
                                MessageBox.Show("Kitap veritabanında bulunamadı veya silinemedi.", "Uyarı");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Silme işlemi başarısız oldu: " + ex.Message, "Hata");
                        }
                    }
                }
            }
        }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            /* uyelerForm uyeler = new uyelerForm();
             uyeler.Show();
             this.Hide();*/
        }
        private string MevcutYazimiKoru(ComboBox cmb)
        {
            string girilenDeger = cmb.Text.Trim();

            foreach (var item in cmb.Items)
            {
                string listedekiDeger = item.ToString();


                if (string.Equals(girilenDeger, listedekiDeger, StringComparison.OrdinalIgnoreCase))
                {
                    return listedekiDeger;
                }
            }

            return girilenDeger;
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            ComboBoxlariDoldur();
            int sayfaSayisi = 0;
            int kopyaSayisi = 0;

            if (string.IsNullOrEmpty(txtISBN.Text) || string.IsNullOrEmpty(txtKitapAd.Text))
            {
                MessageBox.Show("ISBN ve Kitap Adı alanları boş bırakılamaz!", "Uyarı");
                return;
            }

            if (!int.TryParse(txtSayfaSayisi.Text, out sayfaSayisi) || !int.TryParse(txtStok.Text, out kopyaSayisi))
            {
                MessageBox.Show("Sayfa Sayısı ve Stok bilgileri geçerli sayısal değer olmalıdır.", "Hata");
                return;
            }

            DateTime teminTarihiDegeri;
            DateTime eklenmeTarihiDegeri;

            if (!DateTime.TryParse(txtTeminTarihi.Text, out teminTarihiDegeri) ||
                !DateTime.TryParse(txtEklenmeTarihi.Text, out eklenmeTarihiDegeri))
            {
                MessageBox.Show("Tarih formatları (GG.AA.YYYY) doğru olmalıdır.", "Format Hatası");
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "INSERT INTO Kitaplar(ISBN_No, Kitap_Adi, Yazarlar, Yayin_Evi, Sayfa_Sayisi, Kitap_Turu, Bagislayan, Stok, Temin_Turu, Temin_Tarihi, Eklenme_Tarihi) " +
                         "VALUES (@isbn, @ad, @yazar, @yayin, @sayfa, @tur, @bagislayan, @stok, @teminturu, @temintarihi, @eklenme)";


            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        
                        komut.Parameters.AddWithValue("@isbn", txtISBN.Text);
                        komut.Parameters.AddWithValue("@ad", txtKitapAd.Text);
                        komut.Parameters.AddWithValue("@yazar", MevcutYazimiKoru(cmbYazar));
                        komut.Parameters.AddWithValue("@yayin", MevcutYazimiKoru(cmbYayinEvi));

                        komut.Parameters.AddWithValue("@sayfa", sayfaSayisi);
                        komut.Parameters.AddWithValue("@stok", kopyaSayisi);

                        komut.Parameters.AddWithValue("@tur", txtKitapTuru.Text);
                        komut.Parameters.AddWithValue("@bagislayan", txtBagislayan.Text);
                        komut.Parameters.AddWithValue("@teminturu", txtTeminTuru.Text);

                        komut.Parameters.AddWithValue("@temintarihi", teminTarihiDegeri.Date);
                        komut.Parameters.AddWithValue("@eklenme", eklenmeTarihiDegeri.Date);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            eklebtn_Click(null, null);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Veritabanı Hatası: Kayıt Eklenemedi. (ISBN tekrarı, veri tipi veya NULL hatası olabilir){ex.Message}", "Hata");
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvKitapListesi.DataSource = dt;
                    //MessageBox.Show("Kitap Verileri Başarıyla Yüklendi!");
                }
                catch (Exception ex)
                {
                   
                }
            }
        }

        private string GetDbSutunAdi(string aramaMetni)
        {
            switch (aramaMetni)
            {
                case "ISBN": return "ISBN_No";
                case "Kitap Adı": return "Kitap_Adi";
                case "Yazar": return "Yazarlar";
                case "Yayın Evi": return "Yayin_Evi";
                case "Kitap Türü": return "Kitap_Turu";
                default: return "";
            }
        }

        private void btnKitabiDuzenle_Click(object sender, EventArgs e)
        {
            string guncellenecekISBN = txtISBN.Text;
            if (string.IsNullOrEmpty(guncellenecekISBN))
            {
                MessageBox.Show("Lütfen önce listeden düzenlenecek bir kitap seçin.", "Uyarı");
                return;
            }
            
            if(!int.TryParse(txtSayfaSayisi.Text, out int sayfaSayisi) || !int.TryParse(txtStok.Text, out int stokAdedi))
            {
                MessageBox.Show("Sayfa sayısı ve stok bilgileri geçerli sayısal değer olmalıdır.", "Hata");
                return;
            }
            int mevcutSayi = stokAdedi;

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "UPDATE Kitaplar SET Kitap_Adi = @ad, Yazarlar = @yazar, " +
                "Yayin_Evi = @yayin, Sayfa_Sayisi = @sayfa, Kitap_Turu = @tur, " +
                "Bagislayan = @bagislayan, Stok = @stok, Temin_Turu = @teminturu, " +
                "Temin_Tarihi = @temintarihi, Eklenme_Tarihi = @eklenme WHERE ISBN_No = @isbnGuncelle";
            
            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        komut.Parameters.AddWithValue("@isbnGuncelle", guncellenecekISBN);

                        komut.Parameters.AddWithValue("@ad", txtKitapAd.Text);
                        komut.Parameters.AddWithValue("@yazar", MevcutYazimiKoru(cmbYazar));
                        komut.Parameters.AddWithValue("@yayin", MevcutYazimiKoru(cmbYayinEvi));
                        komut.Parameters.AddWithValue("@sayfa", sayfaSayisi);
                        komut.Parameters.AddWithValue("@tur", txtKitapTuru.Text);
                        komut.Parameters.AddWithValue("@bagislayan", txtBagislayan.Text);
                        komut.Parameters.AddWithValue("@stok", stokAdedi);
                        komut.Parameters.AddWithValue("@teminturu", txtTeminTuru.Text);

                        DateTime teminTarihiDegeri;
                        if (DateTime.TryParse(txtTeminTarihi.Text, out teminTarihiDegeri))
                        {
                            komut.Parameters.AddWithValue("@temintarihi", teminTarihiDegeri.Date);
                        }
                        else
                        {
                            MessageBox.Show("Temin Tarihi, lütfen doğru tarih formatında (GG.AA.YYYY) giriniz.", "Tarih Formatı Hatası");
                            return;
                        }

                        DateTime eklenmeTarihiDegeri;
                        if (DateTime.TryParse(txtEklenmeTarihi.Text, out eklenmeTarihiDegeri))
                        {
                            komut.Parameters.AddWithValue("@eklenme", eklenmeTarihiDegeri.Date);
                        }
                        else
                        {
                            MessageBox.Show("Eklenme Tarihi, lütfen doğru tarih formatında (GG.AA.YYYY) giriniz.", "Tarih Formatı Hatası");
                            return;
                        }

  
                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if(sonuc > 0)
                        {
                            eklebtn_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Kitap bulunamadı veya hçbir değişiklik yapılamadı.", "Uyarı");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Güncelleme hatası: Veri formatlarını kontrol edin. \nDetay: {ex.Message}", "Hata");
                    }
                }
            }
            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Kitap bilgileri başarıyla güncellendi.", "Başarılı");
                            eklebtn_Click(null, null);
                        }
                    }
                    catch
                    {

                    }


        }
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aramaSutunu = cmbAramaTuru.SelectedItem.ToString();
            string aramaDegeri = txtAranacakDeger.Text.Trim();

            if (string.IsNullOrEmpty(aramaDegeri))
            {
                MessageBox.Show("Lütfen aranacak değeri girin.", "Uyarı");
                return;
            }

            string dbSutunAdi = GetDbSutunAdi(aramaSutunu);
            string sorgu = $"SELECT * FROM Kitaplar WHERE [{dbSutunAdi}] LIKE @deger";
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@deger", "%" + aramaDegeri + "%");

                    try
                    {
                        baglanti.Open();
                        SqlDataAdapter da = new SqlDataAdapter(komut);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count == 1)
                        {
                            DataRow row = dt.Rows[0];
                            txtISBN.Text = row["ISBN_No"].ToString();
                            txtKitapAd.Text = row["Kitap_Adi"].ToString();
                           
                            txtISBN.Text = row["ISBN_No"].ToString();
                            txtKitapAd.Text = row["Kitap_Adi"].ToString();

                            cmbYazar.Text = row["Yazarlar"].ToString();
                            cmbYayinEvi.Text = row["Yayin_Evi"].ToString();
                            txtSayfaSayisi.Text = row["Sayfa_Sayisi"].ToString();
                            txtKitapTuru.Text = row["Kitap_Turu"].ToString();
                            txtBagislayan.Text = row["Bagislayan"].ToString();
                            txtStok.Text = row["Stok"].ToString();
                            txtTeminTuru.Text = row["Temin_Turu"].ToString();
                            txtTeminTarihi.Text = row["Temin_Tarihi"].ToString();
                            txtEklenmeTarihi.Text = row["Eklenme_Tarihi"].ToString();
                        }
                        else
                        {
                            dgvKitapListesi.DataSource = dt;
                            if (dt.Rows.Count == 0) MessageBox.Show("Kitap bulunamadı.", "Sonuç Yok");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Arama Hatası: {ex.Message}", "Hata");
                    }
                }
            }
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            odunc oduncFormu = new odunc();
            oduncFormu.Show();
            this.Hide();
        
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {



            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT * FROM Kitaplar";
            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvKitapListesi.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: Kitaplar tablosu çekilemedi! Bağlantı dizesini ve tablo adını kontrol edin. \nDetay: " + ex.Message);
                }
            }

            txtISBN.Clear();
            txtKitapAd.Clear();
            cmbYazar.Text = "";
            txtSayfaSayisi.Clear();
            cmbYayinEvi.Text = "";
            txtKitapTuru.Clear(); 
            txtTeminTuru.Clear();
            txtTeminTarihi.Clear();
            txtBagislayan.Clear();
            txtStok.Clear();
            txtEklenmeTarihi.Clear();

        }

        private void txtAranacakDeger_KeyDown(object sender, KeyEventArgs e)
        {
    if (e.KeyCode == Keys.Enter)
    {
        e.SuppressKeyPress = true; 
        

        btnAra_Click(sender, e);
    }
        }

        private void btnExcelAktar_Click(object sender, EventArgs e)
        {
            if (dgvKitapListesi.Rows.Count == 0)
            {
                MessageBox.Show("Aktarılacak veri bulunmamaktadır.", "Uyarı");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Dosyası (*.xlsx)|*.xlsx";
            saveFileDialog.Title = "Kitap Listesini Excel'e Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                try
                {
                    for (int i = 1; i < dgvKitapListesi.Columns.Count + 1; i++)
                    {
                        excelApp.Cells[1, i] = dgvKitapListesi.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgvKitapListesi.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvKitapListesi.Columns.Count; j++)
                        {
                            if (dgvKitapListesi.Rows[i].Cells[j].Value != null)
                            {
                                excelApp.Cells[i + 2, j + 1] = dgvKitapListesi.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    excelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName.ToString());
                    excelApp.ActiveWorkbook.Saved = true;
                    excelApp.Visible = true; 

                    MessageBox.Show("Veriler Excel'e başarıyla aktarıldı.", "Başarılı");
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
