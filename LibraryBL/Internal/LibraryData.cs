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
            bokRepository.Tabell.Add(new Bok(0001, "Lär dig laga sönder"));
            bokRepository.Tabell.Add(new Bok(0002, "Stora boken om allmän lagning"));
            bokRepository.Tabell.Add(new Bok(0003, "10 steg att kringgå lagen"));
            bokRepository.Tabell.Add(new Bok(0004, "Att tänka på när körkortet är indraget"));
            bokRepository.Tabell.Add(new Bok(0005, "En guide till att överleva på prinskorv"));
            bokRepository.Tabell.Add(new Bok(0006, "Lägg ditt bakomflutna före dig"));
            bokRepository.Tabell.Add(new Bok(0007, "Bädda sängen i en sovsäck"));
            bokRepository.Tabell.Add(new Bok(0008, "SkolAtlas 2000"));
            bokRepository.Tabell.Add(new Bok(0009, "Vilse i min egen trädgård"));
            bokRepository.Tabell.Add(new Bok(0010, "Lär dig programmera på bara 30år"));

            medlemRepository.Tabell.Add(new Medlem(1, "Lill", "Lindfors", "070-070070", "lillsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(2, "Roger", "Pontare", "072-071170", "rogersmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(3, "Pugh", "Rogefeldt", "073-072270", "pughsmail@mail.se"));
            medlemRepository.Tabell.Add(new Medlem(4, "Anna", "Annasson", "071-101010", "anna@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(5, "Johan", "Johansson", "072-202020", "johan@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(6, "Mona", "Monasson", "073-303030", "mona@test.mail.se"));
            medlemRepository.Tabell.Add(new Medlem(7, "Ulla", "Ullasson", "074-404040", "ulla@test.mail.se"));

            personalRepository.Tabell.Add(new Personal(1,"zlatte", "Zlatan", "Ibrahimovic", "073-123456","zlatan@ibrahimovic.se"));
            personalRepository.Tabell.Add(new Personal(2,"admin" ,"Beatrice", "Ask", "073-895674","beatrice@ask.se"));
        }


    }
}
