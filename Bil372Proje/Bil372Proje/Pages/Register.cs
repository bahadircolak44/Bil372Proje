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
                    if (sifre.Text.Length<6)
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
                            MessageBox.Show("Kayıt Başarılı", "BAŞARILI");
                            this.Hide();
                            login.Show();

                        }
                        else
                        {
                            MessageBox.Show(" Şifreler Eşleşmiyor! ", "HATA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lüften Geçerli Bir E-mail Adresi Girin! ", "HATA");
                    }

                }
                else
                {
                    MessageBox.Show("Şifre En Az 6 Haneli Olmalıdır ", "HATA");
                }
            }
                else
                {
                    MessageBox.Show("Tüm Alanların Doldurulması Gerekli", "HATA");
                }
            }
            catch
            {
                MessageBox.Show("Bir Şeyler Ters Gitti", "HATA");
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
                if (!(okul_adi.Text.Equals(string.Empty) || il.Text.Equals(string.Empty)
                || ilce.Text.Equals(string.Empty) || okul_adres.Text.Equals(string.Empty)
                || okul_email.Text.Equals(string.Empty) || okul_kullanici_adi.Text.Equals(string.Empty) 
                || okul_sifre.Text.Equals(string.Empty)|| okul_sifre.Text.Equals(string.Empty)))
                {
                    if (okul_sifre.TextLength<6)
                    {
                        //E-mail in valid olup olmadığına bakıyor
                        if (IsValidEmail(okul_email.Text))
                        {
                            //Şifrelerin uyuşup uyuşmadığını kontrol ediyor.
                            if (okul_sifre.Text.Equals(okul_sifre_tekrar.Text))
                            {
                                //Database sistemi oluşturulduktan sonra
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into okul(okul_id,okul_adi,il,ilce,kullanci_adi,sifre,email,adres,tel,yetki,bakiye,valid)" +
                                " values(5,'" + okul_adi.Text + "','" + il.Text + "','" + ilce.Text + "','" + okul_kullanici_adi.Text + "'," +
                                " '" + okul_sifre.Text + "','" + okul_email.Text + "','" + okul_adres.Text + "','123123','okul',0,0)", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Kaydınız Alınmıştır. Kontrol Sonrası Bilgilendirileceksiniz", "BAŞARILI");
                                this.Hide();
                                login.Show();
                            }
                            else
                            {
                                MessageBox.Show(" Şifreler Eşleşmiyor ", "HATA");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Lüften Geçerli Bir E-mail Adresi Girin! ", "HATA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifre En Az 6 Haneli Olmalıdır ", "HATA");
                    }
                }
                else
                {
                    MessageBox.Show("Tüm Alanların Doldurulması Gerekli", "HATA");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString(), "HATA");
            }
        }

        private void tedarikci_kayit_Click(object sender, EventArgs e)
        {

        }
    }
}
