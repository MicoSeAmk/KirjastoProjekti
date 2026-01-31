using System;

namespace KirjastoProjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kirjasto kirjasto = new Kirjasto();

            //Kokeillaan lisätä kuvitteellinen kirja
            kirjasto.LisaaKirja(new Kirja
            {
                Nimi = "IT osaaja",
                Kirjoittaja = "Jeb Björklund",
                Vuosi = 2007,
                ISBN = "123-456"
            });

            kirjasto.TulostaKirjat();

            Console.ReadKey();
        }
    }
}