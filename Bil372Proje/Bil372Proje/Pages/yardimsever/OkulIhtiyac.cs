﻿using Bil372Proje.Pages.yardimsever;
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

namespace Bil372Proje.Pages
{
    public partial class OkulIhtiyac : Form
    {
        int okul_id;
        public string kullanici_adi;
        public OkulIhtiyac(int Id, string kAdi)
        {
            kullanici_adi = kAdi;
            okul_id = Id;
            //Yardimsever2 den sonra bu sayfaya gelinir seçilen okulun ihtiyaçlarını listeler
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kayitGetir()
        {
            con.Open();
            string kayit = "select isim,adet,tur from ihtiyac where okul_id=@okul_id";
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

        private void Okul_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void Geri_Click(object sender, EventArgs e)
        {
            yardimsever2 ys2 = new yardimsever2(kullanici_adi);
            this.Hide();
            ys2.Show();
        }

        private void para_bagisla_Click(object sender, EventArgs e)
        {
            para_bagisla bagisla = new para_bagisla(okul_id,kullanici_adi);
            this.Hide();
            bagisla.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ihtiyac_karsila karsila = new ihtiyac_karsila(kullanici_adi, okul_id);
            this.Hide();
            karsila.Show();
        }
    }
}
