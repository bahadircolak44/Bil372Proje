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
using Npgsql;

namespace Bil372Proje.Pages.okul
{
    public partial class gecmis : Form
    {

        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
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
            conn.Open();
            string kayit = "SELECT SUM(fiyat) " +
                          " from gecmis";

            string kayit2 = "SELECT * " +
                          " from gecmis";

            NpgsqlCommand komut2 = new NpgsqlCommand(kayit, conn);
            NpgsqlCommand komut = new NpgsqlCommand(kayit2, conn);

            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            var total = komut2.ExecuteScalar().ToString();

            conn.Close();

            return total;
        }
    }
}
