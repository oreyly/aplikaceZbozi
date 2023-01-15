﻿using System;
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
    public partial class Obchod : Form, IMaStromKategoriiASeznamZbozi
    {
        Form rodic;
        public Obchod(Form f)
        {
            rodic = f;
            InitializeComponent();
            stromKategorii.NactiStrom(flpSeznamZbozi);
            var v = new object[] {
            "Nejlevnější",
            "Nejdražší",
            "A-Z",
            "Z-A",
            "Nejvíce na skladě",
            "Nejméně na skladě"};
            /*rb1.FlatAppearance.MouseOverBackColor = rb1.BackColor;*/
            rbLevne.CheckedChanged += NajetiNaCBX;
        }

        private void NajetiNaCBX(object sender, EventArgs e)
        {
            //MessageBox.Show("Pozot");
            //rb1.FlatAppearance.MouseOverBackColor = rb1.BackColor;
        }

        private void Editace_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hide();
            //Environment.Exit(0);
            rodic.Show();
        }

        List<oknoSeZbozim> seznamZbozi;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nejvyssi" && posledniNod != null)
            {
                OtevriPredchozi();
                return;
            }
            else if (e.Node.Text != "Nejvyssi")
            {
                posledniNod = e.Node.Text;
            }
            seznamZbozi = Kategorie.vsechnyKategorie[e.Node.Text].zbozi.Select(z => new oknoSeZbozim(z, this)).ToList();
            SeradZbozi();
        }

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
                throw new Exception("Chyba");
            }

            flpSeznamZbozi.Controls.Clear();
            flpSeznamZbozi.Controls.AddRange(seznamZbozi.ToArray());
        }

        private void rbLevne_CheckedChanged(object sender, EventArgs e)
        {
            SeradZbozi();
        }

        string posledniNod;
        public void OtevriPredchozi()
        {
            stromKategorii.SelectedNode = stromKategorii.Nodes.NajdiNod(posledniNod);
        }
    }
}
