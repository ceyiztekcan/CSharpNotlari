using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz2
{
    class Abone
    {
        public string AdSoyad;
        public int ilkIndex, sonIndex;
        public bool aboneTip; //false ev, true sirket
        public override string ToString()
        {
            return this.AdSoyad + this.aboneTip + this.ilkIndex +this.sonIndex; 
        }

    }
    
}
