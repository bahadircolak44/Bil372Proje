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
        int count = 0;
        int price =0;
        int toplam=0;
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
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("ID");
            listView1.Columns.Add("İSİM");
            listView1.Columns.Add("Adet");
            listView1.Columns.Add("MARKA");
            listView1.Columns.Add("FİYAT");
            listView1.Columns.Add("TÜR");
           // listView1.Items.Count();
        }

        private void listeye_ekle_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            if (adet <= toplam)
            {
            int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string marka = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int fiyat = adet*Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            price += fiyat;
            string tur = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string[] row = {Id.ToString(),isim,adet.ToString(),marka,fiyat.ToString(),tur};
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);
            label2.Text = price.ToString();
            if (adet == toplam)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                dataGridView1.CurrentRow.Cells[2].Value = toplam-adet;
            }
            }
            else
            {
                MessageBox.Show("Listede Var Olandan Fazlasını Ekleyemezsiniz","HATA");
            }
            count++;

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

        private void karsila_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < count; i++)
            {
                string kayit = "insert into gecmis(okul_id,yardimsever_id,ad,marka,adet,fiyat) values(@okul_id,null,@ad,@marka,@adet,@fiyat)";
                SqlCommand komut = new SqlCommand(kayit, con);
                //komut.Parameters.AddWithValue("@okul_id");
                string x = listView1.Items[i].SubItems[0].Text;
                MessageBox.Show(x);
            }

        }

        private void deneme(object sender, DataGridViewCellEventArgs e)
        {
            toplam = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
