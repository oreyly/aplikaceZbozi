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
    public partial class Editace : Form
    {
        public Editace()
        {
            InitializeComponent();
            NactiStrom();
        }

        private void NactiStrom()
        {
            Kategorie.NactiKategorie();
            stromKategorii.Nodes.Clear();
            listZbozi.Items.Clear();

            TreeNode tnc = stromKategorii.Nodes.Add(Kategorie.hlavniKategorie.Nazev);
            VytahniPodkategorie(Kategorie.hlavniKategorie, tnc);
            stromKategorii.SelectedNode = stromKategorii.Nodes[0];
            stromKategorii.ExpandAll();
        }

        private void VytahniPodkategorie(Kategorie kat, TreeNode tn)
        {
            foreach (Kategorie k in kat.Deti)
            {
                TreeNode tnc = tn.Nodes.Add(k.Nazev);
                VytahniPodkategorie(k, tnc);
            }
        }

        private void Editace_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hide();
            Environment.Exit(0);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listZbozi.Items.Clear();
            listZbozi.Items.AddRange(Kategorie.vsechnyKategorie[e.Node.Text].zbozi.Select(z => z.Nazev).ToArray());
            listBox1_SelectedIndexChanged(null, null);

            lbNadKategorieKategorie.Text = cbxUpravaKategorie.Checked ? e.Node.Text : e.Node.Parent != null ? e.Node.Parent.Text : "---";
            lbNadKategorieZbozi.Text = e.Node.Text;
            if (!cbxUpravaKategorie.Checked)
            {
                tbKategorieNazev.Text = e.Node.Text;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listZbozi.SelectedItem == null)
            {
                tbNazevZbozi.Text = "";
                tbPopisZbozi.Text = "";
                nudCenaZbozi.Value = 0;
                nudMnozstviZbozi.Value = 0;
            }
            else
            {
                Zbozi z = Zbozi.vsechnoZbozi[(string)listZbozi.SelectedItem];

                tbNazevZbozi.Text = z.Nazev;
                tbPopisZbozi.Text = z.Popis;
                nudCenaZbozi.Value = z.Cena;
                nudMnozstviZbozi.Value = z.Mnozstvi;
            }
        }

        private void btOdstranKategorii_Click(object sender, EventArgs e)
        {
            Kategorie kat = Kategorie.vsechnyKategorie[stromKategorii.SelectedNode.Text];
            if (kat.Deti.Count > 0)
            {
                MessageBox.Show("Kategorie obsahuje podkategorie, tudíž nelze odstranit!");
            }
            else if (kat.zbozi.Count > 0)
            {
                MessageBox.Show("Kategorie obsahuje zboží, tudíž nelze odstranit!");
            }
            else if (MessageBox.Show($"Opravdu si přeješ odstranit kategorii '{kat.Nazev}'?", "Odstranění kategorie", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    PraceSDB.ZavolejPrikaz("delete kk from kategorie_kategorie as kk inner join Kategorie as k on kk.diteId=k.Id where k.Nazev=@nazev;", false, false, "@nazev".SparujS(kat.Nazev));
                    PraceSDB.ZavolejPrikaz("delete from Kategorie where Nazev=@nazev", false, false, "@nazev".SparujS(kat.Nazev));
                    NactiStrom();
                }
                catch
                {
                    MessageBox.Show("Kategorii nelze odstranit");
                }
            }
        }

        private void btOdstranZbozi_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = Zbozi.vsechnoZbozi[(string)listZbozi.SelectedItem];

            bool nekdoVlastni = PraceSDB.ZavolejPrikaz("select * from Uzivatel_zbozi as uz inner join Zbozi as z on uz.zboziId=z.Id where z.Nazev=@nazev;", false, true, "@nazev".SparujS(zbozi.Nazev)).Count > 0;
            if (nekdoVlastni)
            {
                MessageBox.Show("Zboží již někdo zakoupil, tudíž musí zůstat v historii a nelze odstranit!");
            }
            else if (MessageBox.Show($"Opravdu si přeješ odstranit zboží '{zbozi.Nazev}'?", "Odstranění zboží", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    PraceSDB.ZavolejPrikaz("delete zk from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id where z.Nazev=@nazev;", false, false, "@nazev".SparujS(zbozi.Nazev));
                    PraceSDB.ZavolejPrikaz("delete Zbozi where Nazev=@nazev;", false, false, "@nazev".SparujS(zbozi.Nazev));
                    NactiStrom();
                }
                catch
                {
                    MessageBox.Show("Kategorii nelze odstranit");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NactiStrom();
        }

        private void cbxUpravaKategorie_CheckedChanged(object sender, EventArgs e)
        {
            ((CheckBox)sender).Text = ((CheckBox)sender).Checked ? "Nová kategorie" : "Editování existující";
            if (((CheckBox)sender).Checked)
            {
                tbKategorieNazev.Text = "";
            }
            treeView1_AfterSelect(stromKategorii, new TreeViewEventArgs(stromKategorii.SelectedNode));
        }

        private void btUlozitKategorii_Click(object sender, EventArgs e)
        {
            if (cbxUpravaKategorie.Checked)
            {
                try
                {
                    int idDite = Convert.ToInt32(PraceSDB.ZavolejPrikaz("insert into Kategorie(Nazev) values (@nazev); SELECT SCOPE_IDENTITY();", false, true, "@nazev".SparujS(tbKategorieNazev.Text))[0][0]);
                    int idRodic = (int)PraceSDB.ZavolejPrikaz("select id from Kategorie where nazev=@nazev;", false, true, "@nazev".SparujS(lbNadKategorieKategorie.Text))[0][0];
                    PraceSDB.ZavolejPrikaz($"insert into kategorie_kategorie(rodicId, diteId) values ({idRodic},{idDite})", false, false);
                    NactiStrom();
                }
                catch
                {
                    MessageBox.Show("Kategorie již existuje");
                }
            }
            else
            {
                if (stromKategorii.SelectedNode.Text == Kategorie.hlavniKategorie.Nazev)
                {
                    MessageBox.Show("Nelze editovat nejvyšší kategorii!");
                }
                else
                {
                    if (stromKategorii.SelectedNode.Text == tbKategorieNazev.Text)
                    {
                        MessageBox.Show("Název nesmí být stejný!");
                    }
                    else if (string.IsNullOrWhiteSpace(tbKategorieNazev.Text))
                    {
                        MessageBox.Show("Název nesmí být prázdný!");
                    }
                    else
                    {
                        try
                        {
                            PraceSDB.ZavolejPrikaz("update Kategorie set Nazev=@novyNazev where Nazev=@staryNazev;", false, false, "@novyNazev".SparujS(tbKategorieNazev.Text), "@staryNazev".SparujS(stromKategorii.SelectedNode.Text));
                            NactiStrom();
                        }
                        catch
                        {
                            MessageBox.Show("Kategorie již existuje");
                        }
                    }
                }
            }
        }

        private void cbxUpravaZbozi_CheckedChanged(object sender, EventArgs e)
        {
            ((CheckBox)sender).Text = ((CheckBox)sender).Checked ? "Nové zboží" : "Editování existujícího";
            if (((CheckBox)sender).Checked)
            {
                tbNazevZbozi.Text = "";
                tbPopisZbozi.Text = "";
                nudCenaZbozi.Value = 0;
                nudMnozstviZbozi.Value = 0;
            }
            else
            {
                listBox1_SelectedIndexChanged(listZbozi, null);
            }
        }

        private void btUlozitZbozi_Click(object sender, EventArgs e)
        {
            if (cbxUpravaKategorie.Checked)
            {
                if (stromKategorii.SelectedNode.Text == Kategorie.hlavniKategorie.Nazev)
                {
                    MessageBox.Show("Nelze vytvořit zboží v nejvyšší kategorii!");
                }
                else
                {
                    try
                    {
                        //Hír si skončil
                        int idDite = Convert.ToInt32(PraceSDB.ZavolejPrikaz("insert into Kategorie(Nazev) values (@nazev); SELECT SCOPE_IDENTITY();", false, true, "@nazev".SparujS(tbKategorieNazev.Text))[0][0]);
                        int idRodic = (int)PraceSDB.ZavolejPrikaz("select id from Kategorie where nazev=@nazev;", false, true, "@nazev".SparujS(lbNadKategorieZbozi.Text))[0][0];
                        PraceSDB.ZavolejPrikaz($"insert into kategorie_kategorie(rodicId, diteId) values ({idRodic},{idDite})", false, false);
                        NactiStrom();
                    }
                    catch
                    {
                        MessageBox.Show("Kategorie již existuje");
                    }
                }
            }
            else
            {
                if (stromKategorii.SelectedNode.Text == Kategorie.hlavniKategorie.Nazev)
                {
                    MessageBox.Show("Nelze editovat nejvyšší kategorii!");
                }
                else
                {
                    if (stromKategorii.SelectedNode.Text == tbKategorieNazev.Text)
                    {
                        MessageBox.Show("Název nesmí být stejný!");
                    }
                    else if (string.IsNullOrWhiteSpace(tbKategorieNazev.Text))
                    {
                        MessageBox.Show("Název nesmí být prázdný!");
                    }
                    else
                    {
                        try
                        {
                            PraceSDB.ZavolejPrikaz("update Kategorie set Nazev=@novyNazev where Nazev=@staryNazev;", false, false, "@novyNazev".SparujS(tbKategorieNazev.Text), "@staryNazev".SparujS(stromKategorii.SelectedNode.Text));
                            NactiStrom();
                        }
                        catch
                        {
                            MessageBox.Show("Kategorie již existuje");
                        }
                    }
                }
            }
        }
    }
}
