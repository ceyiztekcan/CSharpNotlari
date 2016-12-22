using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU_OOP
{
    public partial class Form3 : Form
    {
        public double gBorc;
        public Form3(Abone aboneForm3)
        {
            InitializeComponent();
            TxtBAdSoyad.Text = aboneForm3.AdSoyad;
            TxtBSonOdenen.Text = gBorc.ToString();
            double toplamBorc=0 ;
            toplamBorc += gBorc;
            TxtBToplamOdeme.Text = toplamBorc.ToString();
             
        }
    }
}
