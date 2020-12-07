using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reizen.Models;

namespace Reizen
{


    class Program
    {
        private static Reisbureau[] reisbureaus = new Reisbureau[3];
        private static Reis[] reizen = new Reis[3];
        private static Persoon[] personen = new Persoon[3];
        private static ReisReservatie[] reisreservaties = new ReisReservatie[3];

     //   private static readonly object vertrekDatum;

        static void Main(string[] args)
        {
            InitReisbureaus();
            InitPersonen();
            InitReizen();
            InitReisReservatie();
            InitLogs();

            Console.WriteLine("Kostprijs reis :{0:N2} euro", reisreservaties[1].Reis.BerekenPrijs());

        }
        static void InitReisReservatie()
        {
            reisreservaties[0] = new ReisReservatie(reizen[0], reisbureaus[1], personen[0]);
            reisreservaties[1] = new ReisReservatie(reizen[1], reisbureaus[0], personen[1]);
            reisreservaties[2] = new ReisReservatie(reizen[2], reisbureaus[2], personen[2]);
           

        }

        static void InitReisbureaus()
        {
            reisbureaus[0] = new Reisbureau
            {
                Naam = "TUI",
                Adres = new Adres
                {
                  
                    Gemeente = "Uccle",
                    HuisNr = " 819",
                    Postcode = 1180,
                    Straat = "Chaussée d'Alsemberg"
                }

            };

            reisbureaus[1] = new Reisbureau
            {
                Naam = "GIGATOUR",
                Adres = new Adres
                {

                    Gemeente = "Bruxelles",
                    HuisNr = " 59",
                    Postcode = 1050,
                    Straat = "Chaussée de Waterloo"


                }

            };
            reisbureaus[2] = new Reisbureau
            {
                Naam = "Corendon",
                Adres = new Adres
                {

                    Gemeente = "Zaventem",
                    HuisNr = " 3",
                    Postcode = 1930,
                    Straat = "Brussels Airport Level "
                }

            };


        }

        static void InitReizen()
        {
            reizen[0] = new VliegtuigVakantie(new DateTime(2020,10,14), new DateTime(2020, 11, 12), 4,100);
            reizen[1] = new Cruise(new DateTime(2020, 11, 8), new DateTime(2020, 11, 24), 6, true);
            reizen[2] = new Autovakantie(new DateTime(2020, 12, 14), new DateTime(2020, 12, 28), 4, true);


        }

        static void InitLogs()
        {
            foreach (var message in LoggerService.logs)
            {
                Console.WriteLine("{0}:{1}", message.ID, message.Boodschap);
            }
        }
        static void InitPersonen()
        {
        
            personen[0] = new Persoon
            {

                Familienaam = "Rodgers",
             
                Voornaam = "Aaron",
                Adres = new Adres
                {

                    Gemeente = "Zaventem",
                    HuisNr = " 3",
                    Postcode = 1930,
                    Straat = "Brussels Airport Level "
                }

            };
            personen[1] = new Persoon
            {

                Familienaam = "Hurts",
                Voornaam = "Jalen",
                Adres = new Adres
                {

                    Gemeente = "Jette",
                    HuisNr = " 3",
                    Postcode = 1810,
                    Straat = "Bld du Souverain"
                }

            };
            personen[2] = new Persoon
            {

                Familienaam = "Bridgewater",

                Voornaam = "Teddy",
                Adres = new Adres
                {

                    Gemeente = "Uccle",
                    HuisNr = "32",
                    Postcode = 1190,
                    Straat = "Gatti de gamond "
                }

            };




        }


    }

}