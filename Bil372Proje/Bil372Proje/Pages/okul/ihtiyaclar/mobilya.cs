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
    public partial class mobilya : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public int okul_id;
        public mobilya(string kullanici,int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }

        private void mobilya_geri_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }

        private void mobilya_ekle_Click(object sender, EventArgs e)
        {
            con.Open();
            //sql den adet çekiliyor
            SqlCommand kontrol = new SqlCommand("select adet from ihtiyac where isim=@isim and marka=@marka", con);
            kontrol.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
            kontrol.Parameters.AddWithValue("@isim", mobilya_marka.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(kontrol);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            //eğer sorgunun sonucunda birşy dönerse o zaman listenin üzerine ekleme yapacak yani if'e girecek yoksa else'e girecek
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                //var olan adeti istenen kadar arttırıyor
                SqlCommand cmd = new SqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim", con);
                int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(mobilya_adet.Text.Trim());
                MessageBox.Show(cnt.ToString());
                cmd.Parameters.AddWithValue("@Adet", cnt);
                cmd.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //eski bir kayıt yoksa yenisini ekliyor
                SqlCommand cmd = new SqlCommand("insert into ihtiyac(okul_id,isim,adet,marka)" +
    " values(@okul_id,@isim,@adet,@marka)", con);
                cmd.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@adet", mobilya_adet.Text);
                cmd.Parameters.AddWithValue("@marka", mobilya_marka.Text);
                cmd.Parameters.AddWithValue("@okul_id", okul_id);
                cmd.ExecuteNonQuery();
            }


            //en son da gerekli bilgileri mobilyaya ekliyor
            SqlCommand komut = new SqlCommand("select max(id) from ihtiyac", con);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("insert into mobilya(ihtiyac_id,renk,olcu)" +
            " values(@ihtiyac_id,@renk,@olcu)", con);
            cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
            cmd2.Parameters.AddWithValue("@renk", count);
            cmd2.Parameters.AddWithValue("@olcu", count);
            cmd2.ExecuteNonQuery();
            kayitGetir();
            clear();
        }
        //ekran üzerindeki textleri kayıt sonrasında siliyor
        private void clear()
        {
            mobilya_ihtiyac.Text = string.Empty;
            mobilya_adet.Text =string.Empty;
            mobilya_marka.Text = string.Empty;
            mobilya_olcu.Text = string.Empty;
            mobilya_renk.Text = string.Empty;
        }

        private void kayitGetir()
        {

            string kayit = "SELECT * " +
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

        private void mobilya_Load(object sender, EventArgs e)
        {
            kayitGetir();

        }
}
}
