using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    class Siparis
    {
        public string ad;

        private double _fiyat;
        public double fiyat
        {
            get
            {
                return _fiyat;
            }
            set
            {
                if (ad == "Kuru Fasulye")
                {
                    _fiyat = 5;
                }
            }
        }
        public int adet { get; set; }
        public override string ToString()
        {
            return ad + " " + adet;
        }
    }
}
