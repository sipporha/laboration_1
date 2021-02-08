using System;
using LibraryBL.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public class Main
    {
        private static Main main;
        private LibraryData libraryData;
        public int bokningsnummer = 0;

        public static Main Start()
        {
            if (main == null)
            {
                main = new Main();
            }
            return main;

        }
        public Main()
        {
            libraryData = new LibraryData();
        }
        public bool LoggaIn(string användarnamn, string lösenord)
        {
            foreach (var x in libraryData.personalRepository.Tabell)
            {
                if (x.Id == Convert.ToInt32(användarnamn) && x.Lösenord == lösenord)
                {
                    return true;
                }
            }
            return false;
        }
       
        public IList<Medlem> HämtaMedlem()
        {
            return libraryData.medlemRepository.Tabell;
            
        }

        public List<Bok> HämtaBok()
        {
            return (List<Bok>)libraryData.bokRepository.Tabell;
        }
        
        public List<Bokning> HämtaBokning()
        {
            List<Bokning> notReturned = new List<Bokning>();
            foreach (var item in libraryData.bokningsRepository.Tabell )
            {
                if (!item.Återlämnad)
                {
                    notReturned.Add(item);
                }
            }
            return notReturned;
        }
        public void LäggTillBokning(Bok b, Medlem m)
        {
            Bokning bokning = new Bokning(++bokningsnummer,b,m,DateTime.Now,DateTime.Now.AddDays(30));
            libraryData.bokningsRepository.Tabell.Add(bokning);
        }

    }

}
