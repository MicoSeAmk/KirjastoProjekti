using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class EKirja : Kirja
    {
        public double TiedostoKokoMb { get; set; }

        public EKirja() { }

        public EKirja(string nimi, string kirjoittaja, int vuosi, string isbn, double koko) : base(nimi, kirjoittaja, vuosi, isbn)
        {
            TiedostoKokoMb = koko;
        }

        public override string Kuvaus()
        {
            return base.Kuvaus() + $" – E‑kirja, {TiedostoKokoMb} Mt";
        }
    }
}