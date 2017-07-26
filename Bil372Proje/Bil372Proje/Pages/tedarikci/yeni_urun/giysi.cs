using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages.tedarikci.urun_ekleme
{
    public partial class giysi : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        string kAdi;
        public giysi(string k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (!( giysi_beden.Text.Equals(string.Empty) ||
    giysi_cinsiyet.Text.Equals(string.Empty) || giysi_ad.Text.Equals(string.Empty)
    || giysi_marka.Text.Equals(string.Empty) || giysi_kumas.Text.Equals(string.Empty) ||
    giysi_kumas.Text.Equals(string.Empty) ||
    giysi_renk.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("insert into urun(kategori,ad,stok_miktari,fiyat,marka,beden,renk," +
                    "kumas,cinsiyet,tur,yazar,yayin_evi,yayin_yili,olcu,model,uretim_yili)" +
                    "values('giysi',@ad,@stok_miktari,@fiyat,@marka,@beden,@renk,@kumas,@cinsiyet,null,null,null,null,null,null,null)", conn);

                kontrol.Parameters.AddWithValue("@ad", giysi_ad.Text);
                kontrol.Parameters.AddWithValue("@marka", giysi_marka.Text);
                kontrol.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(giysi_stok_miktari.Text));
                kontrol.Parameters.AddWithValue("@fiyat", Convert.ToInt32(giysi_fiyat.Text));
                kontrol.Parameters.AddWithValue("@beden", giysi_beden.Text);
                kontrol.Parameters.AddWithValue("@renk", giysi_renk.Text);
                kontrol.Parameters.AddWithValue("@kumas", giysi_kumas.Text);
                kontrol.Parameters.AddWithValue("@cinsiyet", giysi_cinsiyet.Text);
                kontrol.ExecuteNonQuery();
                conn.Close();
                tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
                this.Hide();
                tedarikci.Show();
                clear();
            }
            else
            {
                MessageBox.Show("Tüm alanların doldurulması gerekmektedir.");
            }
            
        }
        private void clear()
        {
            giysi_ad.Text = string.Empty;
            giysi_stok_miktari.Text = string.Empty;
            giysi_marka.Text = string.Empty;
            giysi_beden.Text = string.Empty;
            giysi_renk.Text = string.Empty;
            giysi_kumas.Text = string.Empty;
            giysi_cinsiyet.Text = string.Empty;
        }

    }
}
