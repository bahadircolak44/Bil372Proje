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
                string kayit = "update urun set stok_miktari=@adet where Id=@Id";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@adet", adet.Text);
            }
  
            if (!(fiyat.Text.Equals(string.Empty)))
            {
                string kayit2 = "update urun set fiyat=@fiyat where Id=@Id";
                SqlCommand komut2 = new SqlCommand(kayit2, con);
                komut2.Parameters.AddWithValue("@fiyat", fiyat.Text);
            }

            con.Close();
        }
    }
}
