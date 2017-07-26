using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Bil372Proje.Pages;
using Bil372Proje.Pages.okul;
using Bil372Proje.Pages.admin;
using Bil372Proje.Pages.tedarikci;
using Npgsql;

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
                NpgsqlConnection conn = new NpgsqlConnection("Server=bil372db.postgres.database.azure.com;Database=bil372;Port=5432;User Id=bahadir@bil372db;Password=Qwerty123;");

                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Select yetki from kullanici where kullanici_adi=@kullanici_adi and sifre=@sifre", conn);
                cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
                NpgsqlDataAdapter adapt = new NpgsqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                int yetki = Convert.ToInt32(cmd.ExecuteScalar()); //yetkiyi burada alıyoruz. dönen degere göre bir sayfaya yönlendirilecek
                conn.Close();
                int count = ds.Tables[0].Rows.Count; 

                if (count == 1)
                {
                    this.Hide();
                    if (yetki == 1)
                    {
                        yardimsever1 yardimseverpages = new yardimsever1(kullanici_adi.Text);
                        this.Hide();
                        yardimseverpages.Show();
                        

                    }
                    else if (yetki==2)
                    {
                        conn.Open();
                        NpgsqlCommand cmd2 = new NpgsqlCommand("Select valid from okul where kAdi=@kullanici_adi", conn);
                        cmd2.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                        int valid = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (valid == 1)
                        {
                            okul_pages okulpages = new okul_pages(kullanici_adi.Text);
                            this.Hide();
                            okulpages.Show();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kaydınız henüz onaylanmamıştır");
                            conn.Close();
                            Login login = new Login();
                            login.Show();
                        }


                    }else if (yetki == 3)
                    {
                        conn.Open();
                        NpgsqlCommand cmd2 = new NpgsqlCommand("Select valid from tedarikci where kAdi=@kullanici_adi", conn);
                        cmd2.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                        int valid = Convert.ToInt32(cmd2.ExecuteScalar());
                        if (valid == 1)
                        {
                            tedarikci_pages tedarikci = new tedarikci_pages(kullanici_adi.Text);
                            this.Hide();
                            tedarikci.Show();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Kaydınız henüz onaylanmamıştır");
                            conn.Close();
                            Login login = new Login();
                            login.Show();
                        }

                    }
                    else
                    {
                        admin_pages admin = new admin_pages();

                        this.Hide();
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
