using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikaceZbozi
{
    public class Kategorie
    {
        public static Kategorie hlavniKategorie; //Nejvyšší kategorie, která neobsahuje žádné zboží, ale spadají pod ní všechny ostatní kategorie
        public static Dictionary<string, Kategorie> vsechnyKategorie;

        public string Nazev;
        public List<Kategorie> Rodice; //Nadřazené kategorie
        public List<Kategorie> Deti; //Podřadné kategorie

        public List<Zbozi> zbozi; //Zboží spadající do dané kategorie

        public Kategorie(string nazev, string rodic)
        {
            Nazev = nazev;
            Deti = new List<Kategorie>();
            vsechnyKategorie.Add(nazev, this);

            if (string.IsNullOrEmpty(rodic)) //Pokud není zadán rodič a bude přidán až později
            {

            }
            else if (vsechnyKategorie.ContainsKey(rodic)) //Pokud rodič již existuje, přiřadí mu další kategorii (sebe)
            {
                Rodice = new List<Kategorie>() { vsechnyKategorie[rodic] };
                if (!Rodice[0].Deti.Contains(this))
                {
                    Rodice[0].Deti.Add(this);
                }
            }
            else //Pokud rodič ještě není vytvořen, tak vytvořen bude
            {
                Kategorie kat = new Kategorie(rodic, null);
                kat.Deti.Add(this);
            }

            NactiZbozi();
        }

        //Načtení zboží, jenž spadá do této kategorie
        private void NactiZbozi()
        {
            List<List<object>> dataOZbozi;
            if (HlavniStatik.pouzeUzivatel) //Načtení zboží pouze pro daného uživatele (historie nákupů)
            {
                Dictionary<int, int> idecka = PraceSDB.ZavolejPrikaz("select zboziId, count(zboziId) as Mnozstvi from Uzivatel_zbozi where uzivatelId=@id group by zboziId;", false, true, "@id".SparujS(HlavniStatik.prihlasenyUzivatelId)).ToDictionary(radek => Convert.ToInt32(radek[0]), radek => Convert.ToInt32(radek[1]));
                if (idecka.Count == 0) //Případ, kdy nic ještě nekoupil
                {
                    dataOZbozi = new List<List<object>>();
                }
                else
                {
                    dataOZbozi = PraceSDB.ZavolejPrikaz($"select z.Id, z.Nazev, z.Popis, z.Cena from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id inner join Kategorie as k on zk.kategorieId=k.Id where k.Nazev=@kat and z.Id in ({string.Join(",", idecka.Keys)});", false, true, "@kat".SparujS(Nazev));
                    dataOZbozi.ForEach(radek => radek.Add(idecka[Convert.ToInt32(radek[0])]));
                }
            }
            else //Načtení všeho zboží
            {
                dataOZbozi = PraceSDB.ZavolejPrikaz("select z.Id, z.Nazev, z.Popis, z.Cena, z.Mnozstvi from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id inner join Kategorie as k on zk.kategorieId=k.Id where k.Nazev=@kat;", false, true, "@kat".SparujS(Nazev));
            }

            zbozi = new List<Zbozi>();
            foreach(List<object> dato in dataOZbozi)
            {
                if (!Zbozi.vsechnoZbozi.ContainsKey((string)dato[1])) //Vytvoření zboží, pokud již neexistuje
                {
                    zbozi.Add(new Zbozi((string)dato[1], (string)dato[2], (int)dato[3], (int)dato[4], this));
                }
                else //Přiřazení existujícího zboží do kategorie 
                {
                    Zbozi.vsechnoZbozi[(string)dato[1]].kategorie.Add(this);
                    zbozi.Add(Zbozi.vsechnoZbozi[(string)dato[1]]);
                }
            }
        }

        //Načte všechny kategorie a rozřadí do podkategorií
        public static void NactiKategorie()
        {
            vsechnyKategorie = new Dictionary<string, Kategorie>();
            Zbozi.vsechnoZbozi = new Dictionary<string, Zbozi>();

            //Načte všechny dvojice kategorií (rodič-dítě)
            List<List<string>> nacteneKategorie = PraceSDB.ZavolejPrikaz("SELECT k.Nazev, k2.Nazev from kategorie_kategorie as kk inner join Kategorie as k on kk.rodicId=k.Id inner join Kategorie as k2 on kk.diteId=k2.Id;", false, true).Select(radek => radek.Select(sloupec => (string)sloupec).ToList()).ToList();
            foreach (List<string> radek in nacteneKategorie)
            {
                if (vsechnyKategorie.ContainsKey(radek[1])) //Pokud dítě je již načtené
                {
                    if (vsechnyKategorie.ContainsKey(radek[0])) //Pokud rodič je již načtený, pouze se vzájemně k sobě přiřadí
                    {
                        vsechnyKategorie[radek[0]].Deti.AddIfNotExists(vsechnyKategorie[radek[1]]);
                        vsechnyKategorie[radek[1]].Rodice.AddIfNotExists(vsechnyKategorie[radek[0]]);
                    }
                    else //Pokud rodič ještě načtený není, vytvoří se a vzájemně se přiřadí
                    {
                        Kategorie kat = new Kategorie(radek[0], null);
                        kat.Deti.Add(vsechnyKategorie[radek[1]]);
                    }
                }
                else //Pokud dítě ještě není načtené, vytvoří se a při tvorbě i přiřadí rodič
                {
                    new Kategorie(radek[1], radek[0]);
                }
            }

            hlavniKategorie = vsechnyKategorie[HlavniStatik.NAZEV_HLAVNI_KATEGORIE]; //Označení nejvyšší kategorie, 
        }
    }
}
