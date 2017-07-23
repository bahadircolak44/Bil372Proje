namespace Bil372Proje.Pages.yardimsever
{
    partial class para_bagisla
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
            this.miktar = new System.Windows.Forms.TextBox();
            this.bagisla = new System.Windows.Forms.Button();
            this.Geri = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ne Kadar : ";
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(380, 193);
            this.miktar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(197, 20);
            this.miktar.TabIndex = 1;
            // 
            // bagisla
            // 
            this.bagisla.Location = new System.Drawing.Point(380, 287);
            this.bagisla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bagisla.Name = "bagisla";
            this.bagisla.Size = new System.Drawing.Size(97, 30);
            this.bagisla.TabIndex = 2;
            this.bagisla.Text = "Bagışla";
            this.bagisla.UseVisualStyleBackColor = true;
            this.bagisla.Click += new System.EventHandler(this.bagisla_Click);
            // 
            // Geri
            // 
            this.Geri.Location = new System.Drawing.Point(495, 287);
            this.Geri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(97, 30);
            this.Geri.TabIndex = 3;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Toplam Bakiye";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // para_bagisla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.bagisla);
            this.Controls.Add(this.miktar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "para_bagisla";
            this.Text = "para_bagisla";
            this.Load += new System.EventHandler(this.para_bagisla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Button bagisla;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}