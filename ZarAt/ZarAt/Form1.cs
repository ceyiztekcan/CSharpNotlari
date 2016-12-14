using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;
        private void Zar ()
        {
          Random rnd = new Random();
            int zar = rnd.Next(1, 7);
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("pictures/" + zar + ".png");
            zar = rnd.Next(1, 7);
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("pictures/" + zar + ".png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sayac = 1;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sayac = 1;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            sayac = 1;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = System.IO.Path.GetFullPath("pictures/" + 1 + ".png");
            pictureBox2.ImageLocation = System.IO.Path.GetFullPath("pictures/" + 1 + ".png");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           
            if (sayac<10)
            {
                Zar();
            }
            else
            {
                timer1.Stop();
            }
            sayac++;

            
        }
        
    }
  
}
