using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Bok
    {
        public int ISBN { get; private set; }
        public string Titel { get; private set; }
        public bool Tillgänglig { get;  set; }

        internal Bok(int isbn, string titel )
        {
            ISBN = isbn;
            Titel = titel;
            Tillgänglig = true;
        }


    }
}
