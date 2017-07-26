namespace Bil372Proje.Pages.tedarikci
{
    partial class urun_ekle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekle_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(0, 0);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(75, 23);
            this.ekle_btn.TabIndex = 0;
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.geri_btn.Location = new System.Drawing.Point(552, 362);
            this.geri_btn.Margin = new System.Windows.Forms.Padding(2);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(104, 50);
            this.geri_btn.TabIndex = 11;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(374, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(374, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Giysi Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Location = new System.Drawing.Point(520, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Teknoloji  Ekle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LavenderBlush;
            this.button4.Location = new System.Drawing.Point(520, 265);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mobilya Ekle";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LavenderBlush;
            this.button5.Location = new System.Drawing.Point(229, 265);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "Kitap Ekle";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LavenderBlush;
            this.button6.Location = new System.Drawing.Point(229, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 41);
            this.button6.TabIndex = 5;
            this.button6.Text = "Kırtasiye Ekle";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // urun_ekle
            // 
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(880, 440);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "urun_ekle";
            this.Text = "urun_ekle";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}