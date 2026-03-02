using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace KirjastoProjekti
{
    public class Kirjasto : ITallennettava
    {
        public System.Collections.Generic.List<Kirja> Kirjat
        { get; set; } = new List<Kirja>();

        public void LisaaKirja(Kirja kirja)
        { Kirjat.Add(kirja); }

        public void PoistaKirja(string isbn)
        { Kirjat.RemoveAll(k => k.ISBN == isbn); }

        public Kirja HaeKirja(string isbn)
        { return Kirjat.FirstOrDefault(k => k.ISBN == isbn); }

        public void TulostaKirjat()
        {
            foreach (var kirja in Kirjat)
            {
                Console.WriteLine(kirja.Kuvaus());
                //Console.WriteLine($"{kirja.Nimi} - {kirja.Kirjoittaja} ({kirja.Vuosi}) [{kirja.ISBN}]");
            }
        }

        public void Tallenna(string polku)
        {
            File.WriteAllLines(polku, Kirjat.Select(k => k.Kuvaus()));
            //File.WriteAllLines(polku, Kirjat.Select(k => k.PalautaStr()));
        }

        public void Lataa(string polku)
        {
            Console.WriteLine("Esimerkki yksi kaksi");

            Kirjat.Clear();
            foreach (var rivi in File.ReadAllLines(polku))
            {
                Kirjat.Add(Kirja.LuoRivista(rivi));
            }
        }
    }
}