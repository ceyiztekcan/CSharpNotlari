using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzHakikiUlusoy
{
    class Musteri
    {
        public string AdSoyad;
        public bool Cinsiyet; //false erkek, true kadin;
        public string otobusTuru;
        public override string ToString()
        {
            return this.AdSoyad + "\t" + this.Cinsiyet + "\t" + this.otobusTuru;
        }
    }
}
