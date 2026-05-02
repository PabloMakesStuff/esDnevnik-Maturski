using Maturski.Ucenik_Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class ProfesorUcenikProfil : Form
    {
        public string? odeljenje_ = null;
        public string? id_ucenik_ = null;
        public ProfesorUcenikProfil(string? imeUcenik, string? id_ucenik, string? odeljenje)
        {
            InitializeComponent();
            labelImeUcenik.Text = "Ucenik: " + imeUcenik;
            odeljenje_ = odeljenje;
            id_ucenik_ = id_ucenik;
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfilProf(odeljenje_));
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            //kopirano iz pocetak u ucenikform cisto za test
            /*
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
                tableLayout.Controls.Add(card);
            }*/
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
