﻿namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    partial class mobilya
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mobilya_ihtiyac = new System.Windows.Forms.ComboBox();
            this.mobilya_marka = new System.Windows.Forms.ComboBox();
            this.mobilya_adet = new System.Windows.Forms.ComboBox();
            this.mobilya_olcu = new System.Windows.Forms.ComboBox();
            this.mobilya_renk = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mobilya_ekle = new System.Windows.Forms.Button();
            this.mobilya_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İhtiyac: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ölçü :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Renk: ";
            // 
            // mobilya_ihtiyac
            // 
            this.mobilya_ihtiyac.FormattingEnabled = true;
            this.mobilya_ihtiyac.Items.AddRange(new object[] {
            "koltuk",
            "kanepe",
            "sıra",
            "masa",
            "sandalye"});
            this.mobilya_ihtiyac.Location = new System.Drawing.Point(211, 80);
            this.mobilya_ihtiyac.Name = "mobilya_ihtiyac";
            this.mobilya_ihtiyac.Size = new System.Drawing.Size(230, 24);
            this.mobilya_ihtiyac.TabIndex = 5;
            // 
            // mobilya_marka
            // 
            this.mobilya_marka.FormattingEnabled = true;
            this.mobilya_marka.Items.AddRange(new object[] {
            "istikbal",
            "bellona"});
            this.mobilya_marka.Location = new System.Drawing.Point(211, 167);
            this.mobilya_marka.Name = "mobilya_marka";
            this.mobilya_marka.Size = new System.Drawing.Size(230, 24);
            this.mobilya_marka.TabIndex = 6;
            // 
            // mobilya_adet
            // 
            this.mobilya_adet.FormattingEnabled = true;
            this.mobilya_adet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.mobilya_adet.Location = new System.Drawing.Point(211, 238);
            this.mobilya_adet.Name = "mobilya_adet";
            this.mobilya_adet.Size = new System.Drawing.Size(230, 24);
            this.mobilya_adet.TabIndex = 7;
            // 
            // mobilya_olcu
            // 
            this.mobilya_olcu.FormattingEnabled = true;
            this.mobilya_olcu.Items.AddRange(new object[] {
            "1 kişilik",
            "2 kişilik",
            "3 kişilik",
            "4 kişilik"});
            this.mobilya_olcu.Location = new System.Drawing.Point(211, 302);
            this.mobilya_olcu.Name = "mobilya_olcu";
            this.mobilya_olcu.Size = new System.Drawing.Size(230, 24);
            this.mobilya_olcu.TabIndex = 8;
            // 
            // mobilya_renk
            // 
            this.mobilya_renk.FormattingEnabled = true;
            this.mobilya_renk.Items.AddRange(new object[] {
            "siyah",
            "beyaz",
            "kırmızı",
            "mavi",
            "sarı"});
            this.mobilya_renk.Location = new System.Drawing.Point(211, 370);
            this.mobilya_renk.Name = "mobilya_renk";
            this.mobilya_renk.Size = new System.Drawing.Size(230, 24);
            this.mobilya_renk.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(645, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 543);
            this.dataGridView1.TabIndex = 10;
            // 
            // mobilya_ekle
            // 
            this.mobilya_ekle.Location = new System.Drawing.Point(211, 428);
            this.mobilya_ekle.Name = "mobilya_ekle";
            this.mobilya_ekle.Size = new System.Drawing.Size(109, 45);
            this.mobilya_ekle.TabIndex = 11;
            this.mobilya_ekle.Text = "Ekle";
            this.mobilya_ekle.UseVisualStyleBackColor = false;
            this.mobilya_ekle.Click += new System.EventHandler(this.mobilya_ekle_Click);
            // 
            // mobilya_geri
            // 
            this.mobilya_geri.Location = new System.Drawing.Point(332, 428);
            this.mobilya_geri.Name = "mobilya_geri";
            this.mobilya_geri.Size = new System.Drawing.Size(109, 45);
            this.mobilya_geri.TabIndex = 12;
            this.mobilya_geri.Text = "Geri";
            this.mobilya_geri.UseVisualStyleBackColor = true;
            this.mobilya_geri.Click += new System.EventHandler(this.mobilya_geri_Click);
            // 
            // mobilya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 567);
            this.Controls.Add(this.mobilya_geri);
            this.Controls.Add(this.mobilya_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mobilya_renk);
            this.Controls.Add(this.mobilya_olcu);
            this.Controls.Add(this.mobilya_adet);
            this.Controls.Add(this.mobilya_marka);
            this.Controls.Add(this.mobilya_ihtiyac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mobilya";
            this.Text = "mobilya";
            this.Load += new System.EventHandler(this.mobilya_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mobilya_ihtiyac;
        private System.Windows.Forms.ComboBox mobilya_marka;
        private System.Windows.Forms.ComboBox mobilya_adet;
        private System.Windows.Forms.ComboBox mobilya_olcu;
        private System.Windows.Forms.ComboBox mobilya_renk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button mobilya_ekle;
        private System.Windows.Forms.Button mobilya_geri;
    }
}