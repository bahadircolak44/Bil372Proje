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
    public partial class urun_ekle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        public urun_ekle()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages();
            this.Hide();
            tedarikci.Show();
        
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string kayit = "insert into urun(kategori,ad,stok_miktari,fiyat,marka) " +
                "values(@kategori,@ad,@stok_miktari,@fiyat,@marka)";
            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@kategori", katagori.Text);
            komut.Parameters.AddWithValue("@ad", ad.Text);
            komut.Parameters.AddWithValue("@stok_miktari", stok_miktari.Text);
            komut.Parameters.AddWithValue("@fiyat", fiyat.Text);
            komut.Parameters.AddWithValue("@marka", marka.Text);
            komut.ExecuteNonQuery();
            con.Close();
            kayitGetir();
            clear();
        }
        private void clear()
        {
            katagori.Text = string.Empty;
            ad.Text = string.Empty;
            stok_miktari.Text = string.Empty;
            fiyat.Text = string.Empty;
            marka.Text = string.Empty;

        }
        private void urun_ekle_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT *  from urun ";

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
