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
    public partial class guncelle : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        int urun_Id;
        public guncelle(int Id)
        {
            urun_Id = Id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            if (!(adet.Text.Equals(string.Empty)))
            {
                int value;
                if (int.TryParse(adet.Text, out value))
                {
                    string kayit = "update urun set stok_miktari=@adet where Id=@Id";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@adet", adet.Text);
                    komut.Parameters.AddWithValue("@Id", urun_Id);
                    komut.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Adete tam sayı girmelisiniz!");
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Adeti boş bırakamazsınız!");
                con.Close();
                return;
            }

            if (!(fiyat.Text.Equals(string.Empty)))
            {
                int value;
                if (int.TryParse(fiyat.Text, out value))
                {
                    string kayit2 = "update urun set fiyat=@fiyat where Id=@Id";
                    SqlCommand komut2 = new SqlCommand(kayit2, con);
                    komut2.Parameters.AddWithValue("@fiyat", fiyat.Text);
                    komut2.Parameters.AddWithValue("@Id", urun_Id);
                    komut2.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Fiyata tam sayı girmelisiniz!");
                    con.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fiyatı boş bırakamazsınız!");
                con.Close();
                return;
            }

            con.Close();
            urun_guncelle guncelle = new urun_guncelle();
            this.Hide();
            guncelle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            urun_guncelle guncelle = new urun_guncelle();
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
