using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Masa m = new Masa();
        Masa[] masalar = new Masa[15];
        private void Form1_Load(object sender, EventArgs e)
        {
            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button btn = new Button();
                    btn.Click += Button_Click;
                    btn.Width = 30;
                    btn.Height = 30;
                    btn.Left = (btn.Width * j);
                    btn.Top = (btn.Height * i);
                    btn.Text = counter + "";
                    panelMasa.Controls.Add(btn);
                    counter++;
                }
            }

            panelMenu.Controls.Add(ComboIcecek);
            ComboYemek.Items.Add("Kuru Fasulye");
            ComboYemek.Items.Add("Tavuklu Pilav");
            ComboYemek.Items.Add("Simit Tost");
            ComboYemek.Items.Add("Lazanya");
            ComboIcecek.Items.Add("Su");
            ComboIcecek.Items.Add("Kola");
            ComboIcecek.Items.Add("Çay");
            ComboIcecek.Items.Add("Limonata");
            ComboIcecek.Items.Add("Kahve");

        }
        private void Button_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            Button secilenMasa = sender as Button;
            LabelMasaNo.Text = secilenMasa.Text;

            if (masalar[int.Parse(LabelMasaNo.Text) - 1] != null)
            {
                foreach (var item in masalar[int.Parse(LabelMasaNo.Text) - 1].siparisList)
                {
                    listBox1.Items.Add(item);
                }
            }

            //if (ComboYemek.Text == null && ComboIcecek.Text == null)
            //{
            //    s.yemek = ComboYemek.SelectedItem.ToString();
            //    s.icecek = ComboIcecek.SelectedItem.ToString();
            //    s.adeticecek = int.Parse(numericIcecek.Value.ToString());
            //    s.adetyemek = int.Parse(numericYemek.Value.ToString());
            //    listBox1.Items.Add(s);
            //    s.siparisList.Add(s);
            //}


        }

        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            m = new Masa();

            if(ComboYemek.SelectedItem != null)
            {
                s.ad = ComboYemek.SelectedItem.ToString();
                s.adet = int.Parse(numericYemek.Value.ToString());
                m.siparisList.Add(s);
                listBox1.Items.Add(s);
            }

            if (ComboIcecek.SelectedItem != null)
            {
                s = new Siparis();
                s.ad = ComboIcecek.SelectedItem.ToString();
                s.adet = int.Parse(numericIcecek.Value.ToString());
                m.siparisList.Add(s);
                listBox1.Items.Add(s);
            }

            Masa _masa = new Masa();
            

            if (masalar[int.Parse(LabelMasaNo.Text) - 1] != null)
            {
                _masa = masalar[int.Parse(LabelMasaNo.Text) - 1];
                foreach (var item in m.siparisList)
                {
                    _masa.siparisList.Add(item);
                }
            }
            else
            {
                _masa = m;
                masalar[int.Parse(LabelMasaNo.Text) - 1] = _masa;
            }

            //s.yemek = ComboYemek.SelectedItem.ToString();
            //s.icecek = ComboIcecek.SelectedItem.ToString();
            //s.adeticecek = int.Parse(numericIcecek.Value.ToString());
            //s.adetyemek = int.Parse(numericYemek.Value.ToString());
            //listBox1.Items.Add(s);

            //s.siparisList.Add(s);

        }

        private void BtnOde_Click(object sender, EventArgs e)
        {

        }
    }
}
