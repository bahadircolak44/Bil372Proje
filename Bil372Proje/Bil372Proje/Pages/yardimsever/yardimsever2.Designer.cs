namespace Bil372Proje.Pages
{
    partial class yardimsever2
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
            this.button3 = new System.Windows.Forms.Button();
            this.okul_adi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okul_ara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(405, 448);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.goto_okulpage);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LavenderBlush;
            this.button3.Location = new System.Drawing.Point(284, 280);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Geri";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // okul_adi
            // 
            this.okul_adi.Location = new System.Drawing.Point(198, 201);
            this.okul_adi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okul_adi.Name = "okul_adi";
            this.okul_adi.Size = new System.Drawing.Size(175, 20);
            this.okul_adi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(53, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Okul Adı :";
            // 
            // okul_ara
            // 
            this.okul_ara.BackColor = System.Drawing.Color.LavenderBlush;
            this.okul_ara.Location = new System.Drawing.Point(124, 281);
            this.okul_ara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.okul_ara.Name = "okul_ara";
            this.okul_ara.Size = new System.Drawing.Size(88, 40);
            this.okul_ara.TabIndex = 6;
            this.okul_ara.Text = "Ara";
            this.okul_ara.UseVisualStyleBackColor = false;
            this.okul_ara.Click += new System.EventHandler(this.okul_ara_Click);
            // 
            // yardimsever2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(848, 467);
            this.Controls.Add(this.okul_ara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okul_adi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "yardimsever2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox okul_adi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okul_ara;
    }
}