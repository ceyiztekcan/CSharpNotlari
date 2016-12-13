﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakePaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        ColorDialog colorDialog = new ColorDialog();
        int kalinlik=3;
        int basX, basY;
        bool ciz;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            Pen p = new Pen(colorDialog.Color,kalinlik);
            Point point1 = new Point(basX,basY);
            Point point2 = new Point(e.X, e.Y);
            if (ciz==true)
            {
                g.DrawLine(p, point1, point2);
                basX = e.X;
                basY = e.Y;
            }

        }

        private void BtnRenkSec_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            basX = e.X;
            basY = e.Y;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalinlik = int.Parse(comboBox1.SelectedItem.ToString());
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
