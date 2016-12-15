using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                panelTravego.Visible = true;
                panelSetra.Visible = false;
                int counter = 1;
                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 11) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + "";
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = (btn.Width * j);
                            btn.Top = (btn.Height * i);
                            panelTravego.Controls.Add(btn);
                            //this.Controls.Add(btn);
                            counter++;
                        }

                    }
                }
            }
            else
            {
                int counter = 1;
                panelTravego.Visible = false;
                panelSetra.Visible = true;
                for (int i = 0; i < 13; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if ((j != 2 || i == 12) && (i != 6 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Click += Button_Click;
                            btn.Width = 30;
                            btn.Height = 30;
                            btn.Text = counter + "";
                            btn.BackColor = Color.FromArgb(135, 144, 180);
                            btn.Left = (btn.Width * j);
                            btn.Top = (btn.Height * i);
                            panelSetra.Controls.Add(btn);
                            //this.Controls.Add(btn);
                            counter++;
                        }

                    }
                }
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            LabelKoltukNo.Text = secilenKoltuk.Text;
            LabelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelSetra.Visible = false;
            panelTravego.Visible = false;
        }
        string[] travegoYolcularisim = new string[60];
        string[] setraYolcularisim = new string[60];
        string[] travegoYolcularcinsiyet = new string[60];
        string[] setraYolcularcinsiyet = new string[60];
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            if (LabelOtobusTuru.Text == "Travego")
            {
                travegoYolcularisim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;
                string cinsiyet;
                if (RBtnErkek.Checked)
                {
                    cinsiyet = "erkek";
                }
                else
                {
                    cinsiyet = "kadın";
                }
                travegoYolcularcinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            else
            {
                setraYolcularisim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;
                string cinsiyet;
                if (RBtnErkek.Checked)
                {
                    cinsiyet = "erkek";
                }
                else
                {
                    cinsiyet = "kadın";
                }
                setraYolcularcinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
        }

    }

}
}
