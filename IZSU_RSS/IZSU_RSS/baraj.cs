using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class baraj
    {
        public static DateTime tarih;
        public string ad { get; set; }
        public string dolulukYuzde { get; set; }
        public baraj(string ad, string doluluk)
        {
            this.ad = ad;
            this.dolulukYuzde = doluluk;
        }
        public override string ToString()
        {
            return this.ad+ "\t\t"+"%"+this.dolulukYuzde;
        }
    }
}
