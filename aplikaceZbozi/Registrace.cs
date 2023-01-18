using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace aplikaceZbozi
{
    public partial class Registrace : Form
    {
        Form Rodic; //Nadřazený form

        public Registrace(Form rodic)
        {
            Rodic = rodic;
            InitializeComponent();
        }

        //Přepne zpět na možnost přihlášení
        private void btPrihlas_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Uložení nového uživatele do DB
        private void btRegist_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbJmeno.Text) && tbJmeno.Text.Length > 3 && !string.IsNullOrWhiteSpace(tbHeslo.Text) && tbHeslo.Text.Length > 5 && tbHeslo.Text == tbHeslo2.Text) // Kontrola vstupních údajů
            {
                List<List<object>> o = PraceSDB.ZavolejPrikaz("select id from Uzivatele where Jmeno=@jmeno", false, true, "@jmeno".SparujS(tbJmeno.Text));

                if (o.Count == 0) //Kontrola, jestli dané uživatelské jméno již neexisture
                {
                    byte[] heslo = Encoding.ASCII.GetBytes(BCrypt.Net.BCrypt.EnhancedHashPassword(tbHeslo.Text));//Zahashování hesla
                    PraceSDB.ZavolejPrikaz("insert into Uzivatele(Jmeno, Heslo) values (@jmeno, @heslo)", false, false, "@jmeno".SparujS(tbJmeno.Text), "@heslo".SparujS(heslo)); //Uložení
                    Close();
                }
                else
                {
                    MessageBox.Show("Uživatel s tímto jménem již existuje!");
                }
            }
        }

        //Otevření rodiče(Přihlašovací okno) v případě zavření tohoto okna
        private void Registrace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Rodic.Show();
        }
    }
}
