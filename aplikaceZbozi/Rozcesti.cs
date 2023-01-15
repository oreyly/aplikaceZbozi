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
                btEditor.Enabled = true;
            }
        }

        private void btObchod_Click(object sender, EventArgs e)
        {
            new Obchod(this).Show();
            Hide();

        }

        private void btEditor_Click(object sender, EventArgs e)
        {
            new Editace(this).Show();
            Hide();
        }

        private void btKoupeno_Click(object sender, EventArgs e)
        {
            new HistorieNakupu(this).Show();
            Hide();
        }

        private void Rozcesti_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}