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

namespace Bil372Proje.Pages.yardimsever
{
    public partial class para_yukle : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
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
            conn.Open();
            string kayit1 = "select bakiye from yardimsever where kAdi=@kullanici_adi ";
            NpgsqlCommand komut1 = new NpgsqlCommand(kayit1, conn);
            komut1.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);

            string kayit = "update yardimsever set bakiye=@bakiye where kAdi=@kullanici_adi";
            
            int bakiye1 = Convert.ToInt32(komut1.ExecuteScalar());
            if (miktar.Text == "")
            {
                MessageBox.Show("Miktarı boş bırakamazsınız!");
                conn.Close();
                return ;
            }

            int bakiye2 = bakiye1 + Convert.ToInt32(miktar.Text);
            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);

            komut.Parameters.AddWithValue("@kullanici_adi", kullanici_adi);
            komut.Parameters.AddWithValue("@bakiye", bakiye2);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("İşleminiz Başarıyla Gerçekleşmiştir");
            yardimsever1 y1 = new yardimsever1(kullanici_adi);
            this.Hide();
            y1.Show();
        }
    }
}
