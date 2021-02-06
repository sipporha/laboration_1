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
        public Bok Bok { get; set; }
        public int ISBN { get { return Bok.ISBN; } }
        public string Boknamn { get { return Bok.Titel; } }
        public Medlem Medlem { get; set; }
        public DateTime Starttid { get; private set; }
        public DateTime Sluttid { get; private set; }
        public bool Återlämnad { get; set; }

        
        public Bokning(Bok bok, Medlem medlem, DateTime starttid, DateTime sluttid)
        {
            Bok = bok;
            Medlem = medlem;
            Starttid = starttid;
            Sluttid = sluttid;
        }
        
    }
}
