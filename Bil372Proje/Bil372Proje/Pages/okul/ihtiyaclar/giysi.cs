using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages.okul.ihtiyaclar
{
    public partial class giysi : Form
    {

        // butonlar eklendi. Ekle ve geri butonlari bir sey yapmiyor. 
        // ihtiyactaki textbox'ta dropdown eklenecek.
        public string kAdi;
        public giysi(string kullanici)
        {
            kAdi = kullanici;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
