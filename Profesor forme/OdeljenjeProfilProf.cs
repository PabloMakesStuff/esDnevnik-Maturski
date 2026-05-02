using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class OdeljenjeProfilProf : Form
    {
        public OdeljenjeProfilProf(string? odeljenje)
        {
            InitializeComponent();
            label1.Text = "Odeljenje: " + odeljenje;

            var query = "SELECT ucenik.ime, ucenik.prezime, ucenik.id_ucenik " +
                        "FROM ucenik " +
                        "WHERE ucenik.odeljenje = ? ";

            var dt = Database.execQuery(query, new OleDbParameter("?", odeljenje));

            /* test kod
            if (dt.Rows.Count == 0) {
                Label l = new Label();
                l.Location = new Point(200, 200);
                l.Text = "Nema nijednog ucenika u ovom odeljenje";
                tablePanelChild.Controls.Add(l);
            }*/

            foreach (DataRow row in dt.Rows) {
                string? ime = row["Ime"].ToString();
                string? prezime = row["Prezime"].ToString();
                string? id_ucenik = row["id_ucenik"].ToString();

                // ovaj ubac stringa u funkciju izgleda ruzno ali je prostiji -_-
                tablePanelChild.Controls.Add(new UcenikProfilIndividuo(ime + " " + prezime, id_ucenik, odeljenje));
            }
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new ProfesorForm());
        }
    }
}
