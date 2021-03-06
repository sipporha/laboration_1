﻿using System;
using LibraryBL.Internal;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

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
        /// Denna metod skapar och laddar in all data programmet har att jobba med.
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
                    MessageBox.Show($"Välkommen {x.Förnamn} {x.Efternamn}!", "Inloggningen lyckades!");
                    return true;
                }   
            }
            return false;
        }

        public IList<Medlem> HämtaMedlemmar()  // Åtgärdat namn från Singular till Plural
        {
            return libraryData.medlemRepository.Tabell;
        }

        public List<Bok> HämtaBöcker()
        {
            // Här skapas en lista för att fylla tillgängliga böcker med. Detta görs med hjälp av foreach och if-satsen som kontrollerar
            // alla böcker i tabellen men som endast väljer ut de böcker som inte är utlånade att visa i UI:t.

            List<Bok> availableBooks = new List<Bok>();

            foreach (var bok in libraryData.bokRepository.Tabell)
            {
                if (bok.Tillgänglig)
                {
                    availableBooks.Add(bok);
                }
            }
            return availableBooks;
        }

        /// <summary>
        /// Skapar en ny bokning med ett låneintervall på 30 dagar.
        /// </summary>
        /// <param name="bok"></param>
        /// <param name="medlem"></param>
        public void LäggTillBokning(Bok bok, Medlem medlem)
        {
            Bokning bokning = new Bokning(++bokningsnummer, bok, medlem, DateTime.Now, DateTime.Now.AddDays(30));
            bok.Tillgänglig = false;
            libraryData.bokningsRepository.Tabell.Add(bokning);
            MessageBox.Show("Bokning är sparad!", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Tar bort en boknig vid de fall en bokning blivit fel eller att man ångrat sig.
        /// </summary>
        public Bokning TaBortBokning(Bokning valdBokning)
        {
           
            if (DateTime.Now > valdBokning.Sluttid || valdBokning.Utlämnad==true)
            {
                MessageBox.Show("Du får inte ta bort en bokning som är försenad eller utlämnad!", "Varning!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                valdBokning.Återlämnad = true;
                valdBokning.Bok.Tillgänglig = true;
                MessageBox.Show("Bokningen har blivit borttagen!", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return valdBokning;
        }

        public Bokning GeUtBokning(Bokning valdBokning)
        {
            if (valdBokning.Utlämnad)
            {
                MessageBox.Show("Boken är redan utlämnad!", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                valdBokning.Utlämnad = true;
                MessageBox.Show($"Bokning utlämnad med bokningsnummer: {valdBokning.Bokningsnummer}", "Information");
            }
            return valdBokning;
        }

        /// <summary>
        /// Denna metod tar emot ett index från användare och avslutar vald bokning. Beronde på om den blivit försenad eller inte så kommer det skapas en faktura.
        /// </summary>
        /// <param name="bokning"></param>
        /// <returns></returns>
        public Bokning AvslutaBokning(Bokning bokning)
        {
            // Här skickas in en referens och ett index till en vald bokning från UI:t som oavsett får status Återlämnad.
            // En bok får status tillgänglig också.
            // Vid de fall en bok är försenad genomförs en matematisk uträkning på totalbelopp, samt att en faktura skapas.
            // Om en bok lämnas tillbaka i tid, skapas dock ingen faktura eftersom det är meningslöst att skapa fakturor med ett belopp på 0:-

            DialogResult svar = MessageBox.Show("Är boken återlämnad?", "Varning!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (svar == DialogResult.Yes)
            {
                bokning.Återlämnad = true;
                bokning.Utlämnad = false;
                bokning.Bok.Tillgänglig = true;
                if (DateTime.Now > bokning.Sluttid)
                {
                    SkapaFaktura(bokning);
                }
                MessageBox.Show("Boken är återlämnad", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Du måste ta boken i retur innan du kan avsluta bokningen!", "Varning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bokning;

        }

        /// <summary>
        /// Metoder skapar en lista och lägger bokade böcker i den innan den returnerar den.
        /// </summary>
        /// <returns></returns>
        public List<Bokning> HämtaBokningar() // Bytt från singular till plural
        {
            List<Bokning> notReturned = new List<Bokning>();
            foreach (var item in libraryData.bokningsRepository.Tabell)
            {
                if (!item.Återlämnad)
                {
                    notReturned.Add(item);
                }
            }
            return notReturned;
        }

        /// <summary>
        /// Skapar en faktura endast om en bokning passerat 30 dagar.
        /// </summary>
        /// <param name="bokning"></param>
        /// <param name="totalpris"></param>
        public void SkapaFaktura(Bokning bokning)
        {
            double totalpris = Math.Floor((DateTime.Now.Date - bokning.Sluttid).TotalDays * 10);
            Faktura faktura = new Faktura(bokning, totalpris);
            bokning.Faktura = faktura;
            MessageBox.Show("Bokningen var försenad och en faktura har skapats.", "Reprimand!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public List<Faktura> HämtaFaktura()
        {
            List<Faktura> Fakturor = new List<Faktura>();
            foreach (var item in libraryData.bokningsRepository.Tabell)
            {
                if (item.Faktura != null)
                {
                    Fakturor.Add(item.Faktura);
                }
            }
            return Fakturor;
        }

    }
}
