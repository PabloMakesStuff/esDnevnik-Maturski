using Maturski.Ucenik_Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maturski
{
    public partial class UcenikForm : BaseForm
    {
        public UcenikForm()
        {
            InitializeComponent();
        }

        // dodati upitnici da bi kompajler ucutao
        private void PocetakBTN_Click(object sender, EventArgs e)
        {
            btnFontChange(PocetakBTN);
            panelMain.Controls.Clear();

            string query =
                "SELECT predmeti.nazivPred AS Predmet, ocene.opis AS Opis, ocene.broj_oc AS Ocena, ocene.datum AS Datum " +
                "FROM (ocene INNER JOIN predmeti ON ocene.id_predmet = predmeti.id_predmet) " +
                "WHERE ocene.id_ucenik = ?";

            var dt = Database.execQuery(query, new OleDbParameter("?", LoginForm.ID_ucenik));

            foreach (DataRow row in dt.Rows)
            {
                string? predmet = row["Predmet"].ToString();
                string? opis = row["Opis"].ToString();
                int ocena = Convert.ToInt32(row["Ocena"]);
                string? datum = row["Datum"].ToString();

                var card = new PocetakCard(predmet, opis, ocena, datum);
                FM.AddCenteredControl(card, panelMain);
            }
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            // Prvo postavlja OceneListaVrh, cista estetika
            btnFontChange(OceneBTN);
            panelMain.Controls.Clear();
            FM.AddCenteredControl(new OceneListaVrh(), panelMain);

            // zatim, trazi ocene prema ucenikid, predmet i polugodiste, pa ih prikazuje
            // ako nema ocenu (tojkest null) onda ne prikazuje nista (zbog toga : null)

            //jos jedna bitna stvar, ovaj upit sortira bazu pa zbog toga mogu da radim shenanigans
            string query =
                "SELECT p.nazivPred, o.polugodiste, o.broj_oc, o.datum, o.opis " +
                "FROM ocene o, predmeti p " +
                "WHERE o.id_predmet = p.id_predmet " +
                "AND o.id_ucenik = ? " +
                "ORDER BY p.nazivPred, o.polugodiste, o.datum;";

            var dt = Database.execQuery(query, new OleDbParameter("?", LoginForm.ID_ucenik));

            //cnt1, cnt2 broj ocena u prvom i drugom polugodistu
            var predmeti = new Dictionary<string, (int sum1, int cnt1, int sum2, int cnt2)>();

            foreach (DataRow row in dt.Rows)
            {
                string predmet = row["nazivPred"].ToString();
                int polugodiste = Convert.ToInt32(row["polugodiste"]);
                int ocena = Convert.ToInt32(row["broj_oc"]);

                //ako predmet nije upisan, onda upisuje default vrednosti
                if (!predmeti.ContainsKey(predmet))
                    predmeti[predmet] = (0, 0, 0, 0);

                var p = predmeti[predmet];

                //sumira ocene u prvom i drugom polugodistu
                if (polugodiste == 1)
                    p = (p.sum1 + ocena, p.cnt1 + 1, p.sum2, p.cnt2);
                else if (polugodiste == 2)
                    p = (p.sum1, p.cnt1, p.sum2 + ocena, p.cnt2 + 1);

                //upisuje rezultate u recnik
                predmeti[predmet] = p;
            }

            foreach (var item in predmeti)
            {
                string predmet = item.Key;

                //u deklaraciji za varijablu pita, da li je cnt1 veci od 0, ako jeste onda ovo
                double? prosek1 = item.Value.cnt1 > 0 ? Math.Round((double)item.Value.sum1 / item.Value.cnt1, 2) : null;
                double? prosek2 = item.Value.cnt2 > 0 ? Math.Round((double)item.Value.sum2 / item.Value.cnt2, 2) : null;

                var card = new OceneListaDonji(predmet, prosek1, prosek2);
                FM.AddCenteredControl(card, panelMain);
            }
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {
            btnFontChange(IzostanciBTN);

            panelMain.Controls.Clear();
            FM.AddCenteredControl(new IzostanciListaVrh(), panelMain);

            string query = "SELECT p.nazivPred, i.status, i.ID_ucenik" +
                " FROM izostanci i, predmeti p" +
                " WHERE i.id_predmet = p.id_predmet" +
                " AND i.id_ucenik = ?" +
                " ORDER BY p.nazivPred, i.status";

            var dt = Database.execQuery(query, new OleDbParameter("?", LoginForm.ID_ucenik));

            var izostanci = new Dictionary<string, (string predmet, int opra, int neopra, int nereg)>();

            foreach (DataRow row in dt.Rows)
            {
                string predmet = row["nazivPred"].ToString();
                string status = row["status"].ToString();

                if(!izostanci.ContainsKey(predmet))
                    izostanci[predmet] = (predmet, 0, 0, 0);

                var i = izostanci[predmet];

                if (status == "opravdani")
                    i = (predmet, i.opra + 1, i.neopra, i.nereg);
                else if (status == "neopravdani")
                    i = (predmet, i.opra, i.neopra + 1, i.nereg);
                else if (status == "neregulisani")
                    i = (predmet, i.opra, i.neopra, i.nereg + 1);
                izostanci[predmet] = i;
            }

            foreach (var item in izostanci)
            {
                string predmet = item.Key;
                int opra = item.Value.opra;
                int neopra = item.Value.neopra;
                int nereg = item.Value.nereg;
                var card = new IzostanciListaDonji(predmet, opra, neopra, nereg);
                FM.AddCenteredControl(card, panelMain);
            }
        }

        private void logoutBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new LoginForm());
        }

        public void btnFontChange(System.Windows.Forms.Button btn)
        {
            PocetakBTN.Font = FM.btnFont;
            OceneBTN.Font = FM.btnFont;
            IzostanciBTN.Font = FM.btnFont;

            btn.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
        }
    }
}