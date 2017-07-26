using Npgsql;
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
    public partial class teknoloji : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public string kAdi;
        public int okul_id;
        public teknoloji(string kullanici, int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }

        private void teknoloji_Load(object sender, EventArgs e)
        {
            comboboxGetir();
            kayitGetir();
            label7.Text = totalfiyatgetir() + " TL";
        }

        private int fiyatHesapla(string ad, string marka, string model, string uretim_yili)
        {

            NpgsqlCommand cmd = new NpgsqlCommand("select fiyat from urun where ad=@ad and  marka = @marka and model = @model and uretim_yili = @uretim_yili", conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@marka", marka);        
            cmd.Parameters.AddWithValue("@model", model);
            cmd.Parameters.AddWithValue("@uretim_yili", uretim_yili);
           int fiyat = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show(fiyat.ToString());
            return fiyat;

        }
        private void comboboxGetir()
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.CommandText = "SELECT * FROM urun where kategori = @kategori";
            komut.Parameters.AddWithValue("@kategori", "teknoloji");
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            NpgsqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                teknoloji_ihtiyac.Items.Add(dr["ad"]);
                teknoloji_marka.Items.Add(dr["marka"]);
                teknoloji_model.Items.Add(dr["model"]);
                teknoloji_uretim_yili.Items.Add(dr["uretim_yili"]);

            }
            conn.Close();

        }

        private void teknoloji_geri_Click(object sender, EventArgs e)
        {
            ihtiyac_ekle ie = new ihtiyac_ekle(kAdi);
            this.Hide();
            ie.Show();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT isim,marka,adet " +
                          " from ihtiyac where ihtiyac.okul_id =@okul_id";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            komut.Parameters.AddWithValue("@okul_id", okul_id);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            var total = komut.ExecuteScalar().ToString();
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();

            return total;
        }

        private void teknoloji_ekle(object sender, EventArgs e)
        {
            if (!(teknoloji_model.Text.Equals(string.Empty) || 
                teknoloji_marka .Text.Equals(string.Empty) || 
                teknoloji_adet.Text.Equals(string.Empty) ||
                teknoloji_uretim_yili.Text.Equals(string.Empty) ||
                teknoloji_ihtiyac.Text.Equals(string.Empty)))
            {

           
            conn.Open();
            //sql den adet çekiliyor
            NpgsqlCommand kontrol = new NpgsqlCommand("select adet from ihtiyac where isim=@isim and marka=@marka", conn);
            NpgsqlCommand kontrol2 = new NpgsqlCommand("select ihtiyac_id from teknoloji where model=@model and uretim_yili=@uretim_yili ", conn);

            kontrol.Parameters.AddWithValue("@isim", teknoloji_ihtiyac.Text);
            kontrol.Parameters.AddWithValue("@marka", teknoloji_marka.Text);

            kontrol2.Parameters.AddWithValue("@model", teknoloji_model.Text);
            kontrol2.Parameters.AddWithValue("@uretim_yili", teknoloji_uretim_yili.Text);
            
            NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(kontrol);
            NpgsqlDataAdapter adapt2 = new NpgsqlDataAdapter(kontrol2);
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
                NpgsqlCommand cmd = new NpgsqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim and Id=@Id", conn);
                NpgsqlCommand cmd3 = new NpgsqlCommand("Update ihtiyac set fiyat=@fiyat Where isim = @isim and Id=@Id", conn);
                int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(teknoloji_adet.Text.Trim());
                int cnt2 = Convert.ToInt32(kontrol2.ExecuteScalar());
                    //string ad, string marka, string renk, string model, string uretim_yili
                int fiyat = cnt * (fiyatHesapla(teknoloji_ihtiyac.Text, teknoloji_marka.Text, teknoloji_model.Text,teknoloji_uretim_yili.Text));
                    MessageBox.Show(fiyat.ToString());
                    cmd.Parameters.AddWithValue("@Adet", cnt);
                cmd.Parameters.AddWithValue("@isim", teknoloji_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@Id", cnt2);

                cmd3.Parameters.AddWithValue("@Id", cnt2);
                cmd3.Parameters.AddWithValue("@isim", teknoloji_ihtiyac.Text);
                cmd3.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.ExecuteNonQuery();
            }
            else
            {
                //eski bir kayıt yoksa yenisini ekliyor
                NpgsqlCommand cmd = new NpgsqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
    " values(@okul_id,@isim,@adet,@marka,@fiyat,'teknoloji')", conn);
                cmd.Parameters.AddWithValue("@isim", teknoloji_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@adet", Convert.ToInt32(teknoloji_adet.Text));
                cmd.Parameters.AddWithValue("@marka", teknoloji_marka.Text);
                cmd.Parameters.AddWithValue("@okul_id", okul_id);
                int fiyat = Convert.ToInt32(teknoloji_adet.Text) *(fiyatHesapla(teknoloji_ihtiyac.Text, teknoloji_marka.Text, teknoloji_model.Text, teknoloji_uretim_yili.Text));

                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.ExecuteNonQuery();
            }


            //en son da gerekli bilgileri mobilyaya ekliyor
            NpgsqlCommand komut = new NpgsqlCommand("select max(id) from ihtiyac", conn);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            NpgsqlCommand cmd2 = new NpgsqlCommand("insert into teknoloji(ihtiyac_id,model,uretim_yili)" +
            " values(@ihtiyac_id,@model,@uretim_yili)", conn);
            cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
            cmd2.Parameters.AddWithValue("@model", teknoloji_model.Text);
            cmd2.Parameters.AddWithValue("@uretim_yili", teknoloji_uretim_yili.Text);
        
            cmd2.ExecuteNonQuery();
            kayitGetir();
                label7.Text = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()) * (fiyatHesapla(teknoloji_ihtiyac.Text, teknoloji_marka.Text, teknoloji_model.Text, teknoloji_uretim_yili.Text)) + " TL";
                clear();
            }
            else
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır!","Uyarı");
                clear();
            }

        }
        private void clear()
        {
            teknoloji_ihtiyac.Text = string.Empty;
            teknoloji_model.Text = string.Empty;
            teknoloji_uretim_yili.Text = string.Empty;
            teknoloji_marka.Text = string.Empty;

        }
    }
}
