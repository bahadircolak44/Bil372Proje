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

namespace Bil372Proje.Pages.okul
{
    public partial class okul_pages : Form
    {
        String kAdi;
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        public okul_pages(String kullaniciAdi)
        {
            InitializeComponent();
            kAdi = kullaniciAdi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }

        private void okul_pages_Load(object sender, EventArgs e)
        {
           bakiye_btn.Text= kayitGetir();
        }

        private String kayitGetir()
        {
            con.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand("SELECT bakiye from okul where kAdi=@kullanici_adi", con);
            komut.Parameters.AddWithValue("@kullanici_adi",kAdi );
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            var bakiye= komut.ExecuteScalar().ToString();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
            return bakiye;
        }
    }
}
