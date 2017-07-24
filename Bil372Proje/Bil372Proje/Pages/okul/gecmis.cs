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
    public partial class gecmis : Form
    {

        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        String kAdi;
        public gecmis(String k)
        {
            kAdi = k;
            InitializeComponent();
        }

        private void gecmis_Load(object sender, EventArgs e)
        {

            label2.Text = kayitGetir() + " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            okul_pages ie = new okul_pages(kAdi);
            this.Hide();
            ie.Show();
        }
        private string kayitGetir()
        {
            con.Open();
            string kayit = "SELECT SUM(fiyat) " +
                          " from gecmis";

            string kayit2 = "SELECT * " +
                          " from gecmis";

            SqlCommand komut2 = new SqlCommand(kayit, con);
            SqlCommand komut = new SqlCommand(kayit2, con);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            var total = komut2.ExecuteScalar().ToString();

            con.Close();

            return total;
        }
    }
}
