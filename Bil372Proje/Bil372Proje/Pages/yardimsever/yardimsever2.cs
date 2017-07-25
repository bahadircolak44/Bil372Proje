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
    public partial class yardimsever2 : Form
    {
        public string kullanici_adi;
        public yardimsever2(string kAdi)
        {
            kullanici_adi = kAdi;
            // Okul Arama Sayfasıdır.
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");


        private void Form1_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT okul.okul_adi,il,ilce,telefon,puan from kullanici inner join okul on okul.kAdi = kullanici.kullanici_adi where yetki = 2 order by puan asc";
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void goto_okulpage(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("select Id from okul where kAdi=@kullanici_adi" , baglanti);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            int Id= Convert.ToInt32(cmd.ExecuteScalar());
            OkulIhtiyac okul = new OkulIhtiyac(Id,kullanici_adi);
            this.Hide();
            okul.Show();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
        }

        private void okul_ara_Click(object sender, EventArgs e)
        {
            if (okul_adi.Text.Equals(string.Empty)) { kayitGetir(); }
            else { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT kullanici_adi,il,ilce,telefon from kullanici where yetki =2 and kullanici_adi=@okul_adi ", baglanti);
            komut.Parameters.AddWithValue("@okul_adi", okul_adi.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            }

        }
    }
}
