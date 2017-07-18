namespace Bil372Proje.Pages
{
    partial class yardimsever1
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
            this.button1 = new System.Windows.Forms.Button();
            this.bakiye_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "Okul Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bakiye_btn
            // 
            this.bakiye_btn.Location = new System.Drawing.Point(975, 45);
            this.bakiye_btn.Name = "bakiye_btn";
            this.bakiye_btn.Size = new System.Drawing.Size(147, 48);
            this.bakiye_btn.TabIndex = 1;
            this.bakiye_btn.UseMnemonic = false;
            this.bakiye_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1024, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "bakiye";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 308);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Para Yükle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // yardimsever1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1174, 674);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bakiye_btn);
            this.Controls.Add(this.button1);
            this.Name = "yardimsever1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.yardimsever1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bakiye_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
    }
}