using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(textBox1.Text);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //TxtYas.Text = DateTime.Now.ToString();
            //TxtYas.Text = dateTimePicker1.Value.ToString();
            DateTime dTarihi = dateTimePicker1.Value;
            DateTime simdi = DateTime.Now;
            int yas = simdi.Year - dTarihi.Year;
            TxtYas.Text = yas.ToString();
            TxtYas.Text = ((simdi - dTarihi).TotalDays).ToString();
           
        }
    }
}
