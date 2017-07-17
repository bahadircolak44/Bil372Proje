﻿using System;
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

    public partial class kirtasiye : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kAdi;
        public int okul_id;
        public kirtasiye(string kullanici,int Id)
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
        /*kirtasiye tablosunda ki en büyük Id bulunur.
         *insert into ile ara yüzden alınan ihtiyaçlar önce veri tabanına sonra datagridviewe eklenir         *
         */
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand kontrol = new SqlCommand("select adet from ihtiyac where isim=@isim", con);
            kontrol.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
            SqlDataAdapter adapt = new SqlDataAdapter(kontrol);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                SqlCommand cmd = new SqlCommand("Update ihtiyac set adet=@Adet Where isim = @isim", con);
                int cnt = Convert.ToInt32(kontrol.ExecuteScalar())+Convert.ToInt32(kirtasiye_adet.Text.Trim());
                MessageBox.Show(cnt.ToString());
                cmd.Parameters.AddWithValue("@Adet", cnt);
                cmd.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into ihtiyac(okul_id,isim,adet,marka)" +
    " values(@okul_id,@isim,@adet,@marka)", con);
                cmd.Parameters.AddWithValue("@isim", kirtasiye_ihtiyac.Text);
                cmd.Parameters.AddWithValue("@adet", kirtasiye_adet.Text);
                cmd.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
                cmd.Parameters.AddWithValue("@okul_id", okul_id);
                cmd.ExecuteNonQuery();
            }



            SqlCommand komut = new SqlCommand("select max(id) from ihtiyac", con);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            SqlCommand cmd2 = new SqlCommand("insert into kirtasiye(ihtiyac_id)" +
            " values(@ihtiyac_id)", con);
            cmd2.Parameters.AddWithValue("@ihtiyac_id", count);
            cmd2.ExecuteNonQuery();
            kayitGetir();
            clear();
        }
        private void clear()
        {
            kirtasiye_ihtiyac.Text = string.Empty;
            kirtasiye_adet.Text = string.Empty;
            kirtasiye_marka.Text = string.Empty;
            
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

        private void kirtasiye_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
