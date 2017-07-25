using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.admin.silme_sayfalari
{
    public partial class tedarikci_sil : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

        public tedarikci_sil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin_pages admin = new admin_pages();
            this.Hide();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[1].Value.ToString();

             NpgsqlCommand cmd = new NpgsqlCommand("delete from tedarikci where kAdi=@kullanici_adi", conn);
            NpgsqlCommand cmd2 = new NpgsqlCommand("delete from kullanici where kullanici_adi=@kullanici_adi", conn);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            cmd2.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            kayitGetir();
        }

        private void tedarikci_sil_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {
            conn.Open();
            String tedarikci = "select * from tedarikci";
            NpgsqlCommand komut = new NpgsqlCommand(tedarikci, conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }
    }
}
