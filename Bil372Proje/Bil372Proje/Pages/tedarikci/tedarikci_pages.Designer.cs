namespace Bil372Proje.Pages.tedarikci
{
    partial class tedarikci_pages
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
            this.cikar_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(257, 230);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(170, 60);
            this.ekle_btn.TabIndex = 0;
            this.ekle_btn.Text = "Ürün Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // cikar_btn
            // 
            this.cikar_btn.Location = new System.Drawing.Point(484, 230);
            this.cikar_btn.Name = "cikar_btn";
            this.cikar_btn.Size = new System.Drawing.Size(170, 61);
            this.cikar_btn.TabIndex = 1;
            this.cikar_btn.Text = "Ürün Çıkar";
            this.cikar_btn.UseVisualStyleBackColor = true;
            this.cikar_btn.Click += new System.EventHandler(this.cikar_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(721, 229);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(170, 61);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "Ürün Güncelle";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // tedarikci_pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1177, 658);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.cikar_btn);
            this.Controls.Add(this.ekle_btn);
            this.Name = "tedarikci_pages";
            this.Text = "tedarikci_pages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button cikar_btn;
        private System.Windows.Forms.Button update_btn;
    }
}