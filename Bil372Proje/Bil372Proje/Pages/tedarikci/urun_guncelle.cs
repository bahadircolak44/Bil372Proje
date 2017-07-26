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

namespace Bil372Proje.Pages.tedarikci
{
    public partial class urun_guncelle : Form
    {
        String kAdi;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public urun_guncelle(String k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void kayitGetir()
        {

            string kayit = "SELECT *  from urun ";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void urun_guncelle_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            guncelle gun = new guncelle(Id,kAdi);
            this.Hide();
            gun.Show();
        }

        private void Guncelle_Click(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand("delete from urun where Id=@Id", conn);
            cmd.Parameters.AddWithValue("@Id",Id);
            cmd.ExecuteNonQuery();
            conn.Close();
            kayitGetir();

        }
    }
}
