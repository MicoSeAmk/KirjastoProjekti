using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class EKirja : Kirja
    {
        public double TiedostoKokoMb { get; set; }

        public override string Kuvaus()
        {
            return base.Kuvaus() + $" – E‑kirja, {TiedostoKokoMb} Mt";
        }
    }
}