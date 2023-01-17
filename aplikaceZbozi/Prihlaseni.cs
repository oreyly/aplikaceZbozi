using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public partial class Prihlaseni : Form
    {
        public Prihlaseni()
        {
            InitializeComponent();

            //Minimalizace a maximalizace okna, jinak se občas stane, že aplikace zůstane po načtení databáze v pozadí
            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        //Přihlášení
        private void btPrihlas_Click(object sender, EventArgs e)
        {
            List<List<object>> vysledek = PraceSDB.ZavolejPrikaz("select Heslo, Id, Admin from Uzivatele where Jmeno=@Jmeno", false, true, "@Jmeno".SparujS(tbJmeno.Text)); //Načtení dat o uživateli z DB
            if (vysledek.Count > 0) //Zjistí, jestli uživatel s daným jménem existuje
            {
                if (BCrypt.Net.BCrypt.EnhancedVerify(tbHeslo.Text, Encoding.UTF8.GetString((byte[])vysledek[0][0]))) //Ověří heslo
                {
                    HlavniStatik.prihlasenyUzivatelId = (int)vysledek[0][1];
                    Rozcesti r = new Rozcesti((bool)vysledek[0][2]);
                    r.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Špatné heslo!");
                }
            }
            else
            {
                MessageBox.Show("Uživatelské jméno neexistuje!");
            }
        }

        //Otevře možnost registrace
        private void btRegist_Click(object sender, EventArgs e)
        {
            new Registrace(this).Show();
            Hide();
        }
    }
}
