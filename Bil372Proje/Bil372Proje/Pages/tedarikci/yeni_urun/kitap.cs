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
    public partial class kitap : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        string kAdi;
        public kitap(string k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (!(kitap_adi.Text.Equals(string.Empty) ||
   kitap_fiyat.Text.Equals(string.Empty) || kitap_stok.Text.Equals(string.Empty)
   || kitap_tur.Text.Equals(string.Empty) || kitap_yayin_evi.Text.Equals(string.Empty) 
   || kitap_yayin_yili.Text.Equals(string.Empty) || kitap_yazar.Text.Equals(string.Empty)))
            {
                conn.Open();
                NpgsqlCommand kontrol = new NpgsqlCommand("insert into urun(kategori,ad,stok_miktari,fiyat,marka,beden,renk," +
                    "kumas,cinsiyet,tur,yazar,yayin_evi,yayin_yili,olcu,model,uretim_yili)" +
                    "values('kitap',@ad,@stok_miktari,@fiyat,'',null,null,null,null,null,null,null,null,null,null,null)", conn);

                kontrol.Parameters.AddWithValue("@ad", kitap_adi.Text);
                kontrol.Parameters.AddWithValue("@stok_miktari", Convert.ToInt32(kitap_stok.Text));
                kontrol.Parameters.AddWithValue("@fiyat", Convert.ToInt32(kitap_fiyat.Text));
                kontrol.Parameters.AddWithValue("@kitap_tur", kitap_tur.Text);
                kontrol.Parameters.AddWithValue("@kitap_yayin_evi", kitap_yayin_evi.Text);
                kontrol.Parameters.AddWithValue("@kitap_yayin_yili", kitap_yayin_yili.Text);
                kontrol.Parameters.AddWithValue("@kitap_yazar", kitap_yazar.Text);

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
            kitap_adi.Text = string.Empty;
            kitap_stok.Text = string.Empty;
            kitap_fiyat.Text = string.Empty;
            kitap_tur.Text = string.Empty;
            kitap_yayin_evi.Text = string.Empty;
            kitap_yazar.Text = string.Empty;
        }

        private void kitap_Load(object sender, EventArgs e)
        {

        }
    }
}
