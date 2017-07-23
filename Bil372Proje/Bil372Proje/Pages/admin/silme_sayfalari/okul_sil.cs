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

namespace Bil372Proje.Pages.admin.silme_sayfalari
{
    public partial class okul_sil : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

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

            String okul = "select * from okul";
            SqlCommand komut = new SqlCommand(okul, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            // string okul_adi = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            SqlCommand cmd = new SqlCommand("delete from okul where kAdi=@kullanici_adi", con);
            SqlCommand cmd2 = new SqlCommand("delete from kullanici where kullanici_adi=@kullanici_adi", con);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            cmd2.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            con.Close();
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
