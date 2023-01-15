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
    public partial class StromKategorii : TreeView
    {
        public StromKategorii()
        {
            InitializeComponent();
        }

        public void NactiStrom(object o)
        {
            Kategorie.NactiKategorie();
            Nodes.Clear();
            if (o != null)
            {
                if(o is ListBox lb)
                {
                    lb.Items.Clear();
                }
                else if(o is Panel p)
                {
                    p.Controls.Clear();
                }
                else
                {
                    throw new Exception("Vole co to tam házíš?");
                }
            }

            TreeNode tnc = Nodes.Add(Kategorie.hlavniKategorie.Nazev);
            VytahniPodkategorie(Kategorie.hlavniKategorie, tnc);
            SelectedNode = Nodes[0];
            ExpandAll();
        }

        private void VytahniPodkategorie(Kategorie kat, TreeNode tn)
        {
            foreach (Kategorie k in kat.Deti)
            {
                TreeNode tnc = tn.Nodes.Add(k.Nazev);
                VytahniPodkategorie(k, tnc);
            }
        }
    }
}
