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

        public void NactiStrom(ListView lv = null)
        {
            Kategorie.NactiKategorie();
            Nodes.Clear();
            if (lv != null)
            {
                lv.Items.Clear();
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
