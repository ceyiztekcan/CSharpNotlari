﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }int sayac =1;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                   

                if ((j!=2 || i==9) && (i!=5 || j<2))
                    {
                        Button btn = new Button();
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Left = btn.Width * j;
                        btn.Top = btn.Height * i;
                        btn.Text = sayac.ToString();
                        this.Controls.Add(btn);
                        sayac++;

                    }
                   
                    
                }
               
            }
            
        }
    }
}
