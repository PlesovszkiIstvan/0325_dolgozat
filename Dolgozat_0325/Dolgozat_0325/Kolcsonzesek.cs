using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_0325
{
    internal class Kolcsonzesek
    {
        public int kolcsonzoId {get; set;}
        public string iro {get; set;}
        public string mufaj {get; set;}
        public string cim {get; set;}

        public Kolcsonzesek( int kolcsonzoid, string iro, string mufaj, string cim) {
            this.kolcsonzoId = kolcsonzoid; 
            this.iro = iro; 
            this.mufaj = mufaj;
            this.cim = cim;
        }
    }
}
