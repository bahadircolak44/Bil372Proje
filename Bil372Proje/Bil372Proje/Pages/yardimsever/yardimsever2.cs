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

namespace Bil372Proje.Pages
{
    public partial class yardimsever2 : Form
    {
        public string kullanici_adi;
        public yardimsever2(string kAdi)
        {
            kullanici_adi = kAdi;
            // Okul Arama Sayfasıdır.
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");


        private void Form1_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT kullanici_adi,il,ilce,telefon from kullanici where yetki =2";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void goto_okulpage(object sender, MouseEventArgs e)
        {
            baglanti.Open();
            string kullaniciAdi = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("select Id from okul where kAdi=@kullanici_adi" , baglanti);
            cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);
            int Id= Convert.ToInt32(cmd.ExecuteScalar());
            OkulIhtiyac okul = new OkulIhtiyac(Id,kullanici_adi);
            this.Hide();
            okul.Show();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
        }
    }
}
