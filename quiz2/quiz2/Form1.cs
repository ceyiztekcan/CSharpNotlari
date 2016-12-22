using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Abone> AboneListesi = new List<Abone>();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            double odeme;

            Abone abone = new Abone();
            abone.AdSoyad = TxtBAdSoyad.Text;
            abone.aboneTip = RbtnEv.Checked == false ? false : true;
            abone.ilkIndex = int.Parse(TxtBIlkIndex.Text);
            abone.sonIndex = int.Parse(TxtBSonIndex.Text);
            AboneListesi.Add(abone);
            if (abone.aboneTip == false)
            {
                odeme = (abone.sonIndex - abone.ilkIndex) * 0.3;
            }
            else
            {
                odeme = (abone.sonIndex - abone.ilkIndex) * 0.5;
            }
            listBAbone.Items.Add(abone.AdSoyad + " " + odeme);

        }

        private void listBAbone_DoubleClick(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Ödeme Yapmak İstiyor musunuz ?", "Onay Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                listBOdenen.Items.Add(listBAbone.SelectedItem);
                listBAbone.Items.RemoveAt(listBAbone.SelectedIndex);
                MessageBox.Show("Teşekkürler Ödeme Alındı");
            }

        }
    }
}
