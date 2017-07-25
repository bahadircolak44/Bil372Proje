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

namespace Bil372Proje.Pages.yardimsever
{
    public partial class para_bagisla : Form
    {
        int okul_id;
        public string kullanici_adi;
        public para_bagisla(int Id, string kAdi)
        {
            kullanici_adi = kAdi;
            okul_id = Id;
            //Yardimsever2 den sonra bu sayfaya gelinir seçilen okulun ihtiyaçlarını listeler
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");


        private void Geri_Click(object sender, EventArgs e)
        {
            OkulIhtiyac oi = new OkulIhtiyac(okul_id,kullanici_adi);
            this.Hide();
            oi.Show();
        }
        private bool kayitGuncelle()
        {
            con.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand("SELECT bakiye from yardimsever where kAdi=@kullanici_adi", con);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            int bakiye = Convert.ToInt32(komut.ExecuteScalar());
            if (miktar.Text == "")
            {
                MessageBox.Show("Miktarı boş bırakamazsınız!");
                con.Close();
                return false;
            }
            int mik = Convert.ToInt32(miktar.Text);
            if ((bakiye == 0 || bakiye < mik))
            {
                MessageBox.Show("Bakiyeniz Yetersiz!");
                con.Close();
                return false;
            }
            SqlCommand yardimsever = new SqlCommand("update yardimsever set bakiye=bakiye - @ybakiye where kAdi=@kullanici_adi ", con);
            SqlCommand okul = new SqlCommand("update okul set bakiye=bakiye + @obakiye where id=@okul_id", con);
            yardimsever.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            yardimsever.Parameters.AddWithValue("@ybakiye", miktar.Text);
            okul.Parameters.AddWithValue("@obakiye", miktar.Text);
            okul.Parameters.AddWithValue("@okul_id", okul_id);
            yardimsever.ExecuteNonQuery();
            okul.ExecuteNonQuery();
            MessageBox.Show("İşlem Başarıyla Gerçekleşti");
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
            return true;

        }

        private void bagisla_Click(object sender, EventArgs e)
        {
         
            kayitGuncelle();

        }

        private int bakiyeGetir()
        {
            con.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand("SELECT bakiye from yardimsever where kAdi=@kullanici_adi", con);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            int bakiye = Convert.ToInt32(komut.ExecuteScalar());
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
            return bakiye;
        }

        private void para_bagisla_Load(object sender, EventArgs e)
        {
            button1.Text = bakiyeGetir() + " TL";
        }
    }
}
