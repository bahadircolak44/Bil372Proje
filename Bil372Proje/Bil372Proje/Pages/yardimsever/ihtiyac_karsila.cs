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

namespace Bil372Proje.Pages.yardimsever
{
    public partial class ihtiyac_karsila : Form
    {
        int count = 0;
        int price = 0;
        int toplam = 0;
        String kAdi;
        int Id;
        int ihtiyac_id;
        NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");
        public ihtiyac_karsila(String kullaniciAdi, int okul_id)
        {
            InitializeComponent();
            kAdi = kullaniciAdi;
            Id = okul_id;
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
        private void kayitGetir()
        {

            string kayit = "SELECT id,isim,adet,marka,fiyat,tur  from ihtiyac ";

            NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            conn.Close();
        }
        private void listeye_ekle_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            MessageBox.Show(adet.ToString(), toplam.ToString());
            if (adet <= toplam)
            {
                int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ihtiyac_id = Id;
                string isim = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                string marka = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                int fiyat = adet * Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                price += fiyat;
                string tur = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                string[] row = { Id.ToString(), isim, adet.ToString(), marka, fiyat.ToString(), tur };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);
                label2.Text = price.ToString() + " TL";
                if (adet == toplam)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else
                {
                    dataGridView1.CurrentRow.Cells[2].Value = toplam - adet;
                }
            }
            else
            {
                MessageBox.Show("Listede Var Olandan Fazlasını Ekleyemezsiniz", "HATA");
            }
            count++;

        }
        private void button1_Click(object sender, EventArgs e)
        {

            OkulIhtiyac okul = new OkulIhtiyac(Id,kAdi);
            this.Hide();
            okul.Show();
        }
        private void karsila_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ihtiyac_id.ToString());
            conn.Open();
            for (int i = 0; i < count; i++)
            {
                MessageBox.Show(listView1.Items[i].SubItems[5].Text);
                string kayit = "insert into gecmis(okul_id,yardimsever_id,ad,marka,adet,fiyat,tur) values(@okul_id,1,@ad,@marka,@adet,@fiyat,@tur)";
                string kayit2 = "delete from " + listView1.Items[i].SubItems[5].Text + " where ihtiyac_id = @ihtiyac_id";
                string kayit3 = "";
                if (toplam == Convert.ToInt32(listView1.Items[i].SubItems[2].Text))
                {
                    kayit3 = "delete from ihtiyac where id = @ihtiyac_id";
                }
                else
                {
                    int kalanAdet = toplam - Convert.ToInt32(listView1.Items[i].SubItems[2].Text);
                    kayit3 = "update ihtiyac set adet=" + kalanAdet + "  where id = @ihtiyac_id";
                }
                NpgsqlCommand komut = new NpgsqlCommand(kayit, conn);
                NpgsqlCommand komut2 = new NpgsqlCommand(kayit2, conn);
                NpgsqlCommand komut3 = new NpgsqlCommand(kayit3, conn);
                komut.Parameters.AddWithValue("@okul_id", Id);
                komut.Parameters.AddWithValue("@ad", listView1.Items[i].SubItems[1].Text);
                komut.Parameters.AddWithValue("@adet", listView1.Items[i].SubItems[2].Text);
                komut.Parameters.AddWithValue("@marka", listView1.Items[i].SubItems[3].Text);
                komut.Parameters.AddWithValue("@fiyat", listView1.Items[i].SubItems[4].Text);
                komut.Parameters.AddWithValue("@tur", listView1.Items[i].SubItems[5].Text);
                komut.Parameters.AddWithValue("@table", listView1.Items[i].SubItems[5].Text);
                komut2.Parameters.AddWithValue("@ihtiyac_id", ihtiyac_id);
                komut3.Parameters.AddWithValue("@ihtiyac_id", ihtiyac_id);
                komut.ExecuteNonQuery();
                komut2.ExecuteNonQuery();

                komut3.ExecuteNonQuery();
            }
            conn.Close();
            OkulIhtiyac okul = new OkulIhtiyac(Id,kAdi);
            this.Hide();
            okul.Show();
        }
        private void deneme(object sender, DataGridViewCellEventArgs e)
        {
            toplam = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
        }
    }
}
