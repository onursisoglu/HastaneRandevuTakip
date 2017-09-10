using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu_Takip
{
    public class Randevu
    {
        public Hasta HastaBilgileri { get; set; }
        public Doktor DoktorBilgileri { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string RandevuSaati { get; set; }

        public override string ToString()
        {
             return HastaBilgileri.AdSoyad;
        }
    }
}
