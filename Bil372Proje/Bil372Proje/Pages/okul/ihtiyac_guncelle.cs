using Bil372Proje.Pages.okul;
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
    public partial class ihtiyac_guncelle : Form
    {
        String kAdi;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

        public ihtiyac_guncelle(String kullaniciAdi)
        {
            InitializeComponent();
            kAdi = kullaniciAdi;
        }

        private void ihtiyac_guncelle_load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {
            string kayit = "SELECT Id,isim,marka,adet,tur from ihtiyac ";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string tur = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand("delete from "+ tur + " where ihtiyac_id=@Id", conn);
            NpgsqlCommand cmd2 = new NpgsqlCommand("delete from ihtiyac where Id=@Id", conn);
            cmd.Parameters.AddWithValue("@tur", tur);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd2.Parameters.AddWithValue("@Id", Id);
           cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int Id = 0;

            Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            guncelle gun = new guncelle(Id,kAdi);
            this.Hide();
            gun.Show();
        }

       
    }
}
