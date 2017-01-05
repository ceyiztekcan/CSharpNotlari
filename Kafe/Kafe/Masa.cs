using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kafe
{
    class Masa
    {
        public int masaNo { get; set; }
        public double hesap { get; set; }
        public double odemeTipi { get; set; }

        public List<Siparis> siparisList;
        public Masa()
        {
            siparisList = new List<Siparis>();
        }
       
    }
}


