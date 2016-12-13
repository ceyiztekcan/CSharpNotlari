using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> isimler = new List<string>() { "Esranur", "Çeyiz", "Halil", "Bengisu", "Hakan", "Yunus", "Yankı", "Atakan", "OzanK", "OzanA ", "Aytekin", "İrfan", "Cemal", "Merve" };
        Random rnd = new Random();
        int sayac = 0;

        private Color Rasgelerenk()
        {
            Color color;
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);
            color = Color.FromArgb(red, green, blue);
            return color;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.WindowState = FormWindowState.Maximized;
          
          

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            int index = rnd.Next(0, 14);
            string isim = isimler[index];
            int fontSize = rnd.Next(20, 40);
            Graphics g = CreateGraphics();
            Color color = Rasgelerenk();
            int x = rnd.Next(10, this.Width - 50);
            int y = rnd.Next(10, this.Height - 50);
            g.DrawString(isim, new Font(FontFamily.GenericSansSerif, fontSize, FontStyle.Bold), new SolidBrush(color), x, y);

            if (sayac == 200)
            {
                this.BackColor = Rasgelerenk();
                this.Invalidate();
                
                sayac = 0;
            }
            sayac++;
        }
        
    }
    
}
