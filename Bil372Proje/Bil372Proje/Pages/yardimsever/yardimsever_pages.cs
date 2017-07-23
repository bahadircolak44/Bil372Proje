using Bil372Proje.Pages.yardimsever;
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
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
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
            con.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand("SELECT bakiye from yardimsever where kAdi=@kullanici_adi", con);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            int bakiye = Convert.ToInt32(komut.ExecuteScalar());
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
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
