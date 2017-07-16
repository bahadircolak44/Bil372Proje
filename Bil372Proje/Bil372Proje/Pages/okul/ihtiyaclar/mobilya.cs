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
            SqlCommand komut = new SqlCommand("select max(Id) from mobilya", con);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            count = count + 1;
            SqlCommand cmd = new SqlCommand("insert into mobilya(Id,okul_id,isim,adet,marka,ölcü,renk)" +
                " values(@Id,@okul_id,@isim,@adet,@marka,@olcu,@renk)", con);
            cmd.Parameters.AddWithValue("@isim", mobilya_ihtiyac.Text);
            cmd.Parameters.AddWithValue("@adet", mobilya_adet.Text);
            cmd.Parameters.AddWithValue("@marka", mobilya_marka.Text);
            cmd.Parameters.AddWithValue("@olcu", mobilya_olcu.Text);
            cmd.Parameters.AddWithValue("@renk", mobilya_renk.Text);
            cmd.Parameters.AddWithValue("@Id", count);
            cmd.Parameters.AddWithValue("@okul_id", okul_id);
            cmd.ExecuteNonQuery();
            kayitGetir();
            clear();
        }

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
            
            string kayit = "SELECT m.isim,m.adet,m.marka" +
                " from mobilya m where m.okul_id =@okul_id";

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