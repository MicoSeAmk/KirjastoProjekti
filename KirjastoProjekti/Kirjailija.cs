using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class Kirjailija
    {
        public string Nimi { get; set; }
        public string Maa { get; set; }

        public Kirjailija(string nimi, string maa = "Tuntematon")
        {
            Nimi = nimi;
            Maa = maa;
        }

        public override string ToString()
        {
            return $"{Nimi} ({Maa})";
        }
    }
}