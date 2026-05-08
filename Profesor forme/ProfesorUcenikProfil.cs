using Maturski.Ucenik_Forme;
using System.Data;
using System.Data.OleDb;

namespace Maturski.Profesor_forme
{
    // svakome kome cita sledeci kod, izvinjavam se
    // veoma je kasno i ne mogu da razmisljam najbolje
    // plus zelim da iskoristim kod koji sam vec napisao maksimalno
    public partial class ProfesorUcenikProfil : Form
    {
        // geeksforgeeks goat
        public string? odeljenje_ = null;
        public string? id_ucenik_ = null;
        public ProfesorUcenikProfil(string? imeUcenik, string? id_ucenik, string? odeljenje)
        {
            InitializeComponent();
            labelImeUcenik.Text = "Ucenik: " + imeUcenik;
            odeljenje_ = odeljenje;
            id_ucenik_ = id_ucenik;

            flowPanel.Visible = false;
            tableLayout.Visible = false;

            flowPanel.AutoScroll = true;
            tableLayout.AutoScroll = true;
        }
        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfilProf(odeljenje_));
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            tableLayout.Controls.Clear();

            tableLayout.Visible = true;
            flowPanel.Visible = false;
            //kopirano iz pocetak u ucenikform cisto za test
            string query = "SELECT o.broj_oc, o.opis, p.nazivPred " +
                           "FROM ocene o " +
                           "INNER JOIN predmeti p ON o.ID_predmet = p.ID_predmet " +
                           "WHERE o.id_ucenik = ? " +
                           "ORDER BY p.nazivPred ";

            var dt = Database.execQuery(query, new OleDbParameter("?", id_ucenik_));

            foreach (DataRow row in dt.Rows)
            {
                string? broj_oc = row["broj_oc"]?.ToString();
                string? opis = row["opis"]?.ToString();
                string? nazivPred = row["nazivPred"]?.ToString();

                tableLayout.Controls.Add(new UcenikOceneCard(broj_oc, opis, nazivPred));
            }
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {
            flowPanel.Controls.Clear();

            flowPanel.Visible = true;
            tableLayout.Visible = false;

            FM.AddCenteredControl(new IzostanciListaVrh(), flowPanel);

            // direktno recikliran kod iz ucenikfrom izostancibtn
            string query = "SELECT p.nazivPred, i.status, i.ID_ucenik " +
                           "FROM izostanci i, predmeti p " +
                           "WHERE i.id_predmet = p.id_predmet " +
                           "AND i.id_ucenik = ? " +
                           "ORDER BY p.nazivPred, i.status ";

            var dt = Database.execQuery(query, new OleDbParameter("?", id_ucenik_));

            var izostanci = new Dictionary<string, (string predmet, int opra, int neopra, int nereg)>();

            foreach (DataRow row in dt.Rows)
            {
                string? predmet = row["nazivPred"]?.ToString();
                string? status = row["status"]?.ToString();

                if (!izostanci.ContainsKey(predmet))
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
                FM.AddCenteredControl(new IzostanciListaDonji(predmet, opra, neopra, nereg), flowPanel);
            }
        }
    }
}
