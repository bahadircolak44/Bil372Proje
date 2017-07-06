using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Bil372Proje.Pages;

namespace Bil372Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From yardimsever as y,okul as o,tedarikci as t,admin as a where " +
                "y.kullanici_adi='"+ textBox1.Text+"'and y.password='"+ textBox2.Text+ "' " +
                "or o.kullanici_adi='" + textBox1.Text + "'and o.password='" + textBox2.Text + "'" +
                "or t.kullanici_adi='" + textBox1.Text + "'and t.password='" + textBox2.Text + "' " +
                "or a.kullanici_adi='" + textBox1.Text + "'and a.password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
            }
            catch
            {
                MessageBox.Show("Some Problems Have Been Occured","ERROR");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}

/*
 
    

    
     */
