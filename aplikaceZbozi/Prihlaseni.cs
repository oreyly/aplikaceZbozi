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

            WindowState = FormWindowState.Minimized;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void btPrihlas_Click(object sender, EventArgs e)
        {
            List<List<object>> vysledek = PraceSDB.ZavolejPrikaz("select Heslo from Uzivatele where Jmeno=@Jmeno", false, true, "@Jmeno".SparujS(tbJmeno.Text));
            if (vysledek.Count == 1)
            {
                if(BCrypt.Net.BCrypt.EnhancedVerify(tbHeslo.Text, Encoding.UTF8.GetString((byte[])vysledek[0][0])))
                {
                    Editace ed = new Editace();
                    ed.Show();
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

        private void btRegist_Click(object sender, EventArgs e)
        {
            new Registrace(this).Show();
            Hide();
        }

        private void Prihlaseni_Load(object sender, EventArgs e)
        {
            btPrihlas_Click(null, null);
        }
    }
}
