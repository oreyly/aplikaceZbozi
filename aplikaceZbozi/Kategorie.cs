using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikaceZbozi
{
    public class Kategorie
    {
        public static Kategorie hlavniKategorie;
        public static Dictionary<string, Kategorie> vsechnyKategorie;

        public string Nazev;
        public List<Kategorie> Rodice;
        public List<Kategorie> Deti;

        public List<Zbozi> zbozi;

        public Kategorie(string nazev, string rodic)
        {
            Nazev = nazev;
            Deti = new List<Kategorie>();
            vsechnyKategorie.Add(nazev, this);

            if (string.IsNullOrEmpty(rodic))
            {

            }
            else if (vsechnyKategorie.ContainsKey(rodic))
            {
                Rodice = new List<Kategorie>() { vsechnyKategorie[rodic] };
                if (!Rodice[0].Deti.Contains(this))
                {
                    Rodice[0].Deti.Add(this);
                }
            }
            else
            {
                Kategorie kat = new Kategorie(rodic, null);
                kat.Deti.Add(this);
            }

            NactiZbozi();
        }

        private void NactiZbozi()
        {
            List<List<object>> dataOZbozi;
            if (HlavniStatik.pouzeUzivatel)
            {
                Dictionary<int, int> idecka = PraceSDB.ZavolejPrikaz("select zboziId, count(zboziId) as Mnozstvi from Uzivatel_zbozi where uzivatelId=@id group by zboziId;", false, true, "@id".SparujS(HlavniStatik.prihlasenyUzivatelId)).ToDictionary(radek => Convert.ToInt32(radek[0]), radek => Convert.ToInt32(radek[1]));
                if (idecka.Count == 0)
                {
                    dataOZbozi = new List<List<object>>();
                }
                else
                {
                    dataOZbozi = PraceSDB.ZavolejPrikaz($"select z.Id, z.Nazev, z.Popis, z.Cena from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id inner join Kategorie as k on zk.kategorieId=k.Id where k.Nazev=@kat and z.Id in ({string.Join(",", idecka.Keys)});", false, true, "@kat".SparujS(Nazev));
                    dataOZbozi.ForEach(radek => radek.Add(idecka[Convert.ToInt32(radek[0])]));
                }
            }
            else
            {
                dataOZbozi = PraceSDB.ZavolejPrikaz("select z.Id, z.Nazev, z.Popis, z.Cena, z.Mnozstvi from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id inner join Kategorie as k on zk.kategorieId=k.Id where k.Nazev=@kat;", false, true, "@kat".SparujS(Nazev));
            }

            zbozi = new List<Zbozi>();
            foreach(List<object> dato in dataOZbozi)
            {
                if (!Zbozi.vsechnoZbozi.ContainsKey((string)dato[1]))
                {
                    zbozi.Add(new Zbozi((string)dato[1], (string)dato[2], (int)dato[3], (int)dato[4], this));
                }
                else
                {
                    Zbozi.vsechnoZbozi[(string)dato[1]].kategorie.Add(this);
                    zbozi.Add(Zbozi.vsechnoZbozi[(string)dato[1]]);
                }
            }
        }

        public static void NactiKategorie()
        {
            vsechnyKategorie = new Dictionary<string, Kategorie>();
            Zbozi.vsechnoZbozi = new Dictionary<string, Zbozi>();

            List<List<string>> nacteneKategorie = PraceSDB.ZavolejPrikaz("SELECT k.Nazev, k2.Nazev from kategorie_kategorie as kk inner join Kategorie as k on kk.rodicId=k.Id inner join Kategorie as k2 on kk.diteId=k2.Id;", false, true).Select(radek => radek.Select(sloupec => (string)sloupec).ToList()).ToList();
            foreach (List<string> radek in nacteneKategorie)
            {
                if (vsechnyKategorie.ContainsKey(radek[1]))
                {
                    if (vsechnyKategorie.ContainsKey(radek[0]))
                    {
                        vsechnyKategorie[radek[0]].Deti.AddIfNotExists(vsechnyKategorie[radek[1]]);
                        vsechnyKategorie[radek[1]].Rodice.AddIfNotExists(vsechnyKategorie[radek[0]]);
                    }
                    else
                    {
                        Kategorie kat = new Kategorie(radek[0], null);
                        kat.Deti.Add(vsechnyKategorie[radek[1]]);
                    }
                }
                else
                {
                    new Kategorie(radek[1], radek[0]);
                }
            }

            hlavniKategorie = vsechnyKategorie["Nejvyssi"];
        }
    }
}
