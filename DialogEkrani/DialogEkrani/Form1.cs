using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text!="")
            {
                listBox1.Items.Add(TxtAd.Text);
                TxtAd.Focus();
                TxtAd.ForeColor = Color.Red;
            }        
                        
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyor musun ?:", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hepsini Silmek İstiyor musun ?:", "Onay Ekranı", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                listBox1.Items.Clear();
            }
           
        }
    }
}
