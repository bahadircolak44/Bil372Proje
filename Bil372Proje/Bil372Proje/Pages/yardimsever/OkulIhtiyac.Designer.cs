namespace Bil372Proje.Pages
{
    partial class OkulIhtiyac
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.para_bagisla = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(586, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 644);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(264, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "İhtiyaç Seç/Karşıla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // para_bagisla
            // 
            this.para_bagisla.BackColor = System.Drawing.Color.LavenderBlush;
            this.para_bagisla.Location = new System.Drawing.Point(264, 282);
            this.para_bagisla.Name = "para_bagisla";
            this.para_bagisla.Size = new System.Drawing.Size(167, 58);
            this.para_bagisla.TabIndex = 2;
            this.para_bagisla.Text = "Para Bağışla";
            this.para_bagisla.UseVisualStyleBackColor = false;
            this.para_bagisla.Click += new System.EventHandler(this.para_bagisla_Click);
            // 
            // Geri
            // 
            this.Geri.BackColor = System.Drawing.Color.LavenderBlush;
            this.Geri.Location = new System.Drawing.Point(264, 404);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(167, 58);
            this.Geri.TabIndex = 3;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = false;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // OkulIhtiyac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(1158, 668);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.para_bagisla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OkulIhtiyac";
            this.Text = "Okul";
            this.Load += new System.EventHandler(this.Okul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button para_bagisla;
        private System.Windows.Forms.Button Geri;
    }
}