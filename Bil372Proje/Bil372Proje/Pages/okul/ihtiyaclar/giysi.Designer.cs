﻿namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    partial class giysi
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
            this.label_giysi_cinsiyet = new System.Windows.Forms.Label();
            this.giysi_ekle = new System.Windows.Forms.Button();
            this.giysi_geri = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.giysi_ihtiyac = new System.Windows.Forms.ComboBox();
            this.giysi_adet = new System.Windows.Forms.ComboBox();
            this.giysi_marka = new System.Windows.Forms.ComboBox();
            this.giysi_beden = new System.Windows.Forms.ComboBox();
            this.giysi_renk = new System.Windows.Forms.ComboBox();
            this.giysi_kumas = new System.Windows.Forms.ComboBox();
            this.giysi_cinsiyet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(152, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ihtiyaç : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(152, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beden :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(152, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Renk :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(152, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kumas :";
            // 
            // label_giysi_cinsiyet
            // 
            this.label_giysi_cinsiyet.AutoSize = true;
            this.label_giysi_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label_giysi_cinsiyet.Location = new System.Drawing.Point(152, 363);
            this.label_giysi_cinsiyet.Name = "label_giysi_cinsiyet";
            this.label_giysi_cinsiyet.Size = new System.Drawing.Size(59, 13);
            this.label_giysi_cinsiyet.TabIndex = 5;
            this.label_giysi_cinsiyet.Text = "Cinsiyet :";
            // 
            // giysi_ekle
            // 
            this.giysi_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.giysi_ekle.Location = new System.Drawing.Point(260, 411);
            this.giysi_ekle.Name = "giysi_ekle";
            this.giysi_ekle.Size = new System.Drawing.Size(94, 33);
            this.giysi_ekle.TabIndex = 11;
            this.giysi_ekle.Text = "Ekle";
            this.giysi_ekle.UseVisualStyleBackColor = true;
            this.giysi_ekle.Click += new System.EventHandler(this.giysi_ekle_Click);
            // 
            // giysi_geri
            // 
            this.giysi_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.giysi_geri.Location = new System.Drawing.Point(419, 411);
            this.giysi_geri.Name = "giysi_geri";
            this.giysi_geri.Size = new System.Drawing.Size(97, 32);
            this.giysi_geri.TabIndex = 12;
            this.giysi_geri.Text = "Geri";
            this.giysi_geri.UseVisualStyleBackColor = true;
            this.giysi_geri.Click += new System.EventHandler(this.giysi_geri_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(590, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(271, 367);
            this.dataGridView1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(152, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Adet : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(152, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Marka";
            // 
            // giysi_ihtiyac
            // 
            this.giysi_ihtiyac.FormattingEnabled = true;
            this.giysi_ihtiyac.Location = new System.Drawing.Point(260, 45);
            this.giysi_ihtiyac.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_ihtiyac.Name = "giysi_ihtiyac";
            this.giysi_ihtiyac.Size = new System.Drawing.Size(177, 21);
            this.giysi_ihtiyac.TabIndex = 16;
            this.giysi_ihtiyac.SelectedIndexChanged += new System.EventHandler(this.giysi_ihtiyac_SelectedIndexChanged);
            // 
            // giysi_adet
            // 
            this.giysi_adet.FormattingEnabled = true;
            this.giysi_adet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.giysi_adet.Location = new System.Drawing.Point(260, 97);
            this.giysi_adet.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_adet.Name = "giysi_adet";
            this.giysi_adet.Size = new System.Drawing.Size(177, 21);
            this.giysi_adet.TabIndex = 17;
            // 
            // giysi_marka
            // 
            this.giysi_marka.FormattingEnabled = true;
            this.giysi_marka.Location = new System.Drawing.Point(260, 146);
            this.giysi_marka.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_marka.Name = "giysi_marka";
            this.giysi_marka.Size = new System.Drawing.Size(177, 21);
            this.giysi_marka.TabIndex = 18;
            this.giysi_marka.SelectedIndexChanged += new System.EventHandler(this.giysi_marka_SelectedIndexChanged);
            // 
            // giysi_beden
            // 
            this.giysi_beden.FormattingEnabled = true;
            this.giysi_beden.Location = new System.Drawing.Point(260, 194);
            this.giysi_beden.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_beden.Name = "giysi_beden";
            this.giysi_beden.Size = new System.Drawing.Size(177, 21);
            this.giysi_beden.TabIndex = 19;
            // 
            // giysi_renk
            // 
            this.giysi_renk.FormattingEnabled = true;
            this.giysi_renk.Location = new System.Drawing.Point(260, 249);
            this.giysi_renk.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_renk.Name = "giysi_renk";
            this.giysi_renk.Size = new System.Drawing.Size(177, 21);
            this.giysi_renk.TabIndex = 20;
            // 
            // giysi_kumas
            // 
            this.giysi_kumas.FormattingEnabled = true;
            this.giysi_kumas.Location = new System.Drawing.Point(260, 305);
            this.giysi_kumas.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_kumas.Name = "giysi_kumas";
            this.giysi_kumas.Size = new System.Drawing.Size(177, 21);
            this.giysi_kumas.TabIndex = 21;
            // 
            // giysi_cinsiyet
            // 
            this.giysi_cinsiyet.FormattingEnabled = true;
            this.giysi_cinsiyet.Location = new System.Drawing.Point(260, 356);
            this.giysi_cinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.giysi_cinsiyet.Name = "giysi_cinsiyet";
            this.giysi_cinsiyet.Size = new System.Drawing.Size(177, 21);
            this.giysi_cinsiyet.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // giysi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(869, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.giysi_cinsiyet);
            this.Controls.Add(this.giysi_kumas);
            this.Controls.Add(this.giysi_renk);
            this.Controls.Add(this.giysi_beden);
            this.Controls.Add(this.giysi_marka);
            this.Controls.Add(this.giysi_adet);
            this.Controls.Add(this.giysi_ihtiyac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.giysi_geri);
            this.Controls.Add(this.giysi_ekle);
            this.Controls.Add(this.label_giysi_cinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "giysi";
            this.Text = "giysi";
            this.Load += new System.EventHandler(this.giysi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_giysi_cinsiyet;
        private System.Windows.Forms.Button giysi_ekle;
        private System.Windows.Forms.Button giysi_geri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox giysi_ihtiyac;
        private System.Windows.Forms.ComboBox giysi_adet;
        private System.Windows.Forms.ComboBox giysi_marka;
        private System.Windows.Forms.ComboBox giysi_beden;
        private System.Windows.Forms.ComboBox giysi_renk;
        private System.Windows.Forms.ComboBox giysi_kumas;
        private System.Windows.Forms.ComboBox giysi_cinsiyet;
        private System.Windows.Forms.Button button1;
    }
}