using System;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public partial class StromKategorii : TreeView //Třída pro usnadnění práce s TreeView
    {
        public StromKategorii()
        {
            InitializeComponent();
        }

        //Načtení kategorií do stromu
        public void NactiStrom(object o)
        {
            Kategorie.NactiKategorie();
            Nodes.Clear(); //Vyčištění existujících uzlů

            if (o != null) //Vyčištění oblasti, kam se vypisují jednotlivé kusy zboží
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
                    throw new Exception("Chyba"); //V případě předání špatného parametru, pouze testovací význam
                }
            }

            TreeNode tnc = Nodes.Add(Kategorie.hlavniKategorie.Nazev);
            VytahniPodkategorie(Kategorie.hlavniKategorie, tnc);
            SelectedNode = Nodes[0];
            ExpandAll();
        }

        //Načtení podkategorií dané kategorie
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
