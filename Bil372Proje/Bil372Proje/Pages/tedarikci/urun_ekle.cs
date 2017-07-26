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
using Bil372Proje.Pages.tedarikci.urun_ekleme;
using Bil372Proje.Pages.tedarikci.yeni_urun;

namespace Bil372Proje.Pages.tedarikci
{
    public partial class urun_ekle : Form
    {
        String kAdi;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public urun_ekle(String k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap(kAdi);
            this.Hide();
            kitap.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kirtasiye kirtasiye = new kirtasiye(kAdi);
            this.Hide();
            kirtasiye.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            giysi giysi = new giysi(kAdi);
            this.Hide();
            giysi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mobilya mobilya = new mobilya(kAdi);
            this.Hide();
            mobilya.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            teknoloji mobilya = new teknoloji(kAdi);
            this.Hide();
            mobilya.Show();
        }
    }
}
