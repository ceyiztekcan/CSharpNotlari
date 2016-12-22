using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OzHakikiUlusoy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Musteri> MusteriListesi = new List<Musteri>();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.AdSoyad = TxtMusteriAd.Text;
            musteri.Cinsiyet = RbtnErkek.Checked == false ? true : false;
            musteri.otobusTuru = CboxOtobusTuru.SelectedItem.ToString();

            MusteriListesi.Add(musteri);
            LBoxMusteriler.Items.Add(musteri);
            TxtMusteriAd.Clear();
            TxtMusteriAd.Focus();
        }

        private void LBoxMusteriler_DoubleClick(object sender, EventArgs e)
        {
            LBoxMusteriler.Items.RemoveAt(LBoxMusteriler.SelectedIndex);
        }
    }
}
