using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    public partial class mobilya : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
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

        private int fiyatHesapla(string ad, string marka, string renk, string olcu)
        {

            NpgsqlCommand cmd = new NpgsqlCommand("select fiyat from urun where ad=@ad and  marka = @marka and renk = @renk and olcu = @olcu", conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@marka", marka);
            cmd.Parameters.AddWithValue("@renk", renk);
            cmd.Parameters.AddWithValue("@olcu", olcu);

            int fiyat = Convert.ToInt32(cmd.ExecuteScalar());
            return fiyat;

        }

        private void mobilya_ekle_Click(object sender, EventArgs e)
        {

            if (!(mobilya_adet.Text.Equals(string.Empty) ||
                mobilya_ihtiyac.Text.Equals(string.Empty) ||
                mobilya_marka.Text.Equals(string.Empty) ||
                mobilya_renk.Text.Equals(string.Empty) ||
                mobilya_olcu.Text.Equals(string.Empty)))
            {
                conn.Open();
                //sql den adet çekiliyor
                NpgsqlCommand kontrol = new NpgsqlCommand("select adet from ihtiyac where isim=@isim and marka=@marka", conn);
                NpgsqlCommand kontrol2 = new NpgsqlCommand("select ihtiyac_id from mobilya where olcu=@olcu and renk=@renk", conn);

                kontrol.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                kontrol.Parameters.AddWithValue("@marka", mobilya_marka.Text);

                kontrol2.Parameters.AddWithValue("@olcu", mobilya_olcu.Text);
                kontrol2.Parameters.AddWithValue("@renk", mobilya_renk.Text);

                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(kontrol);
                NpgsqlDataAdapter adapt2 = new NpgsqlDataAdapter(kontrol2);

                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                adapt.Fill(ds);
                adapt2.Fill(ds2);
                //eğer sorgunun sonucunda birşy dönerse o zaman listenin üzerine ekleme yapacak yani if'e girecek yoksa else'e girecek
                int i = ds.Tables[0].Rows.Count;
                int j = ds2.Tables[0].Rows.Count;

                if (i > 0 && j > 0)
                {
                    //var olan adeti istenen kadar arttırıyor
                    NpgsqlCommand cmd = new NpgsqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim and Id=@Id", conn);
                    NpgsqlCommand cmd3 = new NpgsqlCommand("Update ihtiyac set fiyat=@fiyat Where isim = @isim and Id=@Id", conn);

                    int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(mobilya_adet.Text.Trim());
                    int cnt2 = Convert.ToInt32(kontrol2.ExecuteScalar());
                    //string ad, string marka, string renk, string olcu
                    int fiyat = cnt * (fiyatHesapla(mobilya_ihtiyac.Text, mobilya_marka.Text, mobilya_renk.Text, mobilya_olcu.Text));

                    cmd.Parameters.AddWithValue("@Adet", cnt);
                    cmd.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@Id", cnt2);

                    cmd3.Parameters.AddWithValue("@Id", cnt2);
                    cmd3.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                    cmd3.Parameters.AddWithValue("@fiyat", fiyat);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    //eski bir kayıt yoksa yenisini ekliyor
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
        " values(@okul_id,@isim,@adet,@marka,10,'mobilya')", conn);
                    cmd.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@adet", Convert.ToInt32(mobilya_adet.Text));
                    cmd.Parameters.AddWithValue("@marka", mobilya_marka.Text);
                    int fiyat = Convert.ToInt32(mobilya_adet.Text) * (fiyatHesapla(mobilya_ihtiyac.Text, mobilya_marka.Text, mobilya_renk.Text, mobilya_olcu.Text));
                    cmd.Parameters.AddWithValue("@okul_id", okul_id);
                    cmd.Parameters.AddWithValue("fiyat", fiyat);
                    cmd.ExecuteNonQuery();
                }



                //en son da gerekli bilgileri mobilyaya ekliyor
                NpgsqlCommand komut = new NpgsqlCommand("select max(id) from ihtiyac", conn);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                NpgsqlCommand cmd2 = new NpgsqlCommand("insert into mobilya(ihtiyac_id,renk,olcu)" +
                " values(@ihtiyac_id,@renk,@olcu)", conn);
                cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
                cmd2.Parameters.AddWithValue("@renk", mobilya_renk.Text);
                cmd2.Parameters.AddWithValue("@olcu", mobilya_olcu.Text);
                cmd2.ExecuteNonQuery();
                kayitGetir();
                label7.Text = totalfiyatgetir() + " TL";
                clear();

            }
            else
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır!", "Uyarı");
                clear();
            }
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

            string kayit = "SELECT isim,marka,adet " +
               " from ihtiyac where ihtiyac.okul_id =@okul_id";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //NpgsqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        private String totalfiyatgetir()
        {
            conn.Open();
            string kayit = "SELECT SUM(fiyat) " +
                          " from ihtiyac where ihtiyac.okul_id =@okul_id";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir NpgsqlCommand nesnesi oluşturuyoruz.
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            //NpgsqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            var total = komut.ExecuteScalar().ToString();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();

            return total;
        }

        private void mobilya_Load(object sender, EventArgs e)
        {
            comboBoxGetir();
            kayitGetir();
            label7.Text = totalfiyatgetir() + " TL";

        }

        private void comboBoxGetir()
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.CommandText = "SELECT * FROM urun where kategori = @kategori";
            komut.Parameters.AddWithValue("@kategori", "mobilya");
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            NpgsqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                mobilya_ihtiyac.Items.Add(dr["ad"]);
                mobilya_marka.Items.Add(dr["marka"]);
                mobilya_olcu.Items.Add(dr["olcu"]);
                mobilya_renk.Items.Add(dr["renk"]);
        
            }
            conn.Close();

        }
    }
}
