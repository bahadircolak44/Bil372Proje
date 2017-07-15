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
    public partial class yardimsever2 : Form
    {
        public yardimsever2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");


        private void Form1_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            baglanti.Open();
            string kayit = "SELECT * from kullanici";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }

        private void goto_okulpage(object sender, MouseEventArgs e)
        {
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString(),"Uyarı");
            OkulIhtiyac okul = new OkulIhtiyac();
            this.Hide();
            okul.Show();
        }
    }
}
