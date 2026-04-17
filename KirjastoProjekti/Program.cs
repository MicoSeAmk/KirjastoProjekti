using System;

namespace KirjastoProjekti
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kirjasto kirjasto = new Kirjasto(); // Olio ohjelman ajaksi
            bool jatka = true;

            while (jatka)
            {
                Console.WriteLine("--- KIRJASTO ---");
                Console.WriteLine("1> Lisää painettu kirja");
                Console.WriteLine("2> Lisää e-kirja");
                Console.WriteLine("3> Näytä kirjat");
                Console.WriteLine("4> Tallenna");
                Console.WriteLine("5> Lataa");
                Console.WriteLine("0> Lopeta");
                Console.WriteLine("Valinta: ");

                string valinta = Console.ReadLine();

                switch (valinta)
                {
                    case "1":
                        LisaaPainettu(kirjasto);
                        break;

                    case "2":
                        LisaaEKirja(kirjasto);
                        break;

                    case "3":
                        kirjasto.TulostaKirjat();
                        break;

                    case "4":
                        kirjasto.Tallenna("kirjasto.json");
                        Console.WriteLine("Tallennettu.");
                        break;

                    case "5":
                        kirjasto.Lataa("kirjasto.json");
                        Console.WriteLine("Ladattu.");
                        break;

                    case "0":
                        jatka = false;
                        break;
                }
            }
        }

        static void LisaaPainettu(Kirjasto kirjasto)
        {
            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Kirjoittaja: ");
            string kirjoittaja = Console.ReadLine();

            Console.Write("Vuosi: ");
            int vuosi = int.Parse(Console.ReadLine());

            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Sivumäärä: ");
            int sivut = int.Parse(Console.ReadLine());

            kirjasto.LisaaKirja(new PainettuKirja(nimi, kirjoittaja, vuosi, isbn, sivut)); // PainettuKirja olio
        }

        static void LisaaEKirja(Kirjasto kirjasto)
        {
            Console.Write("Nimi: ");
            string nimi = Console.ReadLine();

            Console.Write("Kirjoittaja: ");
            string kirjoittaja = Console.ReadLine();

            Console.Write("Vuosi: ");
            int vuosi = int.Parse(Console.ReadLine());

            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Tiedostokoko (MB): ");
            double koko = double.Parse(Console.ReadLine());

            kirjasto.LisaaKirja(new EKirja(nimi, kirjoittaja, vuosi, isbn, koko)); // E-kirja olio
        }
    }
}