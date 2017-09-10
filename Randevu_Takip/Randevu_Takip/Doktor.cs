using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Takip
{
    public class Doktor
    {
        public Doktor(string AdSoyad, string Brans)
        {
            this.AdSoyad = AdSoyad;
            this.Brans = Brans;
        }

        public string AdSoyad { get; set; }
        public string Brans { get; set; }

        public override string ToString()
        {
            return AdSoyad;
        }
    }
}
