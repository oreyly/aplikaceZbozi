using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace aplikaceZbozi
{
    public partial class oknoSeZbozim : UserControl
    {
        //Konstruktor pro testování
        public oknoSeZbozim()
        {
            InitializeComponent();
        }

        public Zbozi zbozi; //Zboží, kterého
        IMaStromKategoriiASeznamZbozi form; //Nadřazený form

        //Konstruktor pro Obchod
        public oknoSeZbozim(Zbozi z, Obchod o)
        {
            InitializeComponent();

            zbozi = z;
            form = o;

            lbNazev.Text = z.Nazev;
            tbPopis.Text = z.Popis;
            lbCena.Text = z.Cena.ToString("N0") + " Kč";
            lbMnozstvi.Text = z.Mnozstvi.ToString("N0");

            if (zbozi.Mnozstvi < 1) //Nelze zakoupit, pokud už je zboží vyprodáno
            {
                btKoupit.Enabled = false;
            }
            else
            {
                btKoupit.Click += Koupit_Click;
            }
        }

        //Konstruktor pro historii
        public oknoSeZbozim(Zbozi z, HistorieNakupu hn)
        {
            InitializeComponent();

            zbozi = z;
            form = hn;

            lbNazev.Text = z.Nazev;
            tbPopis.Text = z.Popis;
            lbCena.Text = z.Cena.ToString("N0") + " Kč";
            lbMnozstvi.Text = z.Mnozstvi.ToString("N0");

            //Změna popisků
            lbMnozstviPopis.Text = "Koupeno:";
            btKoupit.Text = "Vrátit";

            btKoupit.Click += Prodat_Click;
        }

        //Metoda pro koupení zboží
        private void Koupit_Click(object sender, EventArgs e)
        {
            int zboziId = (int)PraceSDB.ZavolejPrikaz("select Id from Zbozi where Nazev=@nazev", false, true, "@nazev".SparujS(zbozi.Nazev))[0][0];

            PraceSDB.ZavolejPrikaz($"insert into Uzivatel_zbozi(uzivatelId, zboziID) values ({HlavniStatik.prihlasenyUzivatelId},{zboziId})", false, false);
            PraceSDB.ZavolejPrikaz($"update Zbozi set Mnozstvi={zbozi.Mnozstvi - 1} where Nazev=@nazev", false, false, "@nazev".SparujS(zbozi.Nazev));

            form.stromKategorii.NactiStrom(form.flpSeznamZbozi);
            form.OtevriPredchozi();
        }

        //Metoda pro vrácení zboží
        private void Prodat_Click(object sender, EventArgs e)
        {
            int[] dataOZbozi = PraceSDB.ZavolejPrikaz("select Id, Mnozstvi from Zbozi where Nazev=@nazev", false, true, "@nazev".SparujS(zbozi.Nazev))[0].Select(polozka => Convert.ToInt32(polozka)).ToArray();
            int idMazaciRadky = (int)PraceSDB.ZavolejPrikaz($"select Id from Uzivatel_zbozi where uzivatelId={HlavniStatik.prihlasenyUzivatelId} and zboziID={dataOZbozi[0]};", false, true)[0][0];
            PraceSDB.ZavolejPrikaz($"delete from Uzivatel_zbozi where Id={idMazaciRadky}", false, false);
            PraceSDB.ZavolejPrikaz($"update Zbozi set Mnozstvi={dataOZbozi[1] + 1} where Nazev=@nazev", false, false, "@nazev".SparujS(zbozi.Nazev));

            form.stromKategorii.NactiStrom(form.flpSeznamZbozi);
            form.OtevriPredchozi();
        }
    }
}
