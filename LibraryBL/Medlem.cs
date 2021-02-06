using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Medlem
    {
        public int Medlemsnummer { get; private set; }
        public string Förnamn { get; private set; }
        public string Efternamn { get; private set; }
        public string Telefonnummer { get; private set; }
        public string Epost { get; private set; }
        public string FullNamn { get { return $@"Medlemsnummer: {Medlemsnummer}
{Förnamn} {Efternamn}"; } }

        internal Medlem(int medlemsnummer, string förnamn, string efternamn, string telefonnummer, string epost)
        {
            Medlemsnummer = medlemsnummer;
            Förnamn = förnamn;
            Efternamn = efternamn;
            Telefonnummer = telefonnummer;
            Epost = epost;
        }


    }
}
