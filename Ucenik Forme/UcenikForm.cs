using Maturski.Ucenik_Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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
            int ID_ucenik = LoginForm.ID_ucenik;
        }

        // dodati upitnici da bi kompajler ucutao
        private void PocetakBTN_Click(object sender, EventArgs e)
        {
            btnFontChange(PocetakBTN);
            flowpanelMain.Controls.Clear();

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
                flowpanelMain.Controls.Add(card);
            }
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            // Prvo postavlja OceneListaVrh, cista estetika
            btnFontChange(OceneBTN);
            flowpanelMain.Controls.Clear();
            var card1 = new OceneListaVrh();
            flowpanelMain.Controls.Add(card1);

            // zatim, trazi ocene prema ucenikid, predmet i polugodiste, pa ih prikazuje
            // ako nema ocenu (tojkest null) onda ne prikazuje nista (zbog toga : null)
            string query =
                "SELECT p.nazivPred, o.polugodiste, o.broj_oc, o.datum, o.opis " +
                "FROM ocene o, predmeti p " +
                "WHERE o.id_predmet = p.id_predmet " +
                "AND o.id_ucenik = ? " +
                "ORDER BY p.nazivPred, o.polugodiste, o.datum;";

            var dt = Database.execQuery(query, new OleDbParameter("?", LoginForm.ID_ucenik));

            foreach (DataRow row in dt.Rows)
            {
                string? predmet = row["nazivPred"].ToString();
                double? ocena1 = row["polugodiste"].ToString() == "1" ? (double?)Convert.ToInt32(row["broj_oc"]) : null;
                double? ocena2 = row["polugodiste"].ToString() == "2" ? (double?)Convert.ToInt32(row["broj_oc"]) : null;

                var card = new OceneListaDonji(predmet, ocena1, ocena2);
                flowpanelMain.Controls.Add(card);
            }
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {
            btnFontChange(IzostanciBTN);
            flowpanelMain.Controls.Clear();
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