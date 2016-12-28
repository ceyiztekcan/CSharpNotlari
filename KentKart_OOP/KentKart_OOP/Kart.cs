using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KentKart_OOP
{
   public enum YolcuTipi
    {
        Tam,
        ogrenci,
        ogretmen
    };
  public  class Kart
    {
        private double _bakiye;
        public double bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value<0)
                {
                   MessageBox.Show("Bakiye yetersiz");
                }
                else
                {
                    _bakiye = value;
                }
            }
        }
        public int kartID { get; set; }
        public YolcuTipi KartTuru { get; set; }

        public virtual void Okut ()
        {
            MessageBox.Show("Biniş Başarılı! Kalan Bakiye :" + (bakiye-3));
            bakiye -= 3;
        }
        public override string ToString()
        {
            return  this.kartID + "\t" + this.bakiye + "\t" + "-"+ "\t" + this.KartTuru;
        }
    }
}
