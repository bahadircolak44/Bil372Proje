using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Bil372Proje.Pages.okul
{
    public partial class guncelle : Form
    {
        int u_id;
        String kAdi;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public guncelle(int Id, String kadi)
        {
            u_id = Id;
            kAdi = kadi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            conn.Open();

            if (!(adet.Text.Equals(string.Empty)))
            {
               
                string kayit = "update ihtiyac set adet=@adet where Id=@Id";
                NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
                komut.Parameters.AddWithValue("@adet", adet.Text);
                komut.Parameters.AddWithValue("@Id", u_id.ToString());
                komut.ExecuteNonQuery();
            }

            if (!(fiyat.Text.Equals(string.Empty)))
            {
                string kayit2 = "update ihtiyac set fiyat=@fiyat where Id=@Id";
                NpgsqlCommand komut2 = new NpgsqlCommand(kayit2, conn);
                komut2.Parameters.AddWithValue("@fiyat", fiyat.Text);
                komut2.Parameters.AddWithValue("@Id", u_id.ToString());
                komut2.ExecuteNonQuery();
            }

            conn.Close();
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
