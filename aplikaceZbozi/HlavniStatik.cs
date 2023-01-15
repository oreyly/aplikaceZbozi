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
        public static int prihlasenyUzivatelId = 4;
        public static bool pouzeUzivatel;

        public static KeyValuePair<string,object> SparujS<T>(this string s, T druhy)
        {
            return new KeyValuePair<string, object>(s, druhy);
        }

        public static void AddIfNotExists<T>(this List<T> lis, T hodnota)
        {
            if (!lis.Contains(hodnota))
            {
                lis.Add(hodnota);
            }
        }

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

        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
