﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikaceZbozi
{
    class Zbozi
    {
        public static Dictionary<string, Zbozi> vsechnoZbozi;

        public string Nazev;
        public string Popis;
        public int Cena;
        public int Mnozstvi;

        public List<Kategorie> kategorie;

        public Zbozi(string nazev, string popis, int cena, int mnozstvi, Kategorie kat)
        {
            Nazev = nazev;
            Popis = popis;
            Cena = cena;
            Mnozstvi = mnozstvi;

            kategorie = new List<Kategorie>() { kat };

            vsechnoZbozi.Add(nazev, this);
        }
    }
}
