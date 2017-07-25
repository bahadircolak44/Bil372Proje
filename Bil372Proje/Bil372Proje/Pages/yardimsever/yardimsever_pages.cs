using Bil372Proje.Pages.yardimsever;
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

namespace Bil372Proje.Pages
{
    public partial class yardimsever1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public string kullanici_adi;
        public yardimsever1(string kAdi)
        {
            kullanici_adi = kAdi;
            // Okul Arama Sayfasıdır.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yardimsever2 y2 = new yardimsever2(kullanici_adi);
            this.Hide();
            y2.Show();

        }

        private void yardimsever1_Load(object sender, EventArgs e)
        {
            bakiye_btn.Text = kayitGetir().ToString();
        }
        private int kayitGetir()
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

        private void button3_Click(object sender, EventArgs e)
        {
            para_yukle yukle = new para_yukle(kullanici_adi);
            this.Hide();
            yukle.Show();
        }

        private void bakiye_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
