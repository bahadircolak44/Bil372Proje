using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bil372Proje.Pages.admin.istek_sayfalari
{
    public partial class okul_istek : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public okul_istek()
        {
            InitializeComponent();
        }

        private void okul_istek_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT * " +
                          " from kullanici k" +
                          "inner join okul o on o.valid = 0 and kullanici_adi=o.kAdi";


            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void onay_click_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            NpgsqlCommand cmd = new NpgsqlCommand("update okul set valid = 1 where kAdi=@kullanici_adi", conn);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            cmd.ExecuteNonQuery();
            conn.Close();
            kayitGetir();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            admin_pages admin = new admin_pages();
            this.Hide();
            admin.Show();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
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
    }
}
