using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    static class Program
    {
        private static void NajdiDB()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = false,
                ValidateNames = false
            };

            PraceSDB.PripojDB("E:\\mvs\\aplikaceZbozi\\aplikaceZbozi\\databaze.mdf");
            return;

            bool vys = false;
            do
            {
                DialogResult res = ofd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    vys = PraceSDB.PripojDB(ofd.FileName);
                }
                else
                {
                    Environment.Exit(0);
                }
            } while (!vys);
        }
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string heslo = string.Join("", Encoding.ASCII.GetBytes(BCrypt.Net.BCrypt.EnhancedHashPassword("123")).Select(cislo => cislo.ToString("X")));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NajdiDB();
            Application.Run(new Prihlaseni());
        }
    }
}
