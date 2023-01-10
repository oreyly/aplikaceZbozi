using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikaceZbozi
{
    public static class HlavniStatik
    {
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

        public static int ToInt(this string s)
        {
            return Convert.ToInt32(s);
        }
    }
}
