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

namespace Bil372Proje.Pages.okul
{
    public partial class ihtiyac_karsila : Form
    {
        String kAdi;
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");

        public ihtiyac_karsila(String kullaniciAdi)
        {
            InitializeComponent();
            kAdi = kullaniciAdi;
        }

        private void ihtiyac_karsila_Load(object sender, EventArgs e)
        {
            kayitGetir();

        }

        private void listeye_ekle_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string adet = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string marka = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int fiyat = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            string tur = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string[] row = { Id.ToString(),isim,adet,marka,fiyat.ToString(),tur};
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            okul_pages okul = new okul_pages(kAdi);
            this.Hide();
            okul.Show();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT id,isim,adet,marka,fiyat,tur  from ihtiyac ";

            SqlCommand komut = new SqlCommand(kayit, con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
