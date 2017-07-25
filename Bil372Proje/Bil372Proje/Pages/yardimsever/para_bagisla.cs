using Npgsql;
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

namespace Bil372Proje.Pages.yardimsever
{
    public partial class para_bagisla : Form
    {
        int okul_id;
        public string kullanici_adi;
        public para_bagisla(int Id, string kAdi)
        {
            kullanici_adi = kAdi;
            okul_id = Id;
            //Yardimsever2 den sonra bu sayfaya gelinir seçilen okulun ihtiyaçlarını listeler
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");


        private void Geri_Click(object sender, EventArgs e)
        {
            OkulIhtiyac oi = new OkulIhtiyac(okul_id,kullanici_adi);
            this.Hide();
            oi.Show();
        }
        private bool kayitGuncelle()
        {
            conn.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand("SELECT bakiye from yardimsever where kAdi=@kullanici_adi", conn);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            int bakiye = Convert.ToInt32(komut.ExecuteScalar());
            if (miktar.Text == "")
            {
                MessageBox.Show("Miktarı boş bırakamazsınız!");
                con.Close();
                return false;
            }
            int mik = Convert.ToInt32(miktar.Text);
            if ((bakiye == 0 || bakiye < mik))
            {
                MessageBox.Show("Bakiyeniz Yetersiz");
                con.Close();
                return false;
            }
            NpgsqlCommand yardimsever = new NpgsqlCommand("update yardimsever set bakiye=bakiye - @ybakiye where kAdi=@kullanici_adi ", conn);
            NpgsqlCommand okul = new NpgsqlCommand("update okul set bakiye=bakiye + @obakiye where id=@okul_id", conn);
            yardimsever.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            yardimsever.Parameters.AddWithValue("@ybakiye", miktar.Text);
            okul.Parameters.AddWithValue("@obakiye", miktar.Text);
            okul.Parameters.AddWithValue("@okul_id", okul_id);
            yardimsever.ExecuteNonQuery();
            okul.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
            return true;

        }

        private void bagisla_Click(object sender, EventArgs e)
        {
         
            kayitGuncelle();

        }

        private int bakiyeGetir()
        {
            conn.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand("SELECT bakiye from yardimsever where kAdi=@kullanici_adi", conn);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            int bakiye = Convert.ToInt32(komut.ExecuteScalar());
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
            return bakiye;
        }

        private void para_bagisla_Load(object sender, EventArgs e)
        {
            button1.Text = bakiyeGetir() + " TL";
        }
    }
}
