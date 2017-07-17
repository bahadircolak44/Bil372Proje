namespace Bil372Proje.Pages.okul
{
    partial class okul_pages
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
            this.bakiye_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bakiye_btn
            // 
            this.bakiye_btn.Location = new System.Drawing.Point(998, 53);
            this.bakiye_btn.Name = "bakiye_btn";
            this.bakiye_btn.Size = new System.Drawing.Size(133, 52);
            this.bakiye_btn.TabIndex = 0;
            this.bakiye_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1044, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bakiye";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "İhtiyaç Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // okul_pages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1201, 684);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bakiye_btn);
            this.Name = "okul_pages";
            this.Text = "okul_ekrani";
            this.Load += new System.EventHandler(this.okul_pages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bakiye_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}