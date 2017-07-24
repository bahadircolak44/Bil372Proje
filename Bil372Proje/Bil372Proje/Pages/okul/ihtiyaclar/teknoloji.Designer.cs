namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    partial class teknoloji
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
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teknoloji_ihtiyac = new System.Windows.Forms.ComboBox();
            this.teknoloji_uretim_yili = new System.Windows.Forms.ComboBox();
            this.teknoloji_marka = new System.Windows.Forms.ComboBox();
            this.teknoloji_adet = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teknoloji_model = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(211, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ihtiyac :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(211, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Model :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(211, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uretim yili :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(211, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marka :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(211, 368);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adet :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(219, 441);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.teknoloji_ekle);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LavenderBlush;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(423, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 50);
            this.button2.TabIndex = 6;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.teknoloji_geri_Click);
            // 
            // teknoloji_ihtiyac
            // 
            this.teknoloji_ihtiyac.FormattingEnabled = true;
            this.teknoloji_ihtiyac.Location = new System.Drawing.Point(312, 46);
            this.teknoloji_ihtiyac.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teknoloji_ihtiyac.Name = "teknoloji_ihtiyac";
            this.teknoloji_ihtiyac.Size = new System.Drawing.Size(276, 24);
            this.teknoloji_ihtiyac.TabIndex = 7;
            // 
            // teknoloji_uretim_yili
            // 
            this.teknoloji_uretim_yili.FormattingEnabled = true;
            this.teknoloji_uretim_yili.Location = new System.Drawing.Point(312, 198);
            this.teknoloji_uretim_yili.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teknoloji_uretim_yili.Name = "teknoloji_uretim_yili";
            this.teknoloji_uretim_yili.Size = new System.Drawing.Size(276, 24);
            this.teknoloji_uretim_yili.TabIndex = 8;
            // 
            // teknoloji_marka
            // 
            this.teknoloji_marka.FormattingEnabled = true;
            this.teknoloji_marka.Location = new System.Drawing.Point(312, 282);
            this.teknoloji_marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teknoloji_marka.Name = "teknoloji_marka";
            this.teknoloji_marka.Size = new System.Drawing.Size(276, 24);
            this.teknoloji_marka.TabIndex = 9;
            // 
            // teknoloji_adet
            // 
            this.teknoloji_adet.FormattingEnabled = true;
            this.teknoloji_adet.Location = new System.Drawing.Point(312, 364);
            this.teknoloji_adet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teknoloji_adet.Name = "teknoloji_adet";
            this.teknoloji_adet.Size = new System.Drawing.Size(276, 24);
            this.teknoloji_adet.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(633, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(511, 384);
            this.dataGridView1.TabIndex = 12;
            // 
            // teknoloji_model
            // 
            this.teknoloji_model.FormattingEnabled = true;
            this.teknoloji_model.Location = new System.Drawing.Point(312, 123);
            this.teknoloji_model.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teknoloji_model.Name = "teknoloji_model";
            this.teknoloji_model.Size = new System.Drawing.Size(276, 24);
            this.teknoloji_model.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(744, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Toplam";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(955, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "label7";
            // 
            // teknoloji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(1168, 597);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teknoloji_model);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.teknoloji_adet);
            this.Controls.Add(this.teknoloji_marka);
            this.Controls.Add(this.teknoloji_uretim_yili);
            this.Controls.Add(this.teknoloji_ihtiyac);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "teknoloji";
            this.Text = "teknoloji";
            this.Load += new System.EventHandler(this.teknoloji_Load);
            this.Click += new System.EventHandler(this.teknoloji_ekle);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox teknoloji_ihtiyac;
        private System.Windows.Forms.ComboBox teknoloji_uretim_yili;
        private System.Windows.Forms.ComboBox teknoloji_marka;
        private System.Windows.Forms.ComboBox teknoloji_adet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox teknoloji_model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}