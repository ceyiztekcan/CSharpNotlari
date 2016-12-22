using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci ogr1 = new Ogrenci();
        Ogrenci ogr2 = new Ogrenci();
        private void Form1_Load(object sender, EventArgs e)
        {
            ogr1.AdSoyadi = " Çeyiz Tekcan";
            ogr1.OgrNo = 1;
            ogr2.AdSoyadi = "Esranur";
            ogr2.OgrNo = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ogr1.AdSoyadi + " " + ogr1.OgrNo);
            MessageBox.Show(ogr2.AdSoyadi + " " + ogr2.OgrNo);
        }
    }
}
