﻿using System;
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
    public partial class teknoloji : Form
    {
        public string kAdi;
        public teknoloji(string kullanici)
        {
            kAdi = kullanici;
            InitializeComponent();
        }
    }
}