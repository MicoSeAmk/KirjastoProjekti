using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class Kirja : IKuvattava
    {
        public string Nimi
        { get; set; }

        public string Kirjoittaja
        { get; set; }

        public int Vuosi
        { get; set; }

        public string ISBN
        { get; set; }

        public Kirjailija Tekija
        { get; set; }

        public Kirja() { }

        public Kirja(string nimi, string kirjoittaja, int vuosi, string isbn)
        {
            Nimi = nimi;
            Kirjoittaja = kirjoittaja;
            Vuosi = vuosi;
            ISBN = isbn;
            Tekija = new Kirjailija(kirjoittaja);
        }

        public virtual string Kuvaus()
        {
            return $"{Nimi} ({Vuosi}), {Kirjoittaja}";
        }
    }
}