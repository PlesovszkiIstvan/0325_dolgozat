using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_0325
{
    internal class Kolcsonzok
    {
        public string nev { get; set; }
        public DateTime szulIdo { get; set; }

        public Kolcsonzok(string nev, DateTime szulido)
        {
            this.nev = nev;
            this.szulIdo = szulido;
        }
    }
}
