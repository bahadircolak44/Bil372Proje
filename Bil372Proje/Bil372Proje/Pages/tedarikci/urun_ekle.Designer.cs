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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.katagori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.marka = new System.Windows.Forms.TextBox();
            this.stok_miktari = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(130, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(130, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stok Miktarı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(130, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat :";
            // 
            // katagori
            // 
            this.katagori.FormattingEnabled = true;
            this.katagori.Items.AddRange(new object[] {
            "Giysi",
            "Kitap",
            "Kırtasiye",
            "Teknoloji",
            "Mobilya"});
            this.katagori.Location = new System.Drawing.Point(316, 70);
            this.katagori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.katagori.Name = "katagori";
            this.katagori.Size = new System.Drawing.Size(169, 21);
            this.katagori.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(130, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Marka :";
            // 
            // ad
            // 
            this.ad.AutoCompleteCustomSource.AddRange(new string[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h"});
            this.ad.Location = new System.Drawing.Point(316, 127);
            this.ad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(169, 20);
            this.ad.TabIndex = 6;
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(316, 183);
            this.marka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(169, 20);
            this.marka.TabIndex = 7;
            // 
            // stok_miktari
            // 
            this.stok_miktari.Location = new System.Drawing.Point(316, 240);
            this.stok_miktari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stok_miktari.Name = "stok_miktari";
            this.stok_miktari.Size = new System.Drawing.Size(169, 20);
            this.stok_miktari.TabIndex = 8;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(316, 307);
            this.fiyat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(169, 20);
            this.fiyat.TabIndex = 9;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(170, 362);
            this.ekle_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(104, 51);
            this.ekle_btn.TabIndex = 10;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(380, 362);
            this.geri_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(104, 50);
            this.geri_btn.TabIndex = 11;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(543, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(335, 352);
            this.dataGridView1.TabIndex = 12;
            // 
            // urun_ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.stok_miktari);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.katagori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "urun_ekle";
            this.Text = "urun_ekle";
            this.Load += new System.EventHandler(this.urun_ekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox katagori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox stok_miktari;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}