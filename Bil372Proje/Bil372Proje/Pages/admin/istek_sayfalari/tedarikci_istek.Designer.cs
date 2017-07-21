namespace Bil372Proje.Pages.admin.istek_sayfalari
{
    partial class tedarikci_istek
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
            this.onayla_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 343);
            this.dataGridView1.TabIndex = 0;
            // 
            // onayla_btn
            // 
            this.onayla_btn.Location = new System.Drawing.Point(262, 418);
            this.onayla_btn.Name = "onayla_btn";
            this.onayla_btn.Size = new System.Drawing.Size(151, 56);
            this.onayla_btn.TabIndex = 1;
            this.onayla_btn.Text = "Onayla";
            this.onayla_btn.UseVisualStyleBackColor = true;
            this.onayla_btn.Click += new System.EventHandler(this.onayla_btn_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(815, 418);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(151, 56);
            this.geri_btn.TabIndex = 2;
            this.geri_btn.Text = "Geri";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(528, 418);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(151, 56);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // tedarikci_istek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 563);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.onayla_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tedarikci_istek";
            this.Text = "tedarikci_istek";
            this.Load += new System.EventHandler(this.tedarikci_istek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button onayla_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button sil_btn;
    }
}