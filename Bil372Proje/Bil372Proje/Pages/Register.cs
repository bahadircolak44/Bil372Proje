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
        /*
         * NOT: Yetkilendirmeler: 
         *  Yardimsever =1 
         *  Okul =2
         *  Tedarikci =3 şeklinde olacak
         */
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
         private void yardimsever_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(Ad.Text.Equals(string.Empty) || soyAd.Text.Equals(string.Empty)
                    || email.Text.Equals(string.Empty) || kullanici_adi.Text.Equals(string.Empty)
                    || sifre.Text.Equals(string.Empty) || sifre_tekrar.Text.Equals(string.Empty)
                    || yas.Text.Equals(string.Empty) || adres.Text.Equals(string.Empty) || tel.Text.Equals(string.Empty)
                    || !(checkBox1.Checked || checkBox2.Checked)))
                {
                    
                    if (sifre.TextLength>=6)
                    { 
                    // E-mail in valid olup olmadığına bakıyor
                    if (IsValidEmail(email.Text))
                    {
                        //Password ların eşitliğini kontrol ediyor
                        if (sifre.Text.Equals(sifre_tekrar.Text))
                        {
                            con.Open();
                               // SqlCommand cmd1 = con.CreateCommand();
                            SqlCommand cmd = new SqlCommand("insert into kullanici(kullanici_adi,sifre,email,il,ilce,mahalle,adress,posta_kodu,telefon,yetki)" +
                            " values(@kullanici_adi, @sifre, @email, @il, @ilce, @mahalle, @adres, @posta, @telefon ,1)", con);

                                cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);
                                cmd.Parameters.AddWithValue("@sifre", sifre.Text);
                                cmd.Parameters.AddWithValue("@email", email.Text);
                                cmd.Parameters.AddWithValue("@il", yardimsever_il.Text);
                                cmd.Parameters.AddWithValue("@ilce", yardimsever_ilce.Text);
                                cmd.Parameters.AddWithValue("@mahalle", mahalle.Text);
                                cmd.Parameters.AddWithValue("@adres", adres.Text);
                                cmd.Parameters.AddWithValue("@posta", posta_kutusu.Text);
                                cmd.Parameters.AddWithValue("@telefon", tel.Text);
                                                                
                                cmd.ExecuteNonQuery();
                                
                                 SqlCommand cmd2 = new SqlCommand("insert into yardimsever(kAdi,ad,soyad,cinsiyet,bakiye)"+
                                     " values(@kAdi, @ad, @soyAd, @cinsiyet, 0)" ,con );
                                cmd2.Parameters.AddWithValue("@kAdi", kullanici_adi.Text);
                                cmd2.Parameters.AddWithValue("@ad", Ad.Text);
                                cmd2.Parameters.AddWithValue("@soyAd", soyAd.Text);
                                cmd2.Parameters.AddWithValue("@cinsiyet", checkbox(checkBox1, checkBox2));

                                //bakiye icin yapmadim cunku ilk baslangicta hep 0 veriyoruz.
                                cmd2.ExecuteScalar();
                                con.Close();
                                MessageBox.Show("Kayıt Başarılı", "BASARILI");
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "HATA");
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
        private void okul_kayit(object sender, EventArgs e)
        {
            try
            {
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(okul_adi.Text.Equals(string.Empty) || okul_il.Text.Equals(string.Empty)
                || okul_ilce.Text.Equals(string.Empty) || okul_adres.Text.Equals(string.Empty)
                || okul_email.Text.Equals(string.Empty) || okul_kullanici_adi.Text.Equals(string.Empty) 
                || okul_sifre.Text.Equals(string.Empty)|| okul_sifre.Text.Equals(string.Empty)))
                {
                    if (okul_sifre.TextLength>=6)
                    {
                        //E-mail in valid olup olmadığına bakıyor
                        if (IsValidEmail(okul_email.Text))
                        {
                            //Şifrelerin uyuşup uyuşmadığını kontrol ediyor.
                            if (okul_sifre.Text.Equals(okul_sifre_tekrar.Text))
                            {
                                //Database sistemi oluşturulduktan sonra
                                con.Open();
                               
                                SqlCommand cmd = new SqlCommand("insert into kullanici(kullanici_adi,sifre,email,il,ilce,mahalle,adress,posta_kodu,telefon,yetki)" +
                            " values(@kullanici_adi, @sifre, @email, @il, @ilce, @mahalle, @adres, @posta, @telefon ,2)", con);

                                cmd.Parameters.AddWithValue("@kullanici_adi", okul_kullanici_adi.Text);
                                cmd.Parameters.AddWithValue("@sifre", okul_sifre.Text);
                                cmd.Parameters.AddWithValue("@email", okul_email.Text);
                                cmd.Parameters.AddWithValue("@il", okul_il.Text);
                                cmd.Parameters.AddWithValue("@ilce", okul_ilce.Text);
                                cmd.Parameters.AddWithValue("@mahalle", okul_mahalle.Text);
                                cmd.Parameters.AddWithValue("@adres", okul_adres.Text);
                                cmd.Parameters.AddWithValue("@posta", okul_posta.Text);
                                cmd.Parameters.AddWithValue("@telefon", okul_telefon.Text);

                               
                                
                                SqlCommand cmd2 = new SqlCommand("insert into okul(kAdi,bakiye,valid) values(@kAdi,0,0)", con);

                                cmd2.Parameters.AddWithValue("@kAdi", okul_kullanici_adi.Text);
                                cmd.ExecuteNonQuery();
                                cmd2.ExecuteScalar();
                                con.Close();
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
        //Tedarikci kayıt ekranında register düğmesine bastığında yapılacak olan
        private void tedarikci_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                // Fieldların doluluk durumunu kontrol ediyor
                if (!(firma_adi.Text.Equals(string.Empty) || tedarikci_kullanici_adi.Text.Equals(string.Empty)
                || tedarikci_sifre.Text.Equals(string.Empty) || tedarikci_sifre_tekrar.Text.Equals(string.Empty)
                || tedarikci_email.Text.Equals(string.Empty) || tedarikci_adres.Text.Equals(string.Empty)
                || tedarikci_telefon.Text.Equals(string.Empty) ))
                {
                    if (tedarikci_sifre.TextLength >= 6)
                    {
                        //E-mail in valid olup olmadığına bakıyor
                        if (IsValidEmail(tedarikci_email.Text))
                        {
                            //Şifrelerin uyuşup uyuşmadığını kontrol ediyor.
                            if (tedarikci_sifre.Text.Equals(tedarikci_sifre_tekrar.Text))
                            {
                                //Database sistemi oluşturulduktan sonra
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into kullanici(kullanici_adi,sifre,email,il,ilce,mahalle,adress,posta_kodu,telefon,yetki)" +
                            " values(@kullanici_adi, @sifre, @email, @il, @ilce, @mahalle, @adres, @posta, @telefon ,3)", con);

                                cmd.Parameters.AddWithValue("@kullanici_adi", tedarikci_kullanici_adi.Text);
                                cmd.Parameters.AddWithValue("@sifre", tedarikci_sifre.Text);
                                cmd.Parameters.AddWithValue("@email", tedarikci_email.Text);
                                cmd.Parameters.AddWithValue("@il", tedarikci_il.Text);
                                cmd.Parameters.AddWithValue("@ilce", tedarikci_ilce.Text);
                                cmd.Parameters.AddWithValue("@mahalle", tedarikci_mahalle.Text);
                                cmd.Parameters.AddWithValue("@adres", tedarikci_adres.Text);
                                cmd.Parameters.AddWithValue("@posta", tedarikci_posta.Text);
                                cmd.Parameters.AddWithValue("@telefon", tedarikci_telefon.Text);

                                cmd.ExecuteNonQuery();


                                SqlCommand cmd2 = new SqlCommand("insert into tedarikci(kAdi,firma_adi,bakiye,valid) values(@kAdi,@firma_adi,0,0)", con);

                                cmd2.Parameters.AddWithValue("@kAdi", tedarikci_kullanici_adi.Text);
                                cmd2.Parameters.AddWithValue("@firma_adi", firma_adi.Text);

                                cmd2.ExecuteScalar();
                                con.Close();
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "HATA");
            }
        }
        
    }
}
