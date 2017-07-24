namespace Bil372Proje.Pages.admin.istek_sayfalari
{
    partial class okul_istek
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
            this.onay_click = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // onay_click
            // 
            this.onay_click.BackColor = System.Drawing.Color.LavenderBlush;
            this.onay_click.Location = new System.Drawing.Point(291, 444);
            this.onay_click.Name = "onay_click";
            this.onay_click.Size = new System.Drawing.Size(162, 63);
            this.onay_click.TabIndex = 1;
            this.onay_click.Text = "Onayla";
            this.onay_click.UseVisualStyleBackColor = false;
            this.onay_click.Click += new System.EventHandler(this.onay_click_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.geri_btn.Location = new System.Drawing.Point(780, 444);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(162, 63);
            this.geri_btn.TabIndex = 2;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = false;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.BackColor = System.Drawing.Color.LavenderBlush;
            this.sil_btn.Location = new System.Drawing.Point(527, 444);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(162, 63);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = false;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // okul_istek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(1172, 590);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.onay_click);
            this.Controls.Add(this.dataGridView1);
            this.Name = "okul_istek";
            this.Text = "okul_istek";
            this.Load += new System.EventHandler(this.okul_istek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button onay_click;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button sil_btn;
    }
}