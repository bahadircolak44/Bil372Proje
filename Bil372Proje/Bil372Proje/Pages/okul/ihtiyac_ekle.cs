using Bil372Proje.Pages.okul.ihtiyaclar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul
{
    public partial class ihtiyac_ekle : Form
    {
        public ihtiyac_ekle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kirtasiye kir = new kirtasiye();
            this.Hide();
            kir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mobilya mobilya = new mobilya();
            this.Hide();
            mobilya.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kitap kitap = new kitap();
            this.Hide();
            kitap.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            giysi giysi = new giysi();
            this.Hide();
            giysi.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teknoloji teknoloji = new teknoloji();
            this.Hide();
            teknoloji.Show();
        }
    }
}
