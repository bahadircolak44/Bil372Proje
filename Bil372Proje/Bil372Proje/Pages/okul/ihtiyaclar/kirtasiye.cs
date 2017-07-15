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

namespace Bil372Proje.Pages.okul.ihtiyaclar
{

    public partial class kirtasiye : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public kirtasiye(string kullanici)
        {
            kAdi = kullanici;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into kirtasiye(Id,okul_id,isim,adet,marka)" +
                " values(2,1,@isim,@adet,@marka)",con);
            cmd.Parameters.AddWithValue("@isim",kirtasiye_ihtiyac.Text);
            cmd.Parameters.AddWithValue("@adet", kirtasiye_adet.Text);
            cmd.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            kayitGetir();
        }
        private void kayitGetir()
        {
            con.Open();
            string kayit = "SELECT * from kirtasiye";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
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
    }
}
