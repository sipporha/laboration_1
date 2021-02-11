using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
   public class Personal
    {
        public int Id { get; private set; }
        public string Förnamn { get; private set;}
        public string Efternamn { get; private set; }
        public string TelefonNummer { get; private set; }
        public string Epost { get; private set; }
        public string Lösenord { get; private set; }

        public Bokning Bokar
        {
            get => default;
            set
            {
            }
        }

        // public string Roll { get; private set; } Skapad och förberedd för chefsapplikation

        internal Personal(int anställningsnummer,string lösenord, string förnamn, string efternamn, string telefonnummer, string epost )
        {
            Id = anställningsnummer;
            Lösenord = lösenord;
            Förnamn = förnamn;
            Efternamn = efternamn;
            TelefonNummer = telefonnummer;
            Epost = epost;
        }

       
    }
}
