namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    partial class kirtasiye
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kirtasiye_ihtiyac = new System.Windows.Forms.ComboBox();
            this.kirtasiye_marka = new System.Windows.Forms.ComboBox();
            this.kirtasiye_adet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(105, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İhtiyaç :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adet : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marka :";
            // 
            // kirtasiye_ihtiyac
            // 
            this.kirtasiye_ihtiyac.FormattingEnabled = true;
            this.kirtasiye_ihtiyac.Items.AddRange(new object[] {
            "kalem",
            "silgi",
            "kağıt",
            "makas",
            "tükenmez kalem",
            "kırmızı kalem",
            "bant",
            "cilt",
            "dolma kalem"});
            this.kirtasiye_ihtiyac.Location = new System.Drawing.Point(200, 127);
            this.kirtasiye_ihtiyac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kirtasiye_ihtiyac.Name = "kirtasiye_ihtiyac";
            this.kirtasiye_ihtiyac.Size = new System.Drawing.Size(187, 21);
            this.kirtasiye_ihtiyac.TabIndex = 3;
            // 
            // kirtasiye_marka
            // 
            this.kirtasiye_marka.FormattingEnabled = true;
            this.kirtasiye_marka.Items.AddRange(new object[] {
            "Faber Castel"});
            this.kirtasiye_marka.Location = new System.Drawing.Point(200, 193);
            this.kirtasiye_marka.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kirtasiye_marka.Name = "kirtasiye_marka";
            this.kirtasiye_marka.Size = new System.Drawing.Size(187, 21);
            this.kirtasiye_marka.TabIndex = 4;
            // 
            // kirtasiye_adet
            // 
            this.kirtasiye_adet.FormattingEnabled = true;
            this.kirtasiye_adet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.kirtasiye_adet.Location = new System.Drawing.Point(200, 256);
            this.kirtasiye_adet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kirtasiye_adet.Name = "kirtasiye_adet";
            this.kirtasiye_adet.Size = new System.Drawing.Size(187, 21);
            this.kirtasiye_adet.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 333);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(365, 479);
            this.dataGridView1.TabIndex = 8;
            // 
            // kirtasiye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kirtasiye_adet);
            this.Controls.Add(this.kirtasiye_marka);
            this.Controls.Add(this.kirtasiye_ihtiyac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "kirtasiye";
            this.Text = "kirtasiye";
            this.Load += new System.EventHandler(this.kirtasiye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox kirtasiye_ihtiyac;
        private System.Windows.Forms.ComboBox kirtasiye_marka;
        private System.Windows.Forms.ComboBox kirtasiye_adet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}