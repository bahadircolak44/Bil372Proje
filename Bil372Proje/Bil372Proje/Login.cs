﻿using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Bil372Proje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=bil372.database.windows.net;Initial Catalog=bil372DB;User ID=bahadir;Password=Qwerty123");
            SqlDataAdapter sda = new SqlDataAdapter("Select Id From users where username='"+ textBox1.Text+"'and password='"+ textBox2.Text+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
        }
    }
}
