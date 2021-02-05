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
        // test
        private static Main main;
        private LibraryData libraryData;

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

        public IList<Bok> HämtaBok()
        {
            return libraryData.bokRepository.Tabell;
        }
        
        public IList<Bokning> HämtaBokning()
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
            //return libraryData.bokningsRepository.Tabell;
        }

    }


}
