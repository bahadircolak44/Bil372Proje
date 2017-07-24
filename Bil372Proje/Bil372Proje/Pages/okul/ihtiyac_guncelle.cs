using Bil372Proje.Pages.okul;
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

namespace Bil372Proje.Pages
{
    public partial class ihtiyac_guncelle : Form
    {
        String kAdi;
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        public ihtiyac_guncelle(String kullaniciAdi)
        {
            InitializeComponent();
            kAdi = kullaniciAdi;
        }

        private void ihtiyac_guncelle_load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {
            string kayit = "SELECT isim,marka,adet from ihtiyac ";

            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            SqlCommand cmd = new SqlCommand("delete from ihtiyac where Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
            con.Close();
            kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            guncelle gun = new guncelle(Id,kAdi);
            this.Hide();
            gun.Show();
        }

       
    }
}
