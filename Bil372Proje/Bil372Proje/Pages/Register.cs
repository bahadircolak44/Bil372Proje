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
        /*YAPILACAKLAR
         *1-) yardimsever_kayit_Click fonksiyonunda insert into yardimsever(.....) values(..) kısmı eklenecek
         *2-) aynı fonksiyonda injection önlemesi yapılacak (cmd.Parameters.AddWithValue("@kullanici_adi", kullanici_adi.Text);)
         * Injection için login ekranından kopya çekebilirsin
         * 3) Okul için kullanici kayit kısmı oluşturulacak.
         *    insert into kullanici(.....) values(..) ve insert into okul(.....) values(..)  şeklinde
         * 4) aynı şey tedarikçi içinde yapılacak.
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
                            SqlCommand cmd = new SqlCommand("insert into kullanici(kullanici_adi,sifre,email,il,ilce,mahalle,adress,posta_kodu,telefon,yetki)" +
                            " values('" + kullanici_adi.Text + "','" + sifre.Text + "','" + email.Text + "','"+yardimsever_il.Text+ "','" + yardimsever_ilce.Text
                            + "','" + mahalle.Text + "','" + adres.Text + "','" + posta_kutusu.Text + "','" + tel.Text + "',1)", con);
                            cmd.ExecuteNonQuery();
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
                if (!(okul_adi.Text.Equals(string.Empty) || il.Text.Equals(string.Empty)
                || ilce.Text.Equals(string.Empty) || okul_adres.Text.Equals(string.Empty)
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
                            if (label_tedarikci_sifre.Text.Equals(label_tedarikci_sifre_tekrar.Text))
                            {
                                //Database sistemi oluşturulduktan sonra
                                con.Open();
                                SqlCommand cmd = new SqlCommand("insert into tedarikci(firma_adi,kullanci_adi,sifre,email,adres,tel,yetki,bakiye,valid)" +
                                " values('" + firma_adi.Text + "','" + tedarikci_kullanici_adi.Text + "','" + tedarikci_sifre.Text + "','" + tedarikci_email.Text + "'," +
                                " '" + tedarikci_adres.Text + "','" + tedarikci_telefon.Text + "','tedarikci',0)", con);
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
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString(), "HATA");
            }
        }
    }
}
