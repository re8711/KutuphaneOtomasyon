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

namespace KutuphaneOtomasyon.formlar
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            login loginFormu = new login();
            loginFormu.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string eposta = txtEposta.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(eposta) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekmektedir.", "Uyarı");
                return;
            }

            string kullaniciAdi = (ad + soyad).Replace(" ", "").ToLower();

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "INSERT INTO KutuphaneGiris (Kullanici_Adi, Ad, Soyad, E_Posta, Sifre, Kayit_Tarihi) " +
                           "VALUES (@kAdi, @ad, @soyad, @eposta, @sifre, @kayitTarihi)";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    try
                    {
                        komut.Parameters.AddWithValue("@kAdi", kullaniciAdi);
                        komut.Parameters.AddWithValue("@ad", ad);
                        komut.Parameters.AddWithValue("@soyad", soyad);
                        komut.Parameters.AddWithValue("@eposta", eposta);
                        komut.Parameters.AddWithValue("@sifre", sifre);
                        komut.Parameters.AddWithValue("@kayitTarihi", dtpKayitTarihi.Value.Date);

                        baglanti.Open();
                        int sonuc = komut.ExecuteNonQuery();

                        if (sonuc > 0)
                        {
                            lblInfo.Text = $"✅ KULLANICI ADINIZ: {kullaniciAdi}. Giriş yaparken bu adı veya e-postanızı kullanın.";
                            lblInfo.ForeColor = System.Drawing.Color.Green;

                           // MessageBox.Show("Kayıt işlemi başarılı! Giriş yapabilirsiniz.", "Başarılı");
                        }
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Bu kullanıcı adı veya e-posta zaten kayıtlı. Lütfen farklı bir isim deneyin.", "Hata");
                        }
                        else
                        {
                            MessageBox.Show($"Veritabanı Hatası: {ex.Message}", "Hata");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Genel Hata: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void TextBox_YaziGirisKontrol(object sender, KeyPressEventArgs e)
        {
            bool isLetter = char.IsLetter(e.KeyChar);
            bool isSpace = e.KeyChar == ' ';
            bool isControl = char.IsControl(e.KeyChar);

            if (!isLetter && !isSpace && !isControl)
            {
                e.Handled = true;

                MessageBox.Show("Bu alana sadece harf ve boşluk girilebilir.", "Hata",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEposta_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool isLetterOrDigit = char.IsLetterOrDigit(e.KeyChar);
            bool isControl = char.IsControl(e.KeyChar); 

            bool isEmailSymbol = (e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_');

            bool isSpace = e.KeyChar == ' ';

            if (!isLetterOrDigit && !isEmailSymbol && !isControl)
            {
                if (isSpace || !isControl)
                {
                    e.Handled = true; 

                    MessageBox.Show("E-Posta adresi geçersiz karakter içeriyor. (@, nokta, alt çizgi, harf ve rakam kullanın.)",
                                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
