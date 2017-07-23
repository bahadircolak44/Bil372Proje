namespace Bil372Proje.Pages.okul
{
    partial class ihtiyac_karsila
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
            this.listeye_ekle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // listeye_ekle
            // 
            this.listeye_ekle.Location = new System.Drawing.Point(137, 415);
            this.listeye_ekle.Name = "listeye_ekle";
            this.listeye_ekle.Size = new System.Drawing.Size(128, 50);
            this.listeye_ekle.TabIndex = 2;
            this.listeye_ekle.Text = "Ekle";
            this.listeye_ekle.UseVisualStyleBackColor = true;
            this.listeye_ekle.Click += new System.EventHandler(this.listeye_ekle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(804, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 324);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ihtiyac_karsila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 550);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listeye_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ihtiyac_karsila";
            this.Text = "ihtiyac_karsila";
            this.Load += new System.EventHandler(this.ihtiyac_karsila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button listeye_ekle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}