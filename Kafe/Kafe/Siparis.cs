using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    class Siparis
    {
        public string ad;
        public string odemeTuru;
        
        public double fiyat
        {
            get
            {
                if (ad == "Kuru Fasulye")
                {
                    return 5;
                }
                if (ad == "Tavuklu Pilav")
                {
                    return 6;
                }
                if (ad == "Simit Tost")
                {
                    return 4;
                }
                if (ad == "Lazanya")
                {
                    return 2;

                }
                if (ad == "Su")
                {
                    return 1;
                }
                if (ad == "Kola")
                {
                    return 2;
                }
                if (ad == "Limonata")
                {
                    return 3;
                }
                if (ad == "Çay")
                {
                    return 1.5;
                }
                if (ad == "Kahve")
                {
                    return  5;
                }
                else
                {
                    return 0;
                }
            }
        }
        public int adet { get; set; }
        public override string ToString()
        {
            return ad + " adet: " + adet + " fiyat: " + fiyat;
        }
        public void OdemeHesapla(int adet,double fiyat, string tur)
        {
            double hesap = adet * fiyat;

            MessageBox.Show(hesap.ToString());
        }

    }
}
