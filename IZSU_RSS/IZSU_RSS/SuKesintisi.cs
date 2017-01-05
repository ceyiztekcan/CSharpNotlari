using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IZSU_RSS
{
    class SuKesintisi
    {
        public string kesintiyeri { get; set; }
        public string kesintiTarihi { get; set; }
        public SuKesintisi(string yer, string tarih)
        {
            this.kesintiyeri = yer;
            this.kesintiTarihi = tarih;
        }
        public override string ToString()
        {
            return this.kesintiyeri + "\t\t\t" + this.kesintiTarihi; ;
        }
    }
}
