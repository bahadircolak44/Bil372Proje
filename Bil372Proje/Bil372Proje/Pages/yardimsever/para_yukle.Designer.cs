namespace Bil372Proje.Pages.yardimsever
{
    partial class para_yukle
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
            this.bakiye_yukle = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bakiye_yukle
            // 
            this.bakiye_yukle.BackColor = System.Drawing.Color.LavenderBlush;
            this.bakiye_yukle.Location = new System.Drawing.Point(388, 374);
            this.bakiye_yukle.Name = "bakiye_yukle";
            this.bakiye_yukle.Size = new System.Drawing.Size(142, 45);
            this.bakiye_yukle.TabIndex = 0;
            this.bakiye_yukle.Text = "Yükle";
            this.bakiye_yukle.UseVisualStyleBackColor = false;
            this.bakiye_yukle.UseWaitCursor = true;
            this.bakiye_yukle.Click += new System.EventHandler(this.bakiye_yukle_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.Color.LavenderBlush;
            this.geri.Location = new System.Drawing.Point(625, 374);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(142, 45);
            this.geri.TabIndex = 1;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(494, 261);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(238, 22);
            this.miktar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(396, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Miktar :";
            // 
            // para_yukle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(1151, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.bakiye_yukle);
            this.Name = "para_yukle";
            this.Text = "para_yukle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bakiye_yukle;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Label label1;
    }
}