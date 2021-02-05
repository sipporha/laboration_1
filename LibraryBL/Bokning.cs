using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Bokning
    {
        public int Bokningsnummer { get; private set; }
        public Medlem Medlemsnummer { get; private set; }
        public Personal Anställningsnummer { get; private set; }
        public Bok Bok { get; private set; }
        public DateTime Starttid { get; private set; }
        public DateTime Sluttid { get; private set; }

        internal Bokning(int bokningsnummer, Medlem medlemsnummer, Personal anställningsnummer, Bok bok, DateTime starttid, DateTime sluttid )
        {
            Bokningsnummer = bokningsnummer;
            Medlemsnummer = medlemsnummer;
            Anställningsnummer = anställningsnummer;
            Bok = bok;
            Starttid = starttid;
            Sluttid = sluttid;
        }
    }
}
