﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gecisler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnGonder_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();//form objesi oluşturduk
            form.mesaj = TxtBox1.Text;
            form.Show();
            this.Hide();
        }
    }
}
