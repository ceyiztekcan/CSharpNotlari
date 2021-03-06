﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniPortal
{
    class Ogrenci : IKisiBilgileri
    {
        private string _ad;
        private string _soyad;
        private string _tel;
        public string ad
        {
            get
            {
                return _ad;
            }

            set
            {
                _ad = value;
            }
        }

        public string soyad
        {
            get
            {
                return _soyad;
            }

            set
            {
                _soyad = value;
            }
        }

        public string telefon
        {
            get
            {
                return _tel; ;
            }

            set
            {
                _tel = value;
            }
        }

        public string BilgiGoster()
        {
            return string.Format("Ad: {0} \t Soyad: {1} \t Tel: {2}", ad, soyad, telefon);
        }
    }
}
