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
    public partial class silme_ekrani : Form
    {

        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public int okul_id;
        public silme_ekrani(string kullanici, int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }

        private void silme_ekrani_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT isim,marka,adet " +
                          " from ihtiyac where ihtiyac.okul_id =@okul_id";

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



        private void ihtiyac_sil(object sender, MouseEventArgs e)
        {
            sil();
        }
        private void sil()
        {
            con.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("select Id from okul where Id=@Id", con);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);

            con.Close();
        }
    }
}
