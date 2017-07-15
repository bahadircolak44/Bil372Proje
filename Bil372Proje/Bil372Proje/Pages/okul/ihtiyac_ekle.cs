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
    }
}
