using Bil372Proje.Pages.okul.ihtiyaclar;
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

namespace Bil372Proje.Pages.okul
{
    public partial class ihtiyac_ekle : Form
    {
        public string kAdi;
        public int Id;
        public ihtiyac_ekle(string kullanici )
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
            conn.Open();
            kAdi = kullanici;
            NpgsqlCommand cmd = new NpgsqlCommand("select Id from okul where kAdi=@kullanici", conn);
            cmd.Parameters.AddWithValue("@kullanici", kullanici);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            InitializeComponent();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kirtasiye kir = new kirtasiye(kAdi,Id);
            this.Hide();
            kir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mobilya mobilya = new mobilya(kAdi,Id);
            this.Hide();
            mobilya.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap(kAdi,Id);
            this.Hide();
            kitap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giysi giysi = new giysi(kAdi,Id);
            this.Hide();
            giysi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teknoloji teknoloji = new teknoloji(kAdi, Id);
            this.Hide();
            teknoloji.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void ihtiyac_ekle_Load(object sender, EventArgs e)
        {

        }
    }
}
