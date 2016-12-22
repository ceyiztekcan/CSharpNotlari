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
    public partial class Form2 : Form
    {
        public double guncelBorc;
        Abone gonderilecekAbone = new Abone();
        public Form2(Abone aboneForm2)
        {
            InitializeComponent();
            
            TxtAdSoyad.Text = aboneForm2.AdSoyad;
            TxtBMusteriTuru.Text = aboneForm2.AboneTuru;
            TxtOncekiSayac.Text = aboneForm2.OncekiSayac.ToString();
            TxtSonrakiSayac.Text = aboneForm2.SonSayac.ToString();
            TxtGuncelborc.Text = aboneForm2.OdemeHesapla(aboneForm2.OncekiSayac, aboneForm2.SonSayac, aboneForm2.AboneTuru).ToString();
            guncelBorc = double.Parse(TxtGuncelborc.Text);
            gonderilecekAbone = aboneForm2;
        }

        private void BtnOde_Click(object sender, EventArgs e)
        {
            double odeme = double.Parse(TxtGuncelborc.Text);
            DialogResult result = MessageBox.Show("ödeme tutarı?:" + odeme + "\nÖdeme yapacakmısınız?", "Ödeme Ekranı", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                Form3 frm3 = new Form3(gonderilecekAbone);
                frm3.gBorc = guncelBorc;
                frm3.Show();
            }
        }
    }
}
