using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bil372Proje.Pages.okul
{
    public partial class guncelle : Form
    {
        int u_id;
        String kAdi;
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public guncelle(int Id, String kadi)
        {
            u_id = Id;
            kAdi = kadi;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            con.Open();

            if (!(adet.Text.Equals(string.Empty)))
            {
               
                int value;
                if (int.TryParse(adet.Text, out value)) { /*Operate*/
                    string kayit = "update ihtiyac set adet=@adet where Id=@Id";
                    SqlCommand komut = new SqlCommand(kayit, con);
                    komut.Parameters.AddWithValue("@adet", adet.Text);
                    komut.Parameters.AddWithValue("@Id", u_id.ToString());
                    komut.ExecuteNonQuery();

                }
                else
                {
                    MessageBox.Show("Adete tam sayı girmelisiniz!");
                    con.Close();
                    return;
                }
               
            }else
            {
                MessageBox.Show("Adeti boş bırakamazsınız!");
                con.Close();
                return;
            }

            if (!(fiyat.Text.Equals(string.Empty)))
            {
                int value;
                if (int.TryParse(fiyat.Text, out value)) {
                    string kayit2 = "update ihtiyac set fiyat=@fiyat where Id=@Id";
                    SqlCommand komut2 = new SqlCommand(kayit2, con);
                    komut2.Parameters.AddWithValue("@fiyat", fiyat.Text);
                    komut2.Parameters.AddWithValue("@Id", u_id.ToString());
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
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();
        }
    }
}
