namespace Bil372Proje.Pages.yardimsever
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
            this.karsila = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.listeye_ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // karsila
            // 
            this.karsila.BackColor = System.Drawing.Color.LavenderBlush;
            this.karsila.ForeColor = System.Drawing.SystemColors.ControlText;
            this.karsila.Location = new System.Drawing.Point(792, 465);
            this.karsila.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.karsila.Name = "karsila";
            this.karsila.Size = new System.Drawing.Size(313, 57);
            this.karsila.TabIndex = 14;
            this.karsila.Text = "Karşıla";
            this.karsila.UseVisualStyleBackColor = false;
            this.karsila.Click += new System.EventHandler(this.karsila_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(951, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(788, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Toplam :";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(788, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(317, 324);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(372, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listeye_ekle
            // 
            this.listeye_ekle.BackColor = System.Drawing.Color.LavenderBlush;
            this.listeye_ekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.listeye_ekle.Location = new System.Drawing.Point(121, 434);
            this.listeye_ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listeye_ekle.Name = "listeye_ekle";
            this.listeye_ekle.Size = new System.Drawing.Size(128, 50);
            this.listeye_ekle.TabIndex = 9;
            this.listeye_ekle.Text = "Ekle";
            this.listeye_ekle.UseVisualStyleBackColor = false;
            this.listeye_ekle.Click += new System.EventHandler(this.listeye_ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(772, 324);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deneme);
            // 
            // ihtiyac_karsila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::Bil372Proje.Properties.Resources.homeBox_fdcd3087cd12079a35c76302932e6356;
            this.ClientSize = new System.Drawing.Size(1101, 554);
            this.Controls.Add(this.karsila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listeye_ekle);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ihtiyac_karsila";
            this.Text = "ihtiyac_karsila";
            this.Load += new System.EventHandler(this.ihtiyac_karsila_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button karsila;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button listeye_ekle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}