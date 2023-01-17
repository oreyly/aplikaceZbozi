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
    public partial class Rozcesti : Form
    {
        public Rozcesti(bool jeAdmin)
        {
            InitializeComponent();
            if (jeAdmin)
            {
                btEditor.Enabled = true; //Povolení editoru v případě, že je uživatel administrátor
            }
        }

        //Otevření obchodu
        private void btObchod_Click(object sender, EventArgs e)
        {
            new Obchod(this).Show();
            Hide();

        }

        //Otevření editoru
        private void btEditor_Click(object sender, EventArgs e)
        {
            new Editace(this).Show();
            Hide();
        }

        //Otevření historie koupeného zboží
        private void btKoupeno_Click(object sender, EventArgs e)
        {
            new HistorieNakupu(this).Show();
            Hide();
        }

        //Ukončení celé aplikace
        private void Rozcesti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Ukončení celé aplikace
        private void btKonec_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}