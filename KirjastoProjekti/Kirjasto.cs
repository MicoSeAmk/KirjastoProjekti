using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;

namespace KirjastoProjekti
{
    public class Kirjasto : ITallennettava // toteutetaan rajapintaa
    {
        public List<Kirja> Kirjat { get; set; } = new(); // dynamiikkaa, oliokokoelma

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
            }
        }

        public void Tallenna(string polku)
        {
            var json = JsonSerializer.Serialize(Kirjat, new JsonSerializerOptions
            { // tallenna olio data
                WriteIndented = true
            });
            // tallenna
            File.WriteAllText(polku, json);
        }

        public void Lataa(string polku)
        { // lataa
            if (!File.Exists(polku))
            {
                Console.WriteLine("Tiedostoa ei löydy");
                return;
            }

            var json = File.ReadAllText(polku);
            Kirjat = JsonSerializer.Deserialize<List<Kirja>>(json);
        } // lataa oliodata
    }
}