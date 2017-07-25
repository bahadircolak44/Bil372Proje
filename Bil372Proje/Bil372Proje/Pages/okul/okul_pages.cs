using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul
{
    public partial class okul_pages : Form
    {
        String kAdi;
        int okul_id=0;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

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
            //MessageBox.Show(okul_id.ToString());
        }

        private String kayitGetir()
        {
            conn.Open();
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand("SELECT bakiye from okul where kAdi=@kullanici_adi", conn);
            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT Id from okul where kAdi=@kullanici_adi", conn);
            komut.Parameters.AddWithValue("@kullanici_adi",kAdi );
            komut2.Parameters.AddWithValue("@kullanici_adi", kAdi);
            okul_id = Convert.ToInt32(komut2.ExecuteScalar());
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            var bakiye= komut.ExecuteScalar().ToString();
            conn.Close();
            return bakiye;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ihtiyac_karsila karsila = new ihtiyac_karsila(kAdi,okul_id);
            this.Hide();
            karsila.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ihtiyac_guncelle guncelle = new ihtiyac_guncelle(kAdi);
            this.Hide();
            guncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gecmis gec = new gecmis(kAdi);
            this.Hide();
            gec.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
