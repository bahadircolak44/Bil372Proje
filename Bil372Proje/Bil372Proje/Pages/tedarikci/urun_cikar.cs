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

namespace Bil372Proje.Pages.tedarikci
{
    public partial class urun_cikar : Form
    {
        String kAdi;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public urun_cikar(String k)
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

        private void sil_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand("delete from urun where Id=@Id",conn);
            cmd.Parameters.AddWithValue("@Id",Id);
            cmd.ExecuteNonQuery();
            conn.Close();
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT *  from urun ";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
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

        private void urun_cikar_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
