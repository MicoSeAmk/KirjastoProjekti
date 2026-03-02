using System;

namespace KirjastoProjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kirjasto kirjasto = new Kirjasto();

            //Kokeillaan lisätä kuvitteellinen kirja
            kirjasto.LisaaKirja(new PainettuKirja
            {
                Nimi = "IT osaaja",
                Kirjoittaja = "Jeb Björklund",
                Vuosi = 2007,
                ISBN = "123-456",
                Sivumaara = 214
            });

            kirjasto.LisaaKirja(new EKirja
            {
                Nimi = "Tietokoneen kasaus",
                Kirjoittaja = "Julia Faber",
                Vuosi = 2012,
                ISBN = "987-654",
                TiedostoKokoMb = 3.6
            });

            kirjasto.TulostaKirjat();

            Console.ReadKey();
        }
    }
}