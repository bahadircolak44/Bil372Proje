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
    public partial class OkulIhtiyac : Form
    {
        int okul_id;
        public string kullanici_adi;
        public OkulIhtiyac(int Id, string kAdi)
        {
            kullanici_adi = kAdi;
            okul_id = Id;
            //Yardimsever2 den sonra bu sayfaya gelinir seçilen okulun ihtiyaçlarını listeler
            InitializeComponent();
        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kayitGetir()
        {
            conn.Open();
            string kayit = "select isim,adet,tur from ihtiyac where okul_id=@okul_id";
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Okul_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            yardimsever2 ys2 = new yardimsever2(kullanici_adi);
            this.Hide();
            ys2.Show();
        }

        private void para_bagisla_Click(object sender, EventArgs e)
        {
            para_bagisla bagisla = new para_bagisla(okul_id,kullanici_adi);
            this.Hide();
            bagisla.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ihtiyac_karsila karsila = new ihtiyac_karsila(kullanici_adi, okul_id);
            this.Hide();
            karsila.Show();
        }
    }
}
