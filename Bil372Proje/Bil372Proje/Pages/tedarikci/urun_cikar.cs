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
    public partial class urun_cikar : Form
    {
        SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
        public urun_cikar()
        {
            InitializeComponent();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            tedarikci_pages tedarikci = new tedarikci_pages();
            this.Hide();
            tedarikci.Show();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            con.Open();
            string Id = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            SqlCommand cmd = new SqlCommand("delete urun where Id=@Id",con);
            cmd.Parameters.AddWithValue("@Id",Id);
            cmd.ExecuteNonQuery();
            con.Close();
            kayitGetir();
        }
        private void kayitGetir()
        {

            string kayit = "SELECT *  from urun ";

            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            SqlCommand komut = new SqlCommand(kayit, con);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            con.Close();
        }

        private void urun_cikar_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
