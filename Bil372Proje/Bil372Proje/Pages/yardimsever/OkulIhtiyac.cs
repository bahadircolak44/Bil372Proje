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
    public partial class OkulIhtiyac : Form
    {
        int okul_id;
        public OkulIhtiyac(int Id)
        {
            okul_id = Id;
            //Yardimsever2 den sonra bu sayfaya gelinir seçilen okulun ihtiyaçlarını listeler
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT k.isim,k.adet,k.marka" +
                " from kirtasiye k where k.okul_id =@okul_id";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void Okul_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
