using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
       public List<string> yolcular = new List<string>();
        
        public string kayit;
        private void Form2_Load(object sender, EventArgs e)
        {
            //yolcular[int.Parse(kayit)].Insert(1, textBox1.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form form1 = new Form1();
    
            //form1.Show();
            this.Hide();
        }
    }
}
