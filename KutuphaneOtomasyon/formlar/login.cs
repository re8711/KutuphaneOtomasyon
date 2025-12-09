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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilenKimlik = txtEposta.Text.Trim();
            string sifre = txtSifre.Text;

            if (string.IsNullOrEmpty(girilenKimlik) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen E-posta/Kullanıcı Adı ve Şifrenizi girin.", "Uyarı");
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = @"
        SELECT COUNT(*) 
        FROM KutuphaneGiris 
        WHERE (E_Posta = @kimlik OR Kullanici_Adi = @kimlik) 
        AND Sifre = @sifre";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kimlik", girilenKimlik);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    try
                    {
                        baglanti.Open();
                        int kullaniciSayisi = (int)komut.ExecuteScalar();

                        if (kullaniciSayisi > 0)
                        {
                           // MessageBox.Show("Giriş Başarılı!", "Hoş Geldiniz");
                            Form1 anaForm = new Form1();
                            anaForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı E-Posta/Kullanıcı Adı veya Şifre. Lütfen tekrar deneyin.", "Giriş Başarısız");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veritabanı Hatası: Bağlantı kurulamadı. Detay: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitFormu = new KayitOl();
            kayitFormu.Show();
            this.Hide(); 
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
