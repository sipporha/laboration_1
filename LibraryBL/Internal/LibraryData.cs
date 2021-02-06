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
            bokRepository.Tabell.Add(new Bok(80008, "SkolAtlas 2000"));
            bokRepository.Tabell.Add(new Bok(90009, "Vilse i min egen trädgård"));
            bokRepository.Tabell.Add(new Bok(100010, "Lär dig programmera på bara 30år"));

            medlemRepository.Tabell.Add(new Medlem(1, "Lill", "Lindfors", "070-070070", "lillsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(2, "Roger", "Pontare", "072-071170", "rogersmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(3, "Pugh", "Rogefeldt", "073-072270", "pughsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(4, "Anna", "Annasson", "071-101010", "anna@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(5, "Johan", "Johansson", "072-202020", "johan@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(6, "Mona", "Monasson", "073-303030", "mona@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(7, "Ulla", "Ullasson", "074-404040", "ulla@test.mail.se"));

            /*
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10001, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10002, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10003, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10004, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10005, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10006, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10007, DateTime.Now, DateTime.Now.AddDays(5)));
            bokningsRepository.Tabell.Add(new Bokning(1, 3, 10008, DateTime.Now, DateTime.Now.AddDays(5)));
            */
        }


    }
}
