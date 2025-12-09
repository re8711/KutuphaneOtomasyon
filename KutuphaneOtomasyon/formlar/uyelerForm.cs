using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class uyelerForm : Form
    {

        public void DogumGunuEpostaGonder()
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT Ad, Eposta_Adresi FROM Uyeler WHERE MONTH(Dogum_Tarihi) = MONTH(GETDATE()) AND DAY(Dogum_Tarihi) = DAY(GETDATE())";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    SqlDataReader reader = komut.ExecuteReader();

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("rslseleci1@gmail.com", "tsai zcdo bgyi rpay");
                        smtp.EnableSsl = true;

                        while (reader.Read())
                        {
                            string aliciAd = reader["Ad"].ToString();
                            string aliciEposta = reader["Eposta_Adresi"].ToString();

                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("rslseleci1@gmail.com", "Kütüphane Otomasyonu");
                            mail.To.Add(aliciEposta);
                            mail.Subject = "🎂 Doğum Gününüz Kutlu Olsun!";
                            mail.Body = $"Sayın {aliciAd},\n\nKütüphane ailesi olarak doğum gününüzü en içten dileklerimizle kutlarız!";

                            smtp.Send(mail);
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                  
                }
            }
        }

        public uyelerForm()
        {
            InitializeComponent();
        }

        private void uyelerForm_Load(object sender, EventArgs e)
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT * FROM UYELER";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUyeler.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("HATA: Üye listesi yüklenemedi Bağlantı dizesini kontrol edin . \nDetay: " + ex.Message + " veritabanı hatası ");
                }
            }
            DogumGunuEpostaGonder();
        }

        private void cmbAramaTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void UyeSayilariniGoster()
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorguToplamUye = "SELECT COUNT(TC_Kimlik_No) FROM Uyeler";
            string sorguBlokeli = "SELECT COUNT(TC_Kimlik_No) FROM Uyeler WHERE Blokeli_Durum = 1";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    int toplamUye = Convert.ToInt32(new SqlCommand(sorguToplamUye, baglanti).ExecuteScalar());
                    int blokeliUye = Convert.ToInt32(new SqlCommand(sorguBlokeli, baglanti).ExecuteScalar());

                    int aktifUye = toplamUye - blokeliUye;

                    MessageBox.Show($"👥 Toplam Kayıtlı Üye Sayısı: {toplamUye}\n" +
                                    $"✅ Aktif (Blokeli Olmayan) Üye: {aktifUye}\n" +
                                    $"❌ Blokeli Üye Sayısı: {blokeliUye}",
                                    "Üye Envanter Sayımı");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Sayımlar çekilemedi. Detay: {ex.Message}", "Veritabanı Hatası");
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUyeler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0 || e.RowIndex == dgvUyeler.NewRowIndex)
            {
                return;
            }
            try
            {
                DataGridViewRow secilenSatir = dgvUyeler.Rows[e.RowIndex];
                txtTckNo.Text = secilenSatir.Cells["TC_Kimlik_No"].Value.ToString();
                txtKisiAd.Text = secilenSatir.Cells["Ad"].Value.ToString();
                txtKisiSoyad.Text = secilenSatir.Cells["Soyad"].Value.ToString();
                txtKisiDogumTarihi.Text = secilenSatir.Cells["Dogum_Tarihi"].Value.ToString();
                txtKisiCinsiyet.Text = secilenSatir.Cells["Cinsiyet"].Value.ToString();
                txtKisiEposta.Text = secilenSatir.Cells["Eposta_Adresi"].Value.ToString();
                rctxtKisiAdres.Text = secilenSatir.Cells["Adres"].Value.ToString();

                if (secilenSatir.Cells["Eklenme_Tarihi"].Value is DateTime eklenmeTarihi)
                {
                    txtKisiEklenmeTarihi.Text = eklenmeTarihi.ToString("dd.MM.yyyy");
                }
                else
                {
                    txtKisiEklenmeTarihi.Text = secilenSatir.Cells["Eklenme_Tarihi"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri aktarımı hatası: Sütun /Kontrol adlarını kontrol edin. Detay: {ex.Message}", "Aktarım Hatası");
            }
        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            string aramaSutunu = cmbAramaTuru.SelectedItem.ToString();
            string aramaDegeri = txtAranacakDeger.Text.Trim();

            if (string.IsNullOrEmpty(aramaDegeri))
            {
                MessageBox.Show("Lütfen aranacak değeri girin.", "Uyarı");
                return;
            }

            string dbSutunAdi = GetUyeDbSutunAdi(aramaSutunu);

            if (string.IsNullOrEmpty(dbSutunAdi))
            {
                MessageBox.Show("Seçilen arama türü için geçerli bir sütun bulunamadı. Lütfen ComboBox içeriğini ve GetUyeDbSutunAdi metodunu kontrol edin.", "Hata");
                return;
            }

            string sorgu = $"SELECT * FROM Uyeler WHERE [{dbSutunAdi}] LIKE @deger";
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

                        dgvUyeler.DataSource = dt;
                        if (dt.Rows.Count == 1)
                        {
                            DataRow row = dt.Rows[0];

                            txtTckNo.Text = row["TC_Kimlik_No"].ToString();
                            txtKisiAd.Text = row["Ad"].ToString();
                            txtKisiSoyad.Text = row["Soyad"].ToString();
                            txtKisiDogumTarihi.Text = row["Dogum_Tarihi"].ToString();
                            txtKisiCinsiyet.Text = row["Cinsiyet"].ToString();
                            txtKisiTelNo.Text = row["Cep_Telefonu"].ToString();
                            txtKisiEposta.Text = row["Eposta_Adresi"].ToString();

                        }
                        else if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show($"'{aramaDegeri}' için uygun üye bulunamadı.", "Sonuç Yok");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Arama Hatası: {ex.Message}", "Hata");
                    }
                }
            }
        }
        private string GetUyeDbSutunAdi(string aramaMetni)
        {
            switch (aramaMetni)
            {
                case "TC NO": return "TC_Kimlik_No";
                case "Ad": return "Ad";
                case "Soyad": return "Soyad";
                case "Doğum Tarihi": return "Dogum_Tarihi";
                case "Cinsiyet": return "Cinsiyet";
                case "Telefon Numarası": return "Cep_Telefonu";
                case "E-Posta": return "Eposta_Adresi";
                case "Adres": return "Adres";
                default: return "Ad";
            }
        }

        private void btnKitapListesi_Click(object sender, EventArgs e)
        {
            Form1 uyeler = new Form1();
            uyeler.Show();
            this.Hide();
        }

        private void btnYeniKisiEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTckNo.Text) || string.IsNullOrEmpty(txtKisiAd.Text) || string.IsNullOrEmpty(txtKisiSoyad.Text))
            {
                MessageBox.Show("TC Kimlik No, Ad ve Soyad alanları boş bırakılamaz.", "Uyarı");
                return;
            }

            DateTime dogumTarihi;

            if (!DateTime.TryParse(txtKisiDogumTarihi.Text, out dogumTarihi))
            {
                MessageBox.Show("Doğum Tarihi geçerli bir formatta (GG.AA.YYYY) girilmelidir.", "Format Hatası");
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "INSERT INTO Uyeler (TC_Kimlik_No, Ad, Soyad, Dogum_Tarihi, Cinsiyet, Cep_Telefonu, Eposta_Adresi, Adres, Eklenme_Tarihi) " +
                           "VALUES (@tckn, @ad, @soyad, @dtarih, @cinsiyet, @telefon, @eposta, @adres, @eklenme)";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        komut.Parameters.AddWithValue("@tckn", txtTckNo.Text);
                        komut.Parameters.AddWithValue("@ad", txtKisiAd.Text);
                        komut.Parameters.AddWithValue("@soyad", txtKisiSoyad.Text);

                        komut.Parameters.AddWithValue("@dtarih", dogumTarihi.Date);
                        komut.Parameters.AddWithValue("@eklenme", DateTime.Now.Date);

                        komut.Parameters.AddWithValue("@cinsiyet", txtKisiCinsiyet.Text);
                        komut.Parameters.AddWithValue("@telefon", txtKisiTelNo.Text);
                        komut.Parameters.AddWithValue("@eposta", txtKisiEposta.Text);
                        komut.Parameters.AddWithValue("@adres", rctxtKisiAdres.Text);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            uyelerForm_Load(sender, e);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Veritabanı Hatası: Kayıt Eklenemedi. (TCKN tekrarı veya veri tipi hatası olabilir) Detay: {ex.Message}", "Hata");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Genel Hata: Kayıt Eklenirken bir sorun oluştu! Detay: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            string guncellenecekTCKN = txtTckNo.Text.Trim();

            if (string.IsNullOrEmpty(guncellenecekTCKN))
            {
                MessageBox.Show("Lütfen önce listeden düzenlenecek bir üye seçin (TCKN zorunludur).", "Uyarı");
                return;
            }

            DateTime dogumTarihi;

            if (!DateTime.TryParse(txtKisiDogumTarihi.Text, out dogumTarihi))
            {
                MessageBox.Show("Doğum Tarihi geçerli bir formatta (GG.AA.YYYY) girilmelidir.", "Format Hatası");
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "UPDATE Uyeler SET Ad = @ad, Soyad = @soyad, Dogum_Tarihi = @dtarih, " +
                           "Cinsiyet = @cinsiyet, Cep_Telefonu = @telefon, Eposta_Adresi = @eposta, " +
                           "Adres = @adres " +
                           "WHERE TC_Kimlik_No = @tckn";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        komut.Parameters.AddWithValue("@tckn", guncellenecekTCKN);

                        komut.Parameters.AddWithValue("@ad", txtKisiAd.Text);
                        komut.Parameters.AddWithValue("@soyad", txtKisiSoyad.Text);
                        komut.Parameters.AddWithValue("@dtarih", dogumTarihi.Date);
                        komut.Parameters.AddWithValue("@cinsiyet", txtKisiCinsiyet.Text);
                        komut.Parameters.AddWithValue("@telefon", txtKisiTelNo.Text);
                        komut.Parameters.AddWithValue("@eposta", txtKisiEposta.Text);
                        komut.Parameters.AddWithValue("@adres", rctxtKisiAdres.Text);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            uyelerForm_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Üye bulunamadı veya hiçbir değişiklik yapılmadı.", "Uyarı");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Güncelleme Hatası: Veri formatlarını kontrol edin. Detay: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            string silinecekTCKN = txtTckNo.Text.Trim();

            if (string.IsNullOrEmpty(silinecekTCKN))
            {
                MessageBox.Show("Lütfen önce listeden silinecek bir üye seçin (TCKN zorunludur).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult onay = MessageBox.Show(
                $"{silinecekTCKN} TC Kimlik Numaralı üyeyi kalıcı olarak silmek istediğinizden emin misiniz? Ödünç kayıtları varsa silinemez!",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (onay == DialogResult.Yes)
            {
                string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

                string sorgu = "DELETE FROM Uyeler WHERE TC_Kimlik_No = @tckn";

                using (SqlConnection baglanti = new SqlConnection(baglantiStr))
                {
                    using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                    {
                        komut.Parameters.AddWithValue("@tckn", silinecekTCKN);

                        try
                        {
                            baglanti.Open();
                            int etkilenenSatir = komut.ExecuteNonQuery();

                            if (etkilenenSatir > 0)
                            {
                                uyelerForm_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Silinecek TCKN'ye sahip üye bulunamadı.", "Uyarı");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Veritabanı Hatası: Üye silinemedi. Ödünç kayıtları aktif olabilir.", "Hata");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Genel Hata: {ex.Message}", "Hata");
                        }
                    }
                }
            }
        }

        private void btnOducIslemleri_Click(object sender, EventArgs e)
        {
            odunc oduncFormu = new odunc();
            oduncFormu.Show();
            this.Hide();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            uyelerForm_Load(sender, e);
            txtAranacakDeger.Clear();

            if (cmbAramaTuru.Items.Count > 0)
            {
                cmbAramaTuru.SelectedIndex = 0;
            }

            txtTckNo.Clear();
            txtKisiAd.Clear();
            txtKisiSoyad.Clear();
            txtKisiDogumTarihi.Clear();
            txtKisiCinsiyet.Clear();
            txtKisiTelNo.Clear();
            txtKisiEposta.Clear();
            rctxtKisiAdres.Clear();
            txtKisiEklenmeTarihi.Clear();

        }

        private void txtAranacakDeger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnKisiAra_Click(sender, e);
            }
        }

        private void btnUyeSayim_Click(object sender, EventArgs e)
        {
            UyeSayilariniGoster();
        }

        private void btnBloke_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce listeden bir üye seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tckn = dgvUyeler.CurrentRow.Cells["TC_Kimlik_No"].Value.ToString();

            string mevcutDurumSql = "SELECT Blokeli_Durum FROM Uyeler WHERE TC_Kimlik_No = @tckn";
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komutOku = new SqlCommand(mevcutDurumSql, baglanti);
                    komutOku.Parameters.AddWithValue("@tckn", tckn);

                    object sonuc = komutOku.ExecuteScalar();
                    if (sonuc == null) throw new Exception("Üye bulunamadı.");

                    bool suankiBloke = Convert.ToBoolean(sonuc);
                    int yeniBlokeDegeri = suankiBloke ? 0 : 1;
                    string islemAdi = suankiBloke ? "AKTİF EDİLDİ" : "BLOKELENDİ";

                    string updateSorgu = "UPDATE Uyeler SET Blokeli_Durum = @yeniDeger WHERE TC_Kimlik_No = @tckn";

                    using (SqlCommand komutGuncelle = new SqlCommand(updateSorgu, baglanti))
                    {
                        komutGuncelle.Parameters.AddWithValue("@yeniDeger", yeniBlokeDegeri);
                        komutGuncelle.Parameters.AddWithValue("@tckn", tckn);

                        komutGuncelle.ExecuteNonQuery();

                        uyelerForm_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bloklama/Aktif Etme Hatası: {ex.Message}", "Hata");
                }
            }
        }
    }
}
