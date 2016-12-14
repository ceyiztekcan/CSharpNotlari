using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otobus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public int sayac = 1;
        public List<int> koltukNo = new List<int>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Btn_click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            btn.Text = sayac.ToString();
            Form2 form2 = new Form2();
            form2.kayit = sayac.ToString();
            form2.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Clear();

            if (comboBox1.SelectedItem.ToString() == "Otobus_1")
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {



                        if ((j != 2 || i == 9) && (i != 5 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 50;
                            btn.Height = 50;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            btn.Text = sayac.ToString();
                            
                            this.Controls.Add(btn);
                            koltukNo.Add(sayac);
                            btn.Click += Btn_click;

                            sayac++;

                        }


                    }

                }
            }

            if (comboBox1.SelectedItem.ToString() == "Otobus_2")
            {
                

                for (int i = 0; i < 12; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {



                        if ((j != 2 || i == 11) && (i != 6 || j < 2))
                        {
                            Button btn = new Button();
                            btn.Width = 50;
                            btn.Height = 50;
                            btn.Left = btn.Width * j;
                            btn.Top = btn.Height * i;
                            btn.Text = sayac.ToString();
                            this.Controls.Add(btn);
                            koltukNo.Add(sayac);
                            btn.Click += Btn_click;
                            sayac++;

                        }


                    }

                }

            }

        }

    }
}
