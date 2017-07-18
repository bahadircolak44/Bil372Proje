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

namespace Bil372Proje.Pages.yardimsever
{
    public partial class para_yukle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public string kullanici_adi;
        public para_yukle(string kAdi)
        {
            kullanici_adi = kAdi;

            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
        }

        private void bakiye_yukle_Click(object sender, EventArgs e)
        {
            kayiitGuncelle();
        }
        private void kayiitGuncelle()
        {
            con.Open();
            string kayit = "update yardimsever set bakiye=bakiye+@bakiye where kAdi=@kullanici_adi";


            SqlCommand komut = new SqlCommand(kayit, con);
            komut.Parameters.AddWithValue("@bakiye", miktar.Text);
            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir");
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
        }
    }
}
