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
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            SqlDataAdapter sda = new SqlDataAdapter("Select Id From users where username='"+ textBox1.Text+"'and password='"+ textBox2.Text+"'",con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}

/*
 
      if (textBox5.Text.Equals(textBox6.Text))
            {
                SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into users(name,surname,email,username,password,sex)" +
                    " values('"+ textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + checkbox(checkBox1,checkBox2) + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }

    private string checkbox(CheckBox checkBox1, CheckBox checkBox2)
        {
            string control="";
            if (checkBox1.Checked)
            {
                control = checkBox1.Text;
            }
            else if(checkBox2.Checked)
            {
                control = checkBox2.Text;
            }
            return control;
        }
     */
