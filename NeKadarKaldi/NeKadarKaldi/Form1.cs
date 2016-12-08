using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            double gunlukUyku = Convert.ToDouble(GunlukUykuTxtB.Text);
            double yil = Convert.ToDouble(YasamTxtB.Text);

            double oran =  gunlukUyku / 24;
            double sonuc = oran * yil;
            //if (gunlukSaat <= 24)
            //{
                //int gun = 10000 / gunlukSaat;
                //int ay = gun / 30;
                //int yil = gun / 365;
                MessageBox.Show("sonuc : " + sonuc);
            //}
            //else
            //{
            //    MessageBox.Show("Günde 24 saat var!");
            //    YasamTxtB.Text = "";
            //}
        }
    }
}
