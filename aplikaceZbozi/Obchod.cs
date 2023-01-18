using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public partial class Obchod : Form, IMaStromKategoriiASeznamZbozi
    {
        Form rodic; //Nadřazený form
        public Obchod(Form f)
        {
            rodic = f;
            InitializeComponent();
            stromKategorii.NactiStrom(flpSeznamZbozi); //Načte všechny kategorie
        }

        //Vrátí se do nadřazeného formu
        private void Editace_FormClosed(object sender, FormClosedEventArgs e)
        {
            rodic.Show();
        }

        List<oknoSeZbozim> seznamZbozi; //Seznam zboží ve vybrané kategorii

        //Event po vybrání kategorie
        private void stromKategorii_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == HlavniStatik.NAZEV_HLAVNI_KATEGORIE && posledniNod != null)
            {
                OtevriPredchozi(); //Zabránění vybrání nejvyšší kategorie
                return;
            }
            else if (e.Node.Text != HlavniStatik.NAZEV_HLAVNI_KATEGORIE)
            {
                posledniNod = e.Node.Text; //Uložení poslední vybrané kategorie
            }

            seznamZbozi = Kategorie.vsechnyKategorie[e.Node.Text].zbozi.Select(z => new oknoSeZbozim(z, this)).ToList(); //Načtení zboží z dané kategorie
            SeradZbozi();
        }

        //Seřazení zboží podle vybraného filtru
        private void SeradZbozi()
        {
            if(rbDrahe.Checked)
            {
                seznamZbozi = seznamZbozi.OrderByDescending(okno => okno.zbozi.Cena).ToList();
            }
            else if(rbLevne.Checked)
            {
                seznamZbozi = seznamZbozi.OrderBy(okno => okno.zbozi.Cena).ToList();
            }
            else if (rbZa.Checked)
            {
                seznamZbozi = seznamZbozi.OrderByDescending(okno => okno.zbozi.Nazev).ToList();
            }
            else if (rbAz.Checked)
            {
                seznamZbozi = seznamZbozi.OrderBy(okno => okno.zbozi.Nazev).ToList();
            }
            else if (rbNejvice.Checked)
            {
                seznamZbozi = seznamZbozi.OrderByDescending(okno => okno.zbozi.Mnozstvi).ToList();
            }
            else if (rbNejmene.Checked)
            {
                seznamZbozi = seznamZbozi.OrderBy(okno => okno.zbozi.Mnozstvi).ToList();
            }
            else
            {
                throw new Exception("Chyba");// Pro případ nevybrání žádného filtru (nemožné, pouze testovací účel)
            }

            flpSeznamZbozi.Controls.Clear();
            flpSeznamZbozi.Controls.AddRange(seznamZbozi.ToArray()); //Přidání zboží v novém pořadí
        }

        //Změna řadícího filtru
        private void CheckedChanged(object sender, EventArgs e)
        {
            SeradZbozi(); 
        }

        string posledniNod; //Poslední otevřená kategorie
        //Otevření poslední kategorie
        public void OtevriPredchozi()
        {
            stromKategorii.SelectedNode = stromKategorii.Nodes.NajdiNod(posledniNod);
        }
    }
}
