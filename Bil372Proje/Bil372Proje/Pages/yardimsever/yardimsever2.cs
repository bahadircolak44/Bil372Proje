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
    public partial class yardimsever2 : Form
    {
        public string kullanici_adi;
        public yardimsever2(string kAdi)
        {
            kullanici_adi = kAdi;
            // Okul Arama Sayfasıdır.
            InitializeComponent();
        }

      NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");


        private void Form1_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            conn.Open();
            string kayit = "SELECT okul.okul_adi,il,ilce,telefon,puan from kullanici inner join okul on okul.kAdi = kullanici.kullanici_adi where yetki = 2 order by puan asc";
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void goto_okulpage(object sender, MouseEventArgs e)
        {
            conn.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand("select Id from okul where kAdi=@kullanici_adi" , conn);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            int Id= Convert.ToInt32(cmd.ExecuteScalar());
            OkulIhtiyac okul = new OkulIhtiyac(Id,kullanici_adi);
            this.Hide();
            okul.Show();
            conn.Close();
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
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand("SELECT kullanici_adi,il,ilce,telefon from kullanici where yetki =2 and kullanici_adi=@okul_adi ", conn);
            komut.Parameters.AddWithValue("@okul_adi", okul_adi.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            }

        }
    }
}
