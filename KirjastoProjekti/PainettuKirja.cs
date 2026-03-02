using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class PainettuKirja : Kirja
    {
        public int Sivumaara { get; set; }

        public override string Kuvaus()
        {
            return base.Kuvaus() + $" – Painettu kirja, {Sivumaara} sivua";
        }
    }
}