using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages.tedarikci
{
    public partial class tedarikci_pages : Form
    {
        public tedarikci_pages()
        {
            InitializeComponent();
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {
            urun_ekle ekle = new urun_ekle();
            this.Hide();
            ekle.Show();
        }

        private void cikar_btn_Click(object sender, EventArgs e)
        {
            urun_cikar cikar = new urun_cikar();
            this.Hide();
            cikar.Show();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            urun_guncelle guncelle = new urun_guncelle();
            this.Hide();
            guncelle.Show();
        }

        private void tedarikci_pages_Load(object sender, EventArgs e)
        {

        }
    }
}
