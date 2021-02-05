using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Faktura // Lite osäker på om vi verkligen behöver alla dessa properties i denna klassen...??
    {
        public Bokning Bokningsnummer { get; private set; }
        public Bokning Starttid { get; private set; }
        public Bokning Sluttid { get; private set; }
        public float Totalpris { get; private set; }

        internal Faktura(Bokning bokningsnummer, Bokning starttid, Bokning sluttid, float totalpris)
        {
            Bokningsnummer = bokningsnummer;
            Starttid = starttid;
            Sluttid = sluttid;
            Totalpris = totalpris;
        }
    }
}
