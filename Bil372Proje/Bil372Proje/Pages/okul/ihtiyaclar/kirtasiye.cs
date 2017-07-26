using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul.ihtiyaclar
{

    public partial class kirtasiye : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public string kAdi;
        public int okul_id;
        public kirtasiye(string kullanici,int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }
        private int fiyatHesapla(string ad, string marka, string renk, string cinsiyet)
        {

            NpgsqlCommand cmd = new NpgsqlCommand("select fiyat from urun where ad=@ad and marka=@marka" +
                " and renk =@renk and cinsiyet =@cinsiyet", conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@marka", marka);
            cmd.Parameters.AddWithValue("@renk", renk);
            cmd.Parameters.AddWithValue("@cinsiyet", cinsiyet);
            int fiyat = Convert.ToInt32(cmd.ExecuteScalar());
            return fiyat;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }
        /*kirtasiye tablosunda ki en büyük Id bulunur.
         *insert into ile ara yüzden alınan ihtiyaçlar önce veri tabanına sonra datagridviewe eklenir         *
         */
        private void button1_Click(object sender, EventArgs e)
        {

            if (!(kirtasiye_adet.Text.Equals(string.Empty) ||
                kirtasiye_ihtiyac.Text.Equals(string.Empty) ||
                kirtasiye_marka.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("select adet from ihtiyac where isim=@isim and marka=@marka", conn);
                kontrol.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
                kontrol.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(kontrol);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int i = ds.Tables[0].Rows.Count;
                if (i > 0)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim", conn);
                    NpgsqlCommand cmd3 = new NpgsqlCommand("Update ihtiyac set fiyat=@fiyat Where isim = @isim", conn);
                    int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(kirtasiye_adet.Text.Trim());
                    cmd.Parameters.AddWithValue("@Adet", cnt);
                    cmd.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
                    int fiyat = cnt * (fiyatHesapla(kirtasiye_ihtiyac.Text, kirtasiye_marka.Text, kirtasiye_renk.Text, "kız/erkek"));
                    MessageBox.Show(fiyat.ToString());
                    cmd3.Parameters.AddWithValue("@fiyat",fiyat);
                    cmd3.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
        " values(@okul_id,@isim,@adet,@marka,@fiyat,'kirtasiye')", conn);
                    cmd.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@adet", Convert.ToInt32(kirtasiye_adet.Text));
                    cmd.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
                    cmd.Parameters.AddWithValue("@okul_id", okul_id);
                    int fiyat = Convert.ToInt32(kirtasiye_adet.Text) * (fiyatHesapla(kirtasiye_ihtiyac.Text, kirtasiye_marka.Text, kirtasiye_renk.Text, "kız/erkek"));
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.ExecuteNonQuery();
                }



                NpgsqlCommand komut = new NpgsqlCommand("select max(id) from ihtiyac", conn);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                NpgsqlCommand cmd2 = new NpgsqlCommand("insert into kirtasiye(ihtiyac_id)" +
                " values(@ihtiyac_id)", conn);
                cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
                cmd2.ExecuteNonQuery();
                kayitGetir();
                clear();
                label7.Text = totalfiyatgetir() + " TL";
            }
            else
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır!", "Uyarı");
                clear();
            }
        }
        private void clear()
        {
            kirtasiye_ihtiyac.Text = string.Empty;
            kirtasiye_adet.Text = string.Empty;
            kirtasiye_marka.Text = string.Empty;
            kirtasiye_renk.Text = string.Empty;
        }
        private void kayitGetir()
        {
            string kayit = "SELECT isim,marka,adet,fiyat " +
                          " from ihtiyac where ihtiyac.okul_id =@okul_id";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        private void kirtasiye_Load(object sender, EventArgs e)
        {
            comboboxGetir();
            kayitGetir();
            label7.Text = totalfiyatgetir() + " TL";
        }

        private void comboboxGetir()
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.CommandText = "SELECT * FROM urun where kategori = @kategori";
            komut.Parameters.AddWithValue("@kategori", "kirtasiye");
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            NpgsqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kirtasiye_ihtiyac.Items.Add(dr["ad"]);
                kirtasiye_marka.Items.Add(dr["marka"]);
                kirtasiye_renk.Items.Add(dr["renk"]);

            }
            conn.Close();
        }

        private String totalfiyatgetir()
        {
            conn.Open();
            string kayit = "SELECT SUM(fiyat) " +
                          " from ihtiyac where ihtiyac.okul_id =@okul_id";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataSet dt = new DataSet();
            da.Fill(dt);
            var total = komut.ExecuteScalar().ToString();
            conn.Close();

            return total;
        }
    }
}
