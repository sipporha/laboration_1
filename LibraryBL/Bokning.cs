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
        public int Medlemsnummer { get; private set; }
        public int ISBN { get; private set; }
        public DateTime Starttid { get; private set; }
        public DateTime Sluttid { get; private set; }

        internal Bokning(int bokningsnummer, int medlemsnummer, int isbn, DateTime starttid, DateTime sluttid )
        {
            Bokningsnummer = bokningsnummer;
            Medlemsnummer = medlemsnummer;
            ISBN = isbn;
            Starttid = starttid;
            Sluttid = sluttid;
        }
    }
}
