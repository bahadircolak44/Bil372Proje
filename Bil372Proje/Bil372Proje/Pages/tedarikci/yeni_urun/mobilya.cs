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
    public partial class mobilya : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        string kAdi;
        public mobilya(string k)
        {
            kAdi = k;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(mobilya_ad.Text.Equals(string.Empty) ||
   mobilya_fiyat.Text.Equals(string.Empty) || mobilya_marka.Text.Equals(string.Empty)
   || mobilya_renk.Text.Equals(string.Empty) || mobilya_stok_miktari.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("insert into urun(kategori,ad,stok_miktari,fiyat,marka,beden,renk," +
                    "kumas,cinsiyet,tur,yazar,yayin_evi,yayin_yili,olcu,model,uretim_yili)" +
                    "values('mobilya',@ad,@stok_miktari,@fiyat,@marka,null,@renk,null,null,null,null,null,null,@olcu,null,null)", conn);

                kontrol.Parameters.AddWithValue("@ad", mobilya_ad.Text);
                kontrol.Parameters.AddWithValue("@marka", mobilya_marka.Text);
                kontrol.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(mobilya_stok_miktari.Text));
                kontrol.Parameters.AddWithValue("@fiyat", Convert.ToInt32(mobilya_fiyat.Text));
                kontrol.Parameters.AddWithValue("@renk", mobilya_renk.Text);
                kontrol.Parameters.AddWithValue("@olcu", mobilya_olcu.Text);
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
            mobilya_ad.Text = string.Empty;
            mobilya_fiyat.Text = string.Empty;
            mobilya_marka.Text = string.Empty;
            mobilya_renk.Text = string.Empty;
            mobilya_stok_miktari.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages(kAdi);
            this.Hide();
            tedarikci.Show();
        }
    }
}
