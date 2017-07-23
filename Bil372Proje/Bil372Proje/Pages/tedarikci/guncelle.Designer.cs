namespace Bil372Proje.Pages.tedarikci
{
    partial class guncelle
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.urun_adi = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adet = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(537, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // urun_adi
            // 
            this.urun_adi.FormattingEnabled = true;
            this.urun_adi.Location = new System.Drawing.Point(479, 65);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(222, 24);
            this.urun_adi.TabIndex = 2;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Location = new System.Drawing.Point(479, 152);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(222, 24);
            this.marka.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Markası :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat :";
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(479, 230);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(222, 22);
            this.adet.TabIndex = 8;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(479, 296);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(222, 22);
            this.fiyat.TabIndex = 9;
            // 
            // guncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 544);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.urun_adi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "guncelle";
            this.Text = "guncelle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox urun_adi;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.TextBox fiyat;
    }
}