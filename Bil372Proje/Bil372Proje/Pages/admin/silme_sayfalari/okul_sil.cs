using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.admin.silme_sayfalari
{
    public partial class okul_sil : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

        public okul_sil()
        {
            InitializeComponent();
        }

        private void okul_sil_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {
            conn.Open();
            String okul = "select * from okul";
            NpgsqlCommand komut = new NpgsqlCommand(okul, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            // string okul_adi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            NpgsqlCommand cmd = new NpgsqlCommand("delete from okul where kAdi=@kullanici_adi", conn);
            NpgsqlCommand cmd2 = new NpgsqlCommand("delete from kullanici where kullanici_adi=@kullanici_adi", conn);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            cmd2.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_pages admin = new admin_pages();
            this.Hide();
            admin.Show();
        }
    }
}
