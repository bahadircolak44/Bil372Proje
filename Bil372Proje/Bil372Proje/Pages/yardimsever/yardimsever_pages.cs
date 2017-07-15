using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages
{
    public partial class yardimsever1 : Form
    {
        public yardimsever1()
        {

            // Okul Arama Sayfasıdır.
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yardimsever2 y2 = new yardimsever2();
            this.Hide();
            y2.Show();

        }
    }
}
