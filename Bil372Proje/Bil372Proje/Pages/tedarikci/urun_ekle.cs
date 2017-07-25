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

namespace Bil372Proje.Pages.tedarikci
{
    public partial class urun_ekle : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public urun_ekle()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages();
            this.Hide();
            tedarikci.Show();
        
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            if (! ( katagori.Text.Equals(string.Empty) ||ad.Text.Equals(string.Empty) ||
                 marka.Text.Equals(string.Empty) || stok_miktari.Text.Equals(string.Empty) ||
                 fiyat.Text.Equals(string.Empty) )) {
                conn.Open();
                string kayit = "insert into urun(kategori,ad,stok_miktari,fiyat,marka) " +
                    "values(@kategori,@ad,@stok_miktari,@fiyat,@marka)";
                NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
                komut.Parameters.AddWithValue("@kategori", katagori.Text);
                komut.Parameters.AddWithValue("@ad", ad.Text);
                komut.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(stok_miktari.Text));
                komut.Parameters.AddWithValue("@fiyat", Convert.ToInt32(fiyat.Text));
                komut.Parameters.AddWithValue("@marka", marka.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                kayitGetir();
                clear();
            }
            else
            {
                MessageBox.Show("Tüm Alanların Doldurulması Gerekli", "HATA");

            }

            
        }
        private void clear()
        {
            katagori.Text = string.Empty;
            ad.Text = string.Empty;
            stok_miktari.Text = string.Empty;
            fiyat.Text = string.Empty;
            marka.Text = string.Empty;

        }
        private void urun_ekle_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT *  from urun ";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
