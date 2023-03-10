using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public partial class Editace : Form
    {
        Form rodic; //Nadřazený form
        public Editace(Form f)
        {
            rodic = f;
            InitializeComponent();
            stromKategorii.NactiStrom(listZbozi);//Načte všechny kategorie
        }

        //Vrátí se do nadřazeného formu
        private void Editace_FormClosed(object sender, FormClosedEventArgs e)
        {
            rodic.Show();
        }

        //Event po vybrání kategorie
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Načtení seznamu zboží ve vybrané kategorii
            listZbozi.Items.Clear();
            listZbozi.Items.AddRange(Kategorie.vsechnyKategorie[e.Node.Text].zbozi.Select(z => z.Nazev).ToArray());
            listBox1_SelectedIndexChanged(null, null);

            //Vyplnění labelů s názvem kategorie
            lbNadKategorieKategorie.Text = cbxUpravaKategorie.Checked ? e.Node.Text : e.Node.Parent != null ? e.Node.Parent.Text : "---";
            lbNadKategorieZbozi.Text = e.Node.Text;
            if (!cbxUpravaKategorie.Checked)
            {
                tbKategorieNazev.Text = e.Node.Text;
            }
        }

        //Event po vybrání zboží v seznamu
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Pokud není nic vybráno nebo chceme dělat nové zboží, vyprázdníme všechny položky zboží
            if (listZbozi.SelectedItem == null || cbxUpravaZbozi.Checked)
            {
                tbNazevZbozi.Text = "";
                tbPopisZbozi.Text = "";
                nudCenaZbozi.Value = 0;
                nudMnozstviZbozi.Value = 0;
                cbxUpravaZbozi.Checked = true;
            }
            else //Pokud chceme nějaké zboží editovat a máme nějaké zboží vybrané, načtou se jeho údaje k úpravě
            {
                Zbozi z = Zbozi.vsechnoZbozi[(string)listZbozi.SelectedItem];

                tbNazevZbozi.Text = z.Nazev;
                tbPopisZbozi.Text = z.Popis;
                nudCenaZbozi.Value = z.Cena;
                nudMnozstviZbozi.Value = z.Mnozstvi;
            }
        }

        //Pokusí se odstranit vybranou kategorii
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
                    stromKategorii.NactiStrom(listZbozi);
                    tbKategorieNazev.Text = "";
                }
                catch
                {
                    MessageBox.Show("Kategorii nelze odstranit");
                }
            }
        }

        //Pokusí se odstranit vybrané zboží
        private void btOdstranZbozi_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = Zbozi.vsechnoZbozi[(string)listZbozi.SelectedItem];

            bool nekdoVlastni = PraceSDB.ZavolejPrikaz("select * from Uzivatel_zbozi as uz inner join Zbozi as z on uz.zboziId=z.Id where z.Nazev=@nazev;", false, true, "@nazev".SparujS(zbozi.Nazev)).Count > 0;
            if (nekdoVlastni && zbozi.kategorie.Count == 1)
            {
                MessageBox.Show("Zboží již někdo zakoupil, tudíž musí zůstat v historii a nelze odstranit!");
            }
            else if (MessageBox.Show($"Opravdu si přeješ odstranit zboží '{zbozi.Nazev}' z kategorie '{stromKategorii.SelectedNode.Text}'?", "Odstranění zboží", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    PraceSDB.ZavolejPrikaz("delete zk from Zbozi_kategorie as zk inner join Zbozi as z on zk.zboziId=z.Id inner join Kategorie as k on zk.kategorieId=k.Id where z.Nazev=@nazev and k.Nazev=@kategorie;", false, false, "@nazev".SparujS(zbozi.Nazev), "@kategorie".SparujS(stromKategorii.SelectedNode.Text));
                    if (zbozi.kategorie.Count == 1)
                    {
                        PraceSDB.ZavolejPrikaz("delete Zbozi where Nazev=@nazev;", false, false, "@nazev".SparujS(zbozi.Nazev));
                    }
                    stromKategorii.NactiStrom(listZbozi);
                }
                catch
                {
                    MessageBox.Show("Kategorii nelze odstranit");
                }
            }
        }

        private void cbxUpravaKategorie_CheckedChanged(object sender, EventArgs e)
        {
            ((CheckBox)sender).Text = ((CheckBox)sender).Checked ? "Nová kategorie" : "Editování existující"; //Změní název podle zamáčknutí
            if (((CheckBox)sender).Checked)
            {
                tbKategorieNazev.Text = "";
            }
            treeView1_AfterSelect(stromKategorii, new TreeViewEventArgs(stromKategorii.SelectedNode)); //Refreshne vybrání
        }

        //Uloží novou kategorii
        private void btUlozitKategorii_Click(object sender, EventArgs e)
        {
            string meno = "''; drop database;";

            string prikaz = $"select * from Lidi where jmeno={meno}";

            SqlCommand cmd = new SqlCommand(prikaz);
            cmd.Parameters.AddWithValue("@eno", meno);



            if (cbxUpravaKategorie.Checked)
            {
                try
                {
                    int idDite = Convert.ToInt32(PraceSDB.ZavolejPrikaz("insert into Kategorie(Nazev) values (@nazev); SELECT SCOPE_IDENTITY();", false, true, "@nazev".SparujS(tbKategorieNazev.Text))[0][0]);
                    int idRodic = (int)PraceSDB.ZavolejPrikaz("select id from Kategorie where nazev=@nazev;", false, true, "@nazev".SparujS(lbNadKategorieKategorie.Text))[0][0];
                    PraceSDB.ZavolejPrikaz($"insert into kategorie_kategorie(rodicId, diteId) values ({idRodic},{idDite})", false, false);
                    stromKategorii.NactiStrom(listZbozi);
                    tbKategorieNazev.Text = "";
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
                            stromKategorii.NactiStrom(listZbozi);
                            tbKategorieNazev.Text = "";
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
            ((CheckBox)sender).Text = ((CheckBox)sender).Checked ? "Nové zboží" : "Editování existujícího"; //Změní název podle zamáčknutí
            if (((CheckBox)sender).Checked) //Pokud je vybráno tvořit nové zboží, vymaže položky o zboží
            {
                tbNazevZbozi.Text = "";
                tbPopisZbozi.Text = "";
                nudCenaZbozi.Value = 0;
                nudMnozstviZbozi.Value = 0;
            }
            else
            {
                listBox1_SelectedIndexChanged(listZbozi, null); //Jinak načte položky tak jak má
            }
        }

        //Uloží nové zboží
        private void btUlozitZbozi_Click(object sender, EventArgs e)
        {
            if (cbxUpravaZbozi.Checked)
            {
                if (stromKategorii.SelectedNode.Text == Kategorie.hlavniKategorie.Nazev)
                {
                    MessageBox.Show("Nelze vytvořit zboží v nejvyšší kategorii!");
                }
                else
                {
                    try
                    {
                        int idZbozi = Convert.ToInt32(PraceSDB.ZavolejPrikaz("insert into Zbozi(Nazev, Popis, Cena, Mnozstvi) values (@nazev, @popis, @cena, @mnozstvi); SELECT SCOPE_IDENTITY();", false, true, "@nazev".SparujS(tbNazevZbozi.Text), "@popis".SparujS(tbPopisZbozi.Text), "@cena".SparujS((int)nudCenaZbozi.Value), "@mnozstvi".SparujS((int)nudMnozstviZbozi.Value))[0][0]);
                        int idKategorie = (int)PraceSDB.ZavolejPrikaz("select id from Kategorie where nazev=@nazev;", false, true, "@nazev".SparujS(lbNadKategorieZbozi.Text))[0][0];
                        PraceSDB.ZavolejPrikaz($"insert into Zbozi_kategorie(zboziId, kategorieId) values ({idZbozi},{idKategorie})", false, false);
                        stromKategorii.NactiStrom(listZbozi);
                    }
                    catch
                    {
                        MessageBox.Show("Takové zboží již existuje");
                    }
                }
            }
            else
            {
                if (string.IsNullOrEmpty((string)listZbozi.SelectedItem))
                {
                    MessageBox.Show("Nebylo vybráno žádné zboží!");
                }
                else
                {
                    Zbozi vybrane = Zbozi.vsechnoZbozi[(string)listZbozi.SelectedItem];
                    if (vybrane.Nazev == tbNazevZbozi.Text && vybrane.Popis == tbPopisZbozi.Text && vybrane.Cena == (int)nudCenaZbozi.Value && vybrane.Mnozstvi == (int)nudMnozstviZbozi.Value)
                    {
                        MessageBox.Show("Musí být změněna alespoň 1 vlastnost!");
                    }
                    else if (string.IsNullOrWhiteSpace(tbKategorieNazev.Text) || string.IsNullOrWhiteSpace(tbPopisZbozi.Text))
                    {
                        MessageBox.Show("Název ani popis nesmí být prázdný!");
                    }
                    else
                    {
                        try
                        {
                            PraceSDB.ZavolejPrikaz("update Zbozi set Nazev=@novyNazev, Popis=@popis, Cena=@cena, Mnozstvi=@mnozstvi where Nazev=@staryNazev;", false, false, "@novyNazev".SparujS(tbNazevZbozi.Text), "@popis".SparujS(tbPopisZbozi.Text), "@cena".SparujS((int)nudCenaZbozi.Value), "@mnozstvi".SparujS((int)nudMnozstviZbozi.Value), "@staryNazev".SparujS(vybrane.Nazev));
                            stromKategorii.NactiStrom(listZbozi);
                        }
                        catch
                        {
                            MessageBox.Show("Takové zboží již existuje");
                        }
                    }
                }
            }
        }

        string puvodniKategorieZbozi; //Kategorie, za kterou uživatel táhne
        private void listZbozi_MouseDown(object sender, MouseEventArgs e)
        {
            if (listZbozi.SelectedItem != null ) //Zjistí, jestli je vybráno nějaké zboží, aby za něj bylo možno táhnout 
            {
                listBox1_SelectedIndexChanged(null, null); //Aktivuje vybrání prvku, než za něj začne tahat, aby se aplikace neglitchovala
                if (e.Button == MouseButtons.Left) //Pokud je použito levé tlačítko, bude zboží překopírováno
                {
                    levy = true;
                    listZbozi.DoDragDrop((string)listZbozi.SelectedItem, DragDropEffects.Copy);
                }
                else if (e.Button == MouseButtons.Right) //Pokud je použito pravé tlačítko, bude zboží přesunoto
                {
                    levy = false;
                    puvodniKategorieZbozi = stromKategorii.SelectedNode.Text;
                    listZbozi.DoDragDrop((string)listZbozi.SelectedItem, DragDropEffects.Move);
                }
            }
        }

        bool levy; //Jestli bylo použito levé tlačítko
        private void stromKategorii_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) //Zjistí, jestli je opravdu něco táhnuto (ideálně by se podmínka měla vždy vyplnit)
            {
                e.Effect = levy ? DragDropEffects.Copy : DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void stromKategorii_DragDrop(object sender, DragEventArgs e)
        {
            Point cilovyBod = stromKategorii.PointToClient(new Point(e.X, e.Y)); //Kde uživatel přestal táhnout

            TreeNode cilovyNod = stromKategorii.GetNodeAt(cilovyBod); //Co to bylo za nod

            if (cilovyNod == null) //V případě, že pustil zboží do prázdna, nebude přiřazeno nikam
            {
                return;
            }

            if (Zbozi.vsechnoZbozi[(string)e.Data.GetData(DataFormats.Text)].kategorie.Contains(Kategorie.vsechnyKategorie[cilovyNod.Text])) //Zjistí, jestli zboží již v této kategorii není
            {
                MessageBox.Show("Zboží již v této kategorii je!");
                return;
            }

            int idZbozi = (int)PraceSDB.ZavolejPrikaz($"select id from Zbozi where Nazev=@nazev", false, true, "@nazev".SparujS(e.Data.GetData(DataFormats.Text)))[0][0];
            int idKategorie = (int)PraceSDB.ZavolejPrikaz($"select id from Kategorie where Nazev=@nazev", false, true, "@nazev".SparujS(cilovyNod.Text))[0][0];

            //Překopíruje zboží
            PraceSDB.ZavolejPrikaz("insert into Zbozi_kategorie(zboziId, kategorieId) values (@zbozi, @kategorie)", false, false, "@zbozi".SparujS(idZbozi), @"kategorie".SparujS(idKategorie));

            //Odstraní ze staré kategorie, pokud chtěl uživatel přesouvat
            if (e.Effect == DragDropEffects.Move)
            {
                idKategorie = (int)PraceSDB.ZavolejPrikaz($"select id from Kategorie where Nazev=@nazev", false, true, "@nazev".SparujS(puvodniKategorieZbozi))[0][0];
                PraceSDB.ZavolejPrikaz("delete from Zbozi_kategorie where zboziId=@zbozi and kategorieId=@kategorie", false, false, "@zbozi".SparujS(idZbozi), @"kategorie".SparujS(idKategorie));
            }

            //Znovu vše načte
            stromKategorii.NactiStrom(listZbozi);
        }
    }
}
