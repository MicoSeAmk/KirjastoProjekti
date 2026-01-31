using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KirjastoProjekti
{
    public class Kirja
    {
        public string Nimi
        { get; set; }

        public string Kirjoittaja
        { get; set; }

        public int Vuosi
        { get; set; }

        public string ISBN
        { get; set; }

        public string PalautaStr()
        {
            return $"{Nimi};{Kirjoittaja};{Vuosi};{ISBN}";
        }

        public static Kirja LuoRivista(string rivi)
        {
            var osat = rivi.Split(';');
            return new Kirja
            {
                Nimi = osat[0],
                Kirjoittaja = osat[1],
                Vuosi = int.Parse(osat[2]),
                ISBN = osat[3]
            };
        }
    }
}