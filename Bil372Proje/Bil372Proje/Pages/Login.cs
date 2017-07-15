using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Bil372Proje.Pages;
using Bil372Proje.Pages.okul;

namespace Bil372Proje
{
    public partial class Login : Form
    {
        yardimsever1 y1;
        okul_ekrani oe ;
        public Login()
        {
            InitializeComponent();
             y1 = new yardimsever1();
             oe = new okul_ekrani();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            SqlCommand cmd = new SqlCommand("Select * from kullanici where kullanici_adi=@kullanici_adi and sifre=@sifre", con);
                cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
            {
                
                this.Hide();
                oe.Show();

            }
            else
            {
                MessageBox.Show("Yanlış");
            }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(),"ERROR");
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
