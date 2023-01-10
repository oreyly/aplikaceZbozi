using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;


namespace aplikaceZbozi
{
    public partial class Registrace : Form
    {
        Form Rodic;

        public Registrace(Form rodic)
        {
            Rodic = rodic;
            InitializeComponent();
        }

        private void Registrace_Load(object sender, EventArgs e)
        {
            Text = $"W: {Width - ClientSize.Width}; H: {Height - ClientSize.Height}";
        }

        private void btPrihlas_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            if (tbJmeno.Text != "" && tbHeslo.Text != "" && tbHeslo.Text == tbHeslo2.Text)
            {
                List<List<object>> o = PraceSDB.ZavolejPrikaz("select id from Uzivatele where Jmeno=@jmeno", false, true, "@jmeno".SparujS(tbJmeno.Text));

                if (o.Count == 0)
                {
                    byte[] heslo = Encoding.ASCII.GetBytes(BCrypt.Net.BCrypt.EnhancedHashPassword(tbHeslo.Text));
                    PraceSDB.ZavolejPrikaz("insert into Uzivatele(Jmeno, Heslo) values (@jmeno, @heslo)", false, false, "@jmeno".SparujS(tbJmeno.Text), "@heslo".SparujS(heslo));
                    Close();
                }
                else
                {
                    MessageBox.Show("Chyba");
                }
            }
        }

        private void Registrace_FormClosed(object sender, FormClosedEventArgs e)
        {
            Rodic.Show();
        }
    }
}
