using System;
using LibraryBL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL.Internal
{
    internal class LibraryData
    {
        public Repository<Bok> bokRepository { get; private set; }
        public Repository<Medlem> medlemRepository { get; private set; }
        public Repository<Personal> personalRepository { get; private set; }
        public Repository<Faktura> fakturaRepository { get; private set; }
        public Repository<Bokning> bokningsRepository { get; private set; }

        public LibraryData()
        {
            bokRepository = new Repository<Bok>();
            medlemRepository = new Repository<Medlem>();
            personalRepository = new Repository<Personal>();
            fakturaRepository = new Repository<Faktura>(); 
            bokningsRepository = new Repository<Bokning>();
            LaddaData();
        }

        /// <summary>
        /// Laddar in all data i programmet.
        /// </summary>
        public void LaddaData()
        {
            personalRepository.Tabell.Add(new Personal(1, "zlatte", "Zlatan", "Ibrahimovic", "073-123456", "zlatan@ibrahimovic.se"));
            personalRepository.Tabell.Add(new Personal(2, "admin", "Beatrice", "Ask", "073-895674", "beatrice@ask.se"));

            bokRepository.Tabell.Add(new Bok(10001, "Lär dig laga sönder"));
            bokRepository.Tabell.Add(new Bok(20002, "Stora boken om allmän lagning"));
            bokRepository.Tabell.Add(new Bok(30003, "10 steg att kringgå lagen"));
            bokRepository.Tabell.Add(new Bok(40004, "Att tänka på när körkortet är indraget"));
            bokRepository.Tabell.Add(new Bok(50005, "En guide till att överleva på prinskorv"));
            bokRepository.Tabell.Add(new Bok(60006, "Lägg ditt bakomflutna före dig"));
            bokRepository.Tabell.Add(new Bok(70007, "Bädda sängen i en sovsäck"));
            bokRepository.Tabell.Add(new Bok(80008, "Skol Atlas 2000"));
            bokRepository.Tabell.Add(new Bok(90009, "Vilse i min egen trädgård"));
            bokRepository.Tabell.Add(new Bok(100010, "Lär dig programmera på bara 30år"));

            medlemRepository.Tabell.Add(new Medlem(1, "Lill", "Lindfors", "070-070070", "lillsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(2, "Roger", "Pontare", "072-071170", "rogersmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(3, "Pugh", "Rogefeldt", "073-072270", "pughsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(4, "Anna", "Annasson", "071-101010", "anna@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(5, "Johan", "Johansson", "072-202020", "johan@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(6, "Mona", "Monasson", "073-303030", "mona@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(7, "Ulla", "Ullasson", "074-404040", "ulla@test.mail.se"));

            // Dessa två bokningar är hårdkodade endast för att illustrera att en faktura skapas 
            //och räknar ut ett totalpris eftersom de är försenade.
            // De har dessutom hårdkodade bokningsnummer, vilket annars räknas upp av programmet när en ny bokning skapas.
            bokningsRepository.Tabell.Add(new Bokning(45, bokRepository.Tabell[0], medlemRepository.Tabell[1], DateTime.Now, new DateTime(2021,02,05)));
            bokningsRepository.Tabell.Add(new Bokning(2325, bokRepository.Tabell[1], medlemRepository.Tabell[2], DateTime.Now, new DateTime(1982,05,07)));

            bokRepository.Tabell[0].Tillgänglig = false;
            bokRepository.Tabell[1].Tillgänglig = false;
        }


    }
}
