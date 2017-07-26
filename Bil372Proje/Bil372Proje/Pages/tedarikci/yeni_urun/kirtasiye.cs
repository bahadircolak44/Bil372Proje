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

namespace Bil372Proje.Pages.tedarikci.yeni_urun
{
    public partial class kirtasiye : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        string kAdi;
        public kirtasiye(string k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (!(kirtasiye_fiyat.Text.Equals(string.Empty) ||
    kirtasiye_marka.Text.Equals(string.Empty) || kirtasiye_renk.Text.Equals(string.Empty)
    || kirtasiye_stok.Text.Equals(string.Empty) || kirtasiye_ad.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("insert into urun(kategori,ad,stok_miktari,fiyat,marka,beden,renk," +
                    "kumas,cinsiyet,tur,yazar,yayin_evi,yayin_yili,olcu,model,uretim_yili)" +
                    "values('kirtasiye',@ad,@stok_miktari,@fiyat,@marka,null,@renk,null,'kız/erkek',null,null,null,null,null,null,null)", conn);

                kontrol.Parameters.AddWithValue("@ad", kirtasiye_ad.Text);
                kontrol.Parameters.AddWithValue("@marka", kirtasiye_marka.Text);
                kontrol.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(kirtasiye_stok.Text));
                kontrol.Parameters.AddWithValue("@fiyat", Convert.ToInt32(kirtasiye_fiyat.Text));
                kontrol.Parameters.AddWithValue("@renk", kirtasiye_renk.Text);

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
            kirtasiye_ad.Text = string.Empty;
            kirtasiye_fiyat.Text = string.Empty;
            kirtasiye_marka.Text = string.Empty;
            kirtasiye_renk.Text = string.Empty;
            kirtasiye_stok.Text = string.Empty;

        }

        private void geri_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        }
    }
}
