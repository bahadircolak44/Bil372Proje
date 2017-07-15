using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Bil372Proje.Pages;
using Bil372Proje.Pages.okul;
using Bil372Proje.Pages.admin;
using Bil372Proje.Pages.tedarikci;

namespace Bil372Proje
{
    public partial class Login : Form
    {
        yardimsever1 yardimseverpages;
        okul_pages okulpages ;
        tedarikci_pages tedarikcipages;
        admin_pages admin;
        public Login()
        {
            InitializeComponent();
            yardimseverpages = new yardimsever1();
            okulpages = new okul_pages();
            tedarikcipages = new tedarikci_pages();
            admin = new admin_pages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select yetki from kullanici where kullanici_adi=@kullanici_adi and sifre=@sifre", con);
                cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
               SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int yetki = Convert.ToInt32(cmd.ExecuteScalar()); //yetkiyi burada alıyoruz. dönen degere göre bir sayfaya yönlendirilecek
                con.Close();
                int count = ds.Tables[0].Rows.Count; 

                MessageBox.Show(yetki.ToString(), "uyarı");
                if (count == 1)
                {
                    this.Hide();
                    if (yetki == 1)
                    {
                        yardimseverpages.Show();

                    }else if (yetki==2)
                    {
                        okulpages.Show();

                    }else if (yetki == 3)
                    {
                        tedarikcipages.Show();
                    }
                    else
                    {
                        admin.Show();
                    }
                
                

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
