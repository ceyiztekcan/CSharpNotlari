using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class haberler
    {
        public string haber { get; set; }
        public string habertarih { get; set; }
        public string description { get; set; }
        public haberler(string haber, string tarih)
        {
            this.haber = haber;
            this.habertarih = tarih;
            
        }
        public override string ToString()
        {
            return this.haber +"\t\t"+this.habertarih;
        }
    }
    
}
