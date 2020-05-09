using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class__Soyut_Siniflar_
{
    abstract class Insan
    {
        public string adi { get; set; }
        public string soyadi { get; set; }
        public int yas { get; set; }
        public char cinsiyet { get; set; }
        public DateTime dogum_tarihi { get; set; }
    }
}