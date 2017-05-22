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
    public partial class Register : Form
    {
        Login login;
        public Register()
        {
            InitializeComponent();
            login = new Login();

        }

        //Back butonuna basıldığında Login sayfasına dönmek için
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(textBox1.Text.Equals(string.Empty) || textBox2.Text.Equals(string.Empty) 
                    || textBox3.Text.Equals(string.Empty) || textBox4.Text.Equals(string.Empty) 
                    || textBox5.Text.Equals(string.Empty) || !(checkBox1.Checked || checkBox2.Checked)))
                {
                    // E-mail in valid olup olmadığına bakıyor
                    if (IsValidEmail(textBox3.Text))
                    { 
                        //Password ların eşitliğini kontrol ediyor
                        if (textBox5.Text.Equals(textBox6.Text))
                        {
                            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into users(name,surname,email,username,password,sex)" +
                            " values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + checkbox(checkBox1, checkBox2) + "')", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration has been completed", "Success");
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show(" Passwords do not match! ", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" E-mail is not valid! ", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled in", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Some problems have been occured", "ERROR");
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        //Checkbox lardan hangisinin seçildiğini kontrol ediyor
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {      
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox1.CheckState = CheckState.Checked;
        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Checked;
        }
    }
}
