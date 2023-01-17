using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public static class HlavniStatik
    {
        public const string NAZEV_HLAVNI_KATEGORIE = "Nejvyssi"; //Název nejvyšší kategorie, která se používá pouze jako rodič všech

        public static int prihlasenyUzivatelId; //Id přihlášeného uživatele
        public static bool pouzeUzivatel; //Pomocná proměnná pro načítání zboží z DB do obchodu a historie

        //Rychlé spárování parametru jakéhokoli typu s jeho názvem (string)
        public static KeyValuePair<string,object> SparujS<T>(this string s, T druhy)
        {
            return new KeyValuePair<string, object>(s, druhy);
        }

        //Přidá prvek do pole pouze pokud již není v poli
        public static void AddIfNotExists<T>(this List<T> lis, T hodnota)
        {
            if (!lis.Contains(hodnota))
            {
                lis.Add(hodnota);
            }
        }

        //Najde a vrátí uzel ve stromě uzlů podle jeho textu
        public static TreeNode NajdiNod(this TreeNodeCollection tnc, string text)
        {
            foreach(TreeNode tn in tnc)
            {
                if (tn.Text == text)
                {
                    return tn;
                }

                TreeNode vysTN = tn.Nodes.NajdiNod(text);
                if (vysTN != null)
                {
                    return vysTN;
                }
            }

            return null;
        }

        //Převede string na int
        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
