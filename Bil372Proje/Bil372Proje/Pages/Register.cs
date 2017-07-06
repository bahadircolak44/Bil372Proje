﻿using System;
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
        SqlConnection con;
        public Register()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            login = new Login();

        }

        //Back butonuna basıldığında Login sayfasına dönmek için
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        //Kullanıcı kayıt ekranında register düğmesine bastığında yapılacak olan
         private void button5_Click(object sender, EventArgs e)
        {
            try
            { 
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(Ad.Text.Equals(string.Empty) || soyAd.Text.Equals(string.Empty) 
                    || email.Text.Equals(string.Empty) || kullanici_adi.Text.Equals(string.Empty) 
                    || sifre.Text.Equals(string.Empty) || sifre_tekrar.Text.Equals(string.Empty) 
                    || yas.Text.Equals(string.Empty) || adress.Text.Equals(string.Empty) || tel.Text.Equals(string.Empty)
                    || !(checkBox1.Checked || checkBox2.Checked)))
                {
                    // E-mail in valid olup olmadığına bakıyor
                    if (IsValidEmail(email.Text))
                    { 
                        //Password ların eşitliğini kontrol ediyor
                        if (sifre.Text.Equals(sifre_tekrar.Text))
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into yardimsever(ad,soyad,cinsiyet,email,kullanci_adi,sifre,yas,adres,tel,yetki,bakiye)" +
                            " values('" + Ad.Text + "','" + soyAd.Text + "' ,'" + checkbox(checkBox1, checkBox2) + "'" +
                            ",'" + email.Text + "','" + kullanici_adi.Text + "','" + sifre.Text + "','" + yas.Text + "'" +
                            ",'" + adress.Text + "','" + tel.Text + "',' yardimsever',0)", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration Has Been Completed", "Success");
                            this.Hide();
                            login.Show();
                           
                        }
                        else
                        {
                            MessageBox.Show(" Passwords Do Not Match! ", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" E-mail Is Not Valid! ", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("All Fields Must be Filled In", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show(e.ToString(), "ERROR");
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

        //Bu iki fonksiyon da checkboxlardan tek seferde bir tanesinin seçilmesini sağlar
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
        //Okul kayıt ekranında back tuşuna basıldığında login ekranına geri dönmeyi sağlar
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }

        //Okul kayıt ekranında register düğmesine bastığında yapılacak olan
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(textBox7.Text.Equals(string.Empty) || textBox8.Text.Equals(string.Empty)
                || textBox9.Text.Equals(string.Empty) || textBox10.Text.Equals(string.Empty)
                || textBox11.Text.Equals(string.Empty) || textBox12.Text.Equals(string.Empty) 
                || textBox12.Text.Equals(string.Empty) || textBox13.Text.Equals(string.Empty) 
                || textBox13.Text.Equals(string.Empty)))
                {
                    //E-mail in valid olup olmadığına bakıyor
                    if (IsValidEmail(email.Text))
                    {
                        //Şifrelerin uyuşup uyuşmadığını kontrol ediyor.
                        if (textBox13.Text.Equals(textBox14.Text))
                        {
                            //Database sistemi oluşturulduktan sonra
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into users(name,surname,email,username,password,sex)" +
                            " values('" + Ad.Text + "','" + soyAd.Text + "','" + email.Text + "','" + kullanici_adi.Text + "','" + sifre.Text + "','" + checkbox(checkBox1, checkBox2) + "')", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration Has Been Completed", "Success");
                            this.Hide();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show(" Passwords Do Not Match! ", "ERROR");
                        }

                    }
                    else
                    {
                        MessageBox.Show(" E-mail Is Not Valid! ", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("All Fields Must be Filled In", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Some Problems Have Been Occured", "ERROR");
            }
        }

        
    }
}
