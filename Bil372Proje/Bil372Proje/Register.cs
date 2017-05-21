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

namespace Bil372Proje
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Equals(textBox4.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users(email,username,password) values('"+ textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
        }
    }
}
