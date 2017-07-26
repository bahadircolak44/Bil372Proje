using Npgsql;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bil372Proje.Pages.tedarikci
{
    public partial class guncelle : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        int urun_Id;
        String kAdi;
        public guncelle(int Id, string k)
        {
            urun_Id = Id;
            kAdi = k;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (!(adet.Text.Equals(string.Empty)))
            {
                string kayit = "update urun set stok_miktari=@adet where Id=@Id";
                NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
                komut.Parameters.AddWithValue("@adet", Convert.ToInt32(adet.Text));
                komut.Parameters.AddWithValue("@Id", urun_Id);
                komut.ExecuteNonQuery();
            }
  
            if (!(fiyat.Text.Equals(string.Empty)))
            {
                string kayit2 = "update urun set fiyat=@fiyat where Id=@Id";
                NpgsqlCommand komut2 = new NpgsqlCommand(kayit2, conn);
                komut2.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat.Text));
                komut2.Parameters.AddWithValue("@Id", urun_Id);
                komut2.ExecuteNonQuery();
            }

            conn.Close();
            urun_guncelle guncelle = new urun_guncelle(kAdi);
            this.Hide();
            guncelle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urun_guncelle guncelle = new urun_guncelle(kAdi);
            this.Hide();
            guncelle.Show();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {

        }

        private void adet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fiyat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
