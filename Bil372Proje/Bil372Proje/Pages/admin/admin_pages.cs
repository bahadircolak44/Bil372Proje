using Bil372Proje.Pages.admin.istek_sayfalari;
using Bil372Proje.Pages.admin.silme_sayfalari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil372Proje.Pages.admin
{
    public partial class admin_pages : Form
    {
        public admin_pages()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            okul_istek okul = new okul_istek();
            this.Hide();
            okul.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tedarikci_istek tedarikci = new tedarikci_istek();
            this.Hide();
            tedarikci.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            okul_sil okul_sil = new okul_sil();
            this.Hide();
            okul_sil.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            yardimsever_sil yardimseverSil = new yardimsever_sil();
            this.Hide();
            yardimseverSil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tedarikci_sil tedarikciSil = new tedarikci_sil();
            this.Hide();
            tedarikciSil.Show();
        }
    }
}
