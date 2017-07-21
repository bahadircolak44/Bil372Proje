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
    public partial class giysi : Form
    {

        // butonlar eklendi. Ekle ve geri butonlari bir sey yapmiyor. 
        // ihtiyactaki textbox'ta dropdown eklenecek.
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public int okul_id;
        public giysi(string kullanici, int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }
        private void giysi_ekle_Click(object sender, EventArgs e)
        {
            if (!(giysi_adet.Text.Equals(string.Empty) ||
                giysi_beden.Text.Equals(string.Empty) ||
                giysi_cinsiyet.Text.Equals(string.Empty) ||
                giysi_kumas.Text.Equals(string.Empty) ||
                giysi_renk.Text.Equals(string.Empty)))
            {
                con.Open();
            //sql den adet çekiliyor
            SqlCommand kontrol = new SqlCommand("select adet from ihtiyac where isim=@isim and marka=@marka", con);
            SqlCommand kontrol2 = new SqlCommand("select ihtiyac_id from giysi where beden=@beden and renk=@renk and kumas=@kumas and cinsiyet=@cinsiyet ", con);

            kontrol.Parameters.AddWithValue("@isim", giysi_ihtiyac.Text);
            kontrol.Parameters.AddWithValue("@marka", giysi_marka.Text);

            kontrol2.Parameters.AddWithValue("@beden", giysi_beden.Text);
            kontrol2.Parameters.AddWithValue("@renk", giysi_renk.Text);
            kontrol2.Parameters.AddWithValue("@kumas", giysi_kumas.Text);
            kontrol2.Parameters.AddWithValue("@cinsiyet", giysi_cinsiyet.Text);

            SqlDataAdapter adapt = new SqlDataAdapter(kontrol);
            SqlDataAdapter adapt2 = new SqlDataAdapter(kontrol2);
            DataSet ds = new DataSet();
            DataSet ds2 = new DataSet();
            adapt.Fill(ds);
            adapt2.Fill(ds2);


            //eğer sorgunun sonucunda birşey dönerse o zaman listenin üzerine ekleme yapacak yani if'e girecek yoksa else'e girecek
            int i = ds.Tables[0].Rows.Count;
            int j = ds2.Tables[0].Rows.Count;


            if (i > 0 && j > 0)
            {
                //var olan adeti istenen kadar arttırıyor
                SqlCommand cmd = new SqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim and Id=@Id", con);
                int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(giysi_adet.Text.Trim());
                int cnt2 = Convert.ToInt32(kontrol2.ExecuteScalar());

                cmd.Parameters.AddWithValue("@Adet", cnt);
                cmd.Parameters.AddWithValue("@isim", giysi_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@Id", cnt2);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //eski bir kayıt yoksa yenisini ekliyor
                SqlCommand cmd = new SqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
    " values(@okul_id,@isim,@adet,@marka,10,'giysi')", con);
                cmd.Parameters.AddWithValue("@isim", giysi_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@adet", giysi_adet.Text);
                cmd.Parameters.AddWithValue("@marka", giysi_marka.Text);
                cmd.Parameters.AddWithValue("@okul_id", okul_id);
                cmd.ExecuteNonQuery();
            }


            //en son da gerekli bilgileri mobilyaya ekliyor
            SqlCommand komut = new SqlCommand("select max(id) from ihtiyac", con);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("insert into giysi(ihtiyac_id,beden,renk,kumas,cinsiyet)" +
            " values(@ihtiyac_id,@beden,@renk,@kumas,@cinsiyet)", con);
            cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
            cmd2.Parameters.AddWithValue("@beden", giysi_beden.Text);
            cmd2.Parameters.AddWithValue("@renk", giysi_renk.Text);
            cmd2.Parameters.AddWithValue("@kumas", giysi_kumas.Text);
            cmd2.Parameters.AddWithValue("@cinsiyet", giysi_cinsiyet.Text);
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
        private void giysi_geri_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }
        private void clear()
        {
            giysi_ihtiyac.Text = string.Empty;
            giysi_adet.Text = string.Empty;
            giysi_marka.Text = string.Empty;
            giysi_beden.Text = string.Empty;
            giysi_renk.Text = string.Empty;
            giysi_kumas.Text = string.Empty;
            giysi_cinsiyet.Text = string.Empty;
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
        private void giysi_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }


    }
}
