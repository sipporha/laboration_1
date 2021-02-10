using System;
using LibraryBL.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LibraryBL
{
    public class Main
    {
        private static Main main;
        private LibraryData libraryData;
        public int bokningsnummer = 0;

        /// <summary>
        /// Skapar en ny instans av main som fungerar som en Singleton klass.
        /// </summary>
        /// <returns></returns>
        public static Main Start()
        {
            if (main == null)
            {
                main = new Main();
            }
            return main;

        }

        /// <summary>
        /// Denna metod skapar och alddar in all data programmet har att jobba med.
        /// </summary>
        public Main()
        {
            libraryData = new LibraryData();
        }

        /// <summary>
        /// Metod som kallas på när man försöker logga in i systemet som jämför inmatade inloggningsuppgifter mot de användare som finns lagrade.
        /// </summary>
        /// <param name="användarnamn"></param>
        /// <param name="lösenord"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Skapar en ny bokning med ett låneintervall på 30 dagar.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="m"></param>
        public void LäggTillBokning(Bok b, Medlem m)
        {
            Bokning bokning = new Bokning(++bokningsnummer,b,m,DateTime.Now,DateTime.Now.AddDays(30));
            libraryData.bokningsRepository.Tabell.Add(bokning);
        }

        /// <summary>
        /// Skapar en faktura endast om en bokning passerat 30 dagar.
        /// </summary>
        /// <param name="bokning"></param>
        /// <param name="totalpris"></param>
        public void SkapaFaktura(Bokning bokning, double totalpris)
        {
            Faktura faktura = new Faktura(bokning,totalpris);
            bokning.Faktura = faktura;

        }

        public List<Faktura> HämtaFaktura()
        {
            List<Faktura> Fakturor = new List<Faktura>();
            foreach (var item in libraryData.bokningsRepository.Tabell)
            {
                if (item.Faktura!=null)
                {
                   Fakturor.Add(item.Faktura);
                }
            }
            return Fakturor;
        }
    }

}
