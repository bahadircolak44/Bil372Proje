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
        int okul_id=0;
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
            
           bakiye_btn.Text= kayitGetir()+ " TL";
            MessageBox.Show(okul_id.ToString());
        }

        private String kayitGetir()
        {
            con.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand("SELECT bakiye from okul where kAdi=@kullanici_adi", con);
            SqlCommand komut2 = new SqlCommand("SELECT Id from okul where kAdi=@kullanici_adi", con);
            komut.Parameters.AddWithValue("@kullanici_adi",kAdi );
            komut2.Parameters.AddWithValue("@kullanici_adi", kAdi);
            okul_id = Convert.ToInt32(komut2.ExecuteScalar());
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            var bakiye= komut.ExecuteScalar().ToString();
            con.Close();
            return bakiye;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ihtiyac_karsila karsila = new ihtiyac_karsila(kAdi,okul_id);
            this.Hide();
            karsila.Show();
        }
    }
}
