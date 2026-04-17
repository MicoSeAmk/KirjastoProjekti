using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class PainettuKirja : Kirja
    {
        public int Sivumaara { get; set; }

        public PainettuKirja() { }

        public PainettuKirja(string nimi, string kirjoittaja, int vuosi, string isbn, int sivut) : base(nimi, kirjoittaja, vuosi, isbn)
        {
            Sivumaara = sivut;
        }

        public override string Kuvaus()
        {
            return base.Kuvaus() + $" – Painettu kirja, {Sivumaara} sivua";
        }
    }
}