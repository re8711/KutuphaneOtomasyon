using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KutuphaneOtomasyon
{
    public partial class OduncVer : Form
    {
        public OduncVer()
        {
            InitializeComponent();
        }

        private void OduncVer_Load(object sender, EventArgs e)
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                try
                {
                    baglanti.Open();

                    string sorguTCKN = "SELECT TC_Kimlik_No FROM Uyeler ORDER BY TC_Kimlik_No";
                    using (SqlCommand komutTCKN = new SqlCommand(sorguTCKN, baglanti))
                    {
                        SqlDataReader readerTCKN = komutTCKN.ExecuteReader();
                        cmbTcknoAra.Items.Clear();
                        while (readerTCKN.Read())
                        {
                            cmbTcknoAra.Items.Add(readerTCKN["TC_Kimlik_No"].ToString());
                        }
                        readerTCKN.Close();
                    }

                    string sorguISBN = "SELECT ISBN_No FROM Kitaplar ORDER BY ISBN_No";
                    using (SqlCommand komutISBN = new SqlCommand(sorguISBN, baglanti))
                    {
                        SqlDataReader readerISBN = komutISBN.ExecuteReader();
                        cmbIsbnAra.Items.Clear();
                        while (readerISBN.Read())
                        {
                            cmbIsbnAra.Items.Add(readerISBN["ISBN_No"].ToString());
                        }
                        readerISBN.Close();
                    }

                    cmbTcknoAra.SelectedIndex = -1;
                    cmbIsbnAra.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ComboBox verileri yüklenirken hata oluştu: " + ex.Message, "Hata");
                }
            }
        }

        

        private void btnGirdileriTemizle_Click(object sender, EventArgs e)
        {
            txtKitapAdi.Clear();
            txtKitapYazari.Clear();
            txtAdSoyad.Clear();

            cmbCinsiyet.SelectedIndex = -1;

            dtpVerilmeTarihi.Value = DateTime.Now.Date;
            dtpAlinacakTarih.Value = DateTime.Now.Date.AddDays(14);

            MessageBox.Show("Giriş alanları temizlendi.", "Temizlik");
        }

        private void cmbTcknoAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKriteri = cmbTcknoAra.Text.Trim();

            if (aramaKriteri.Length < 3)
            {
                cmbTcknoAra.DroppedDown = false;
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT TC_Kimlik_No FROM Uyeler WHERE TC_Kimlik_No LIKE @arama + '%'";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@arama", aramaKriteri);
                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = komut.ExecuteReader();

                        cmbTcknoAra.Items.Clear();
                        while (reader.Read())
                        {
                            cmbTcknoAra.Items.Add(reader["TC_Kimlik_No"].ToString());
                        }
                        reader.Close();

                        if (cmbTcknoAra.Items.Count > 0)
                        {
                            cmbTcknoAra.DroppedDown = true;
                            cmbTcknoAra.SelectionStart = aramaKriteri.Length;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void cmbTcknoAra_Leave(object sender, EventArgs e)
        {
            string tckn = cmbTcknoAra.Text.Trim();

            if (tckn.Length != 11)
            {
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";
            string sorgu = "SELECT Ad, Soyad, Cinsiyet FROM Uyeler WHERE TC_Kimlik_No = @tckn";

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
                            txtAdSoyad.Text = reader["Ad"].ToString() + " " + reader["Soyad"].ToString();
                            cmbCinsiyet.Text = reader["Cinsiyet"].ToString();
                        }
                        else
                        {
                            txtAdSoyad.Text = "Üye Bulunamadı.";
                            cmbCinsiyet.Text = "";
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void cmbIsbnAra_TextChanged(object sender, EventArgs e)
        {
            string aramaKriteri = cmbIsbnAra.Text.Trim();

            if (aramaKriteri.Length < 5)
            {
                cmbIsbnAra.DroppedDown = false;
                return;
            }

            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string sorgu = "SELECT ISBN_No FROM Kitaplar WHERE ISBN_No LIKE @arama + '%'";

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@arama", aramaKriteri);
                    try
                    {
                        baglanti.Open();
                        SqlDataReader reader = komut.ExecuteReader();

                        cmbIsbnAra.Items.Clear();
                        while (reader.Read())
                        {
                            cmbIsbnAra.Items.Add(reader["ISBN_No"].ToString());
                        }
                        reader.Close();

                        if (cmbIsbnAra.Items.Count > 0)
                        {
                            cmbIsbnAra.DroppedDown = true;
                            cmbIsbnAra.SelectionStart = aramaKriteri.Length;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"ISBN Arama Listesi Hatası: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void cmbIsbnAra_Leave(object sender, EventArgs e)
        {
            string isbn = cmbIsbnAra.Text.Trim();

            if (isbn.Length < 10)
            {
                txtKitapAdi.Text = "";
                txtKitapYazari.Text = "";
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
                            txtKitapYazari.Text = "";
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kitap Detay Aktarımı Hatası: {ex.Message}", "Hata");
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string baglantiStr = "Data Source=kutuphane1.mssql.somee.com;Initial Catalog=Kutuphane1;User ID=resull871_SQLLogin_1;Password=22kuotkxfi;";

            string tckn = cmbTcknoAra.Text.Trim();
            string isbn = cmbIsbnAra.Text.Trim();
            DateTime verilmeTarihi = dtpVerilmeTarihi.Value.Date;
            DateTime teslimTarihi = dtpAlinacakTarih.Value.Date;

            if (string.IsNullOrEmpty(tckn) || string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("TC Kimlik No ve ISBN alanları boş bırakılamaz.", "Eksik Bilgi");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(baglantiStr))
            {
                SqlTransaction transaction = null;

                try
                {
                    baglanti.Open();
                    transaction = baglanti.BeginTransaction();

                    string limitSorgu = "SELECT COUNT(*) FROM OduncIslemleri WHERE TC_Kimlik_No = @tckn AND Durum = 'Ödünçte'";
                    using (SqlCommand limitKomut = new SqlCommand(limitSorgu, baglanti, transaction))
                    {
                        limitKomut.Parameters.AddWithValue("@tckn", tckn);
                        int odunctekiKitapSayisi = Convert.ToInt32(limitKomut.ExecuteScalar());

                        if (odunctekiKitapSayisi >= 5)
                        {
                            throw new Exception("Bu üye zaten maksimum (5) kitaba ulaşmıştır. Yeni ödünç verilemez.");
                        }
                    }

                    string updateStokSorgu = "UPDATE Kitaplar SET Stok = Stok - 1 WHERE ISBN_No = @isbn AND Stok > 0";
                    using (SqlCommand komutUpdateStok = new SqlCommand(updateStokSorgu, baglanti, transaction))
                    {
                        komutUpdateStok.Parameters.AddWithValue("@isbn", isbn);
                        int stokSonucu = komutUpdateStok.ExecuteNonQuery();

                        if (stokSonucu == 0)
                        {
                            throw new Exception("Stok güncelleme başarısız oldu (Kitap ISBN'si geçersiz veya stok kalmamış olabilir).");
                        }
                    }

                    string insertOduncSorgu = "INSERT INTO OduncIslemleri (TC_Kimlik_No, ISBN_No, Verilme_Tarihi, Teslim_Tarihi, Durum, Ceza_Ucreti) VALUES (@tckn, @isbn, @verilmeTarihi, @teslimTarihi, 'Ödünçte', 0)";
                    using (SqlCommand komutInsert = new SqlCommand(insertOduncSorgu, baglanti, transaction))
                    {
                        komutInsert.Parameters.AddWithValue("@tckn", tckn);
                        komutInsert.Parameters.AddWithValue("@isbn", isbn);
                        komutInsert.Parameters.AddWithValue("@verilmeTarihi", verilmeTarihi.Date);
                        komutInsert.Parameters.AddWithValue("@teslimTarihi", teslimTarihi.Date);
                        komutInsert.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Ödünç verme işlemi başarıyla kaydedildi.", "Başarılı");
                    this.Close();

                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    MessageBox.Show($"Ödünç Verme İşlemi Başarısız. İşlemler İptal Edildi. Detay: {ex.Message}", "Veritabanı Hatası");
                }
            }
        }
    }
}
