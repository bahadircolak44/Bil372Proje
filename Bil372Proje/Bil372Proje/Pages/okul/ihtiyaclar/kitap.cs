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
    public partial class kitap : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public int okul_id;
        public kitap(string kullanici, int Id)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(kitap_ihtiyac.Text.Equals(string.Empty) ||
                kitap_adet.Text.Equals(string.Empty) ||
                kitap_tur.Text.Equals(string.Empty) ||
                kitap_yayin_evi.Text.Equals(string.Empty) ||
                kitap_yayin_yili.Text.Equals(string.Empty) ||
                kitap_yazar.Text.Equals(string.Empty)))
            {
                con.Open();
                SqlCommand kontrol = new SqlCommand("select adet from ihtiyac where isim=@isim", con);
                SqlCommand kontrol2 = new SqlCommand("select ihtiyac_id from kitap where tur=@tur and yayin_evi=@yayin_evi and yazar=@yazar and yayin_yili=@yayin_yili", con);

                kontrol.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);

                kontrol2.Parameters.AddWithValue("@tur", kitap_tur.Text);
                kontrol2.Parameters.AddWithValue("@yayin_evi", kitap_yayin_evi.Text);
                kontrol2.Parameters.AddWithValue("@yazar", kitap_yazar.Text);
                kontrol2.Parameters.AddWithValue("@yayin_yili", kitap_yayin_yili.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(kontrol);
                SqlDataAdapter adapt2 = new SqlDataAdapter(kontrol2);
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                adapt.Fill(ds);
                adapt2.Fill(ds2);

                int i = ds.Tables[0].Rows.Count;
                int j = ds2.Tables[0].Rows.Count;

                if (i > 0 && j > 0)
                {
                    SqlCommand cmd = new SqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim and Id=@Id", con);
                    int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(kitap_adet.Text.Trim());
                    int cnt2 = Convert.ToInt32(kontrol2.ExecuteScalar());
                    cmd.Parameters.AddWithValue("@Adet", cnt);
                    cmd.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@Id", cnt2);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
        " values(@okul_id,@isim,@adet,@marka,10,'kitap')", con);
                    cmd.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@adet", kitap_adet.Text);
                    cmd.Parameters.AddWithValue("@marka", string.Empty);
                    cmd.Parameters.AddWithValue("@okul_id", okul_id);
                    cmd.ExecuteNonQuery();
                }



                SqlCommand komut = new SqlCommand("select max(id) from ihtiyac", con);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                SqlCommand cmd2 = new SqlCommand("insert into kitap(ihtiyac_id,tur,yazar,yayin_evi,yayin_yili)" +
                " values(@ihtiyac_id,@tur,@yazar,@yayin_evi,@yayin_yili)", con);
                cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
                cmd2.Parameters.AddWithValue("@tur", kitap_tur.Text);
                cmd2.Parameters.AddWithValue("@yazar", kitap_yazar.Text);
                cmd2.Parameters.AddWithValue("@yayin_evi", kitap_yayin_evi.Text);
                cmd2.Parameters.AddWithValue("@yayin_yili", kitap_yayin_yili.Text);
                cmd2.ExecuteNonQuery();
                kayitGetir();
                clear();

            }
            else
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır!", "Uyarı");
                clear();
            }
            }
        private void clear()
        {
            kitap_ihtiyac.Text = string.Empty;
            kitap_adet.Text = string.Empty;
            kitap_tur.Text = string.Empty;
            kitap_yayin_evi.Text = string.Empty;
            kitap_yayin_yili.Text = string.Empty;
            kitap_yazar.Text = string.Empty;

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

        private void kitap_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
