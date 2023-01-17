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
        //Načtení souboru s databází
        private static void NajdiDB()
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = false,
                ValidateNames = false
            };


            bool vys = false;
            do
            {
                DialogResult res = ofd.ShowDialog();
                if (res == DialogResult.OK)
                {
                    vys = PraceSDB.PripojDB(ofd.FileName); //Zkusí připojit soubor s DB
                }
                else
                {
                    Environment.Exit(0); //V případě zavření okna bez vybrání souboru vypne program
                }
            } while (!vys);
        }
        /// <summary>
        /// Hlavní vstupní bod aplikace.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            NajdiDB(); //Načte DB před spuštěním programu
            Application.Run(new Prihlaseni());
        }
    }
}
