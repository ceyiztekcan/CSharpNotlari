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

            //for (int i = 0; i < 50; i++)
            //{
            //    yolcular.Add("bos");

            //}
        }
        public static string[] yolcular = new string[50];
        
        public int kayit;
        

        private void button1_Click(object sender, EventArgs e)
        {
            yolcular[(kayit - 1)] += textBox1.Text;
            textBox2.Text =  "koltuk : " + kayit.ToString()+ yolcular[kayit-1];

           Form form1 = new Form1();
           
           this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox1.Text = "bos";
        }
    }
}
