﻿using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    public partial class kitap : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public string kAdi;
        public int okul_id;
        public kitap(string kullanici, int Id)
        {
            kAdi = kullanici;
            okul_id = Id;
            InitializeComponent();
        }

        private int fiyatHesapla(string ad, string tur, string yayin_evi, string yazar, string yayin_yili)
        {
          
            NpgsqlCommand cmd = new NpgsqlCommand("select fiyat from urun where ad=@ad and  tur = @tur and yayin_evi = @yayin_evi and yazar = @yazar and yayin_yili = @yayin_yili", conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            cmd.Parameters.AddWithValue("@tur", tur);
            cmd.Parameters.AddWithValue("@yayin_evi", yayin_evi);
            cmd.Parameters.AddWithValue("@yazar", yazar);
            cmd.Parameters.AddWithValue("@yayin_yili", yayin_yili);
            int fiyat = Convert.ToInt32(cmd.ExecuteScalar());
            return fiyat;

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
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("select adet from ihtiyac where isim=@isim", conn);
                NpgsqlCommand kontrol2 = new NpgsqlCommand("select ihtiyac_id from kitap where tur=@tur and yayin_evi=@yayin_evi and yazar=@yazar and yayin_yili=@yayin_yili", conn);

                kontrol.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);

                kontrol2.Parameters.AddWithValue("@tur", kitap_tur.Text);
                kontrol2.Parameters.AddWithValue("@yayin_evi", kitap_yayin_evi.Text);
                kontrol2.Parameters.AddWithValue("@yazar", kitap_yazar.Text);
                kontrol2.Parameters.AddWithValue("@yayin_yili", kitap_yayin_yili.Text);

                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(kontrol);
                NpgsqlDataAdapter adapt2 = new NpgsqlDataAdapter(kontrol2);
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                adapt.Fill(ds);
                adapt2.Fill(ds2);

                int i = ds.Tables[0].Rows.Count;
                int j = ds2.Tables[0].Rows.Count;

                if (i > 0 && j > 0)
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim and Id=@Id", conn);
                    NpgsqlCommand cmd3 = new NpgsqlCommand("Update ihtiyac set fiyat=@fiyat Where isim = @isim and Id=@Id", conn);
                   
                    int cnt = Convert.ToInt32(kontrol.ExecuteScalar()) + Convert.ToInt32(kitap_adet.Text.Trim());
                    int cnt2 = Convert.ToInt32(kontrol2.ExecuteScalar());
                    int fiyat = cnt * (fiyatHesapla(kitap_ihtiyac.Text,kitap_tur.Text,kitap_yayin_evi.Text,kitap_yazar.Text,kitap_yayin_yili.Text));

                    cmd.Parameters.AddWithValue("@Adet", cnt);
                    cmd.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@Id", cnt2);

                    cmd3.Parameters.AddWithValue("@Id", cnt2);
                    cmd3.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);
                    cmd3.Parameters.AddWithValue("@fiyat", fiyat);

                    cmd.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                }
                else
                {
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into ihtiyac(okul_id,isim,adet,marka,fiyat,tur)" +
        " values(@okul_id,@isim,@adet,@marka,@fiyat,'kitap')", conn);
                    cmd.Parameters.AddWithValue("@isim", kitap_ihtiyac.Text);
                    cmd.Parameters.AddWithValue("@adet", Convert.ToInt32(kitap_adet.Text));
                    cmd.Parameters.AddWithValue("@marka", string.Empty);
                    cmd.Parameters.AddWithValue("@okul_id", okul_id);
                    int fiyat = Convert.ToInt32(kitap_adet.Text) * (fiyatHesapla(kitap_ihtiyac.Text, kitap_tur.Text, kitap_yayin_evi.Text, kitap_yazar.Text, kitap_yayin_yili.Text));
                    cmd.Parameters.AddWithValue("@fiyat", fiyat);
                    cmd.ExecuteNonQuery();
                }



                NpgsqlCommand komut = new NpgsqlCommand("select max(id) from ihtiyac", conn);
                int count = Convert.ToInt32(komut.ExecuteScalar());
                NpgsqlCommand cmd2 = new NpgsqlCommand("insert into kitap(ihtiyac_id,tur,yazar,yayin_evi,yayin_yili)" +
                " values(@ihtiyac_id,@tur,@yazar,@yayin_evi,@yayin_yili)", conn);
                cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
                cmd2.Parameters.AddWithValue("@tur", kitap_tur.Text);
                cmd2.Parameters.AddWithValue("@yazar", kitap_yazar.Text);
                cmd2.Parameters.AddWithValue("@yayin_evi", kitap_yayin_evi.Text);
                cmd2.Parameters.AddWithValue("@yayin_yili", kitap_yayin_yili.Text);
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

        private void kitap_Load(object sender, EventArgs e)
        {
            comboboxGetir();
            kayitGetir();
            label7.Text = totalfiyatgetir() + " TL";
        }

        private void comboboxGetir()
        {
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.CommandText = "SELECT * FROM urun where kategori = @kategori";
            komut.Parameters.AddWithValue("@kategori", "kitap");
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;

            NpgsqlDataReader dr;
            conn.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kitap_ihtiyac.Items.Add(dr["ad"]);
                kitap_tur.Items.Add(dr["tur"]);
                kitap_yazar.Items.Add(dr["yazar"]);
                kitap_yayin_evi.Items.Add(dr["yayin_evi"]);
                kitap_yayin_yili.Items.Add(dr["yayin_yili"]);

            }
            conn.Close();
        }
    }
}
