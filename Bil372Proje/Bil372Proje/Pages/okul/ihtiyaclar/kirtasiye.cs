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
        public int okul_id;
        public kirtasiye(string kullanici,int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }
        /*kirtasiye tablosunda ki en büyük Id bulunur.
         *insert into ile ara yüzden alınan ihtiyaçlar önce veri tabanına sonra datagridviewe eklenir         *
         */
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand komut2 = new SqlCommand("select adet from kirtasiye where isim=@isim", con);

            SqlCommand cmd = new SqlCommand("insert into kirtasiye(Id,okul_id,isim,adet,marka)" +
                " values(@Id,@okul_id,@isim,@adet,@marka)", con);
            cmd.Parameters.AddWithValue("@isim",kirtasiye_ihtiyac.Text);
            cmd.Parameters.AddWithValue("@adet", kirtasiye_adet.Text);
            cmd.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
            cmd.Parameters.AddWithValue("@Id", count);
            cmd.Parameters.AddWithValue("@okul_id", okul_id);
            cmd.ExecuteNonQuery();
            kayitGetir();
            clear();
        }
        private void clear()
        {
            kirtasiye_ihtiyac.Text = string.Empty;
            kirtasiye_adet.Text = string.Empty;
            kirtasiye_marka.Text = string.Empty;
            
        }
        private void kayitGetir()
        {
            string kayit = "SELECT k.isim,k.adet,k.marka" +
                " from kirtasiye k where k.okul_id =@okul_id";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
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

        private void kirtasiye_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
