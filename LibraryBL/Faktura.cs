using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Faktura
    {
        public Bokning Bokning { get; private set; }
        public int Bokningsnummer { get { return Bokning.Bokningsnummer; } }
        public int Medlemsnummer { get { return Bokning.Medlem.Medlemsnummer; } }
        public string Boktitel { get { return Bokning.Bok.Titel; } }
        public double Totalpris { get; private set; }
        public double ÅterståendeSumma { get; set; }

        public Bokning bokning
        {
            get => default;
            set
            {
            }
        }

        internal Faktura(Bokning bokning, double totalpris)
        {
            Bokning = bokning;
            Totalpris = totalpris;
            ÅterståendeSumma = totalpris;
        }
    }
}
