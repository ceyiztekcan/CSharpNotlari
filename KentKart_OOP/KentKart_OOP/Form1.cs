using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        Kart tam = new Kart();
        int kartid=1;
       

        private void Form1_Load(object sender, EventArgs e)  
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (RBtnOgrenci.Checked==true)
            {
                ogrenci.bakiye = Convert.ToDouble(TxtBBakiye.Text);
                ogrenci.kartID = kartid;
                kartid++;
                ogrenci.okulAdi = TxtBOkulAdi.Text;
                ogrenci.KartTuru = YolcuTipi.ogrenci;
                LstBoxYolcular.Items.Add(ogrenci); 
            }
            else if (RbtnOgretmen.Checked==true)
            {
               ogretmen.bakiye = Convert.ToDouble(TxtBBakiye.Text);
                ogretmen.kartID = kartid;
                ogretmen.KartTuru = YolcuTipi.ogretmen;

                kartid++;
               
                LstBoxYolcular.Items.Add(ogretmen);
            }
            else
            {
                tam.bakiye = Convert.ToDouble(TxtBBakiye.Text);
                tam.kartID = kartid;
                tam.KartTuru = YolcuTipi.Tam;
                kartid++;
                LstBoxYolcular.Items.Add(tam);
            }
            Temizle();
        }

        private void RBtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            GboxOkulAdi.Enabled = RBtnOgrenci.Checked == true ? true : false;
        }

        private void LstBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
           Kart yolcu =(Kart) LstBoxYolcular.SelectedItem;
            
            if(yolcu.KartTuru==YolcuTipi.ogrenci && (yolcu.bakiye-1)>=0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut();
                LstBoxYolcular.Items.Add(ogrenci);

            }
            else if (yolcu.KartTuru == YolcuTipi.ogretmen && (yolcu.bakiye - 2) >= 0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
                ogretmen = (OgretmenKart)yolcu;
                ogretmen.Okut();
                LstBoxYolcular.Items.Add(ogretmen);
            }
            else if (yolcu.KartTuru == YolcuTipi.Tam && (yolcu.bakiye - 3) >= 0)
            {
                LstBoxYolcular.Items.RemoveAt(LstBoxYolcular.SelectedIndex);
               tam = (Kart)yolcu;
               tam.Okut();
               LstBoxYolcular.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Bakiye yetersiz");
                DialogResult result = MessageBox.Show("Bakiye Yüklemek İstermisin", "Bildirim ekranı", MessageBoxButtons.YesNo);

                if (result==DialogResult.Yes)
                {
                    Form2 frm2 = new Form2(yolcu);
                    frm2.Show();
                    this.Hide();

                }
                else
                {

                }
            }
           
           
        }
        private void Temizle()
        {
            TxtBBakiye.Clear();
            TxtBOkulAdi.Clear();
        }
    }
}
