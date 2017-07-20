using Bil372Proje.Pages.okul.ihtiyaclar;
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
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            con.Open();
            kAdi = kullanici;
            SqlCommand cmd = new SqlCommand("select Id from okul where kAdi=@kullanici", con);
            cmd.Parameters.AddWithValue("@kullanici", kullanici);
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            InitializeComponent();
            con.Close();
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
            tum_ihtiyaclar tum_ihtiyaclar = new tum_ihtiyaclar();
            this.Hide();
            tum_ihtiyaclar.Show();
        }
    }
}
