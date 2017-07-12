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
            Prepare pr;
            try
            {
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From kullanici  where " +
                "kullanici_adi='" + kullanici_adi.Text+ "'and sifre='" + sifre.Text+ "') ", con);
            DataTable dt = new DataTable();
           
              //  if (dt.TableName.Equals("okul")) { MessageBox.Show("1111111111"); }
            if (dt.Rows.Count >= 1)
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
