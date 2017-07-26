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
    public partial class teknoloji : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        string kAdi;
        public teknoloji(string k)
        {
            kAdi = k;
            InitializeComponent();
        }


        private void ekle_Click(object sender, EventArgs e)
        {
            if (!(teknoloji_adi.Text.Equals(string.Empty) ||
teknoloji_fiyat.Text.Equals(string.Empty) || teknoloji_model.Text.Equals(string.Empty)
|| teknoloji_model.Text.Equals(string.Empty) || teknoloji_renk.Text.Equals(string.Empty)
|| teknoloji_renk.Text.Equals(string.Empty) || teknoloji_stok.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("insert into urun(kategori,ad,stok_miktari,fiyat,marka,beden,renk," +
                    "kumas,cinsiyet,tur,yazar,yayin_evi,yayin_yili,olcu,model,uretim_yili)" +
                    "values('teknoloji',@ad,@stok_miktari,@fiyat,@marka,null,@renk,null,null,null,null,null,null,null,@model,@uretim_yili)", conn);

                kontrol.Parameters.AddWithValue("@ad", teknoloji_adi.Text);
                kontrol.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(teknoloji_stok.Text));
                kontrol.Parameters.AddWithValue("@fiyat", Convert.ToInt32(teknoloji_fiyat.Text));
                kontrol.Parameters.AddWithValue("@marka", teknoloji_marka.Text);
                kontrol.Parameters.AddWithValue("@model", teknoloji_model.Text);
                kontrol.Parameters.AddWithValue("@renk", teknoloji_renk.Text);
                kontrol.Parameters.AddWithValue("@uretim_yili", tekno_uretim_yili.Text);

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
            teknoloji_adi.Text = string.Empty;
            teknoloji_fiyat.Text = string.Empty;
            teknoloji_marka.Text = string.Empty;
            teknoloji_model.Text = string.Empty;
            teknoloji_renk.Text = string.Empty;
            teknoloji_stok.Text = string.Empty;
            tekno_uretim_yili.Text = string.Empty;
        }

        private void geri_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        }
    }
}
