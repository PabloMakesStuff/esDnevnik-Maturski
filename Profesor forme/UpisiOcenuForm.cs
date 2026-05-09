using System.Data;
using System.Data.OleDb;

namespace Maturski.Profesor_forme
{
    public partial class UpisiOcenuForm : Form
    {
        string polugodiste = (DateTime.Now.Month >= 9 || DateTime.Now.Month <= 1) ? "1" : "2";
        private string? _odeljenje = null;
        private string? _id_predmet = null;
        private string? _id_ucenik = null;
        public UpisiOcenuForm(string? odeljenje)
        {
            _odeljenje = odeljenje;
            InitializeComponent();

            var query = "SELECT ucenik.ime, ucenik.prezime, ucenik.id_ucenik " +
                        "FROM ucenik " +
                        "WHERE ucenik.odeljenje = ? ";

            var dt = Database.execQuery(query, new OleDbParameter("?", odeljenje));

            foreach (DataRow row in dt.Rows)
            {
                string? ime = row["Ime"].ToString();
                string? prezime = row["Prezime"].ToString();

                boxImeUcenika.Items.Add(ime + " " + prezime);
            }
        }
        private void boxImeUcenika_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string? box = boxImeUcenika.SelectedItem?.ToString();

            var query = "SELECT ID_ucenik FROM ucenik WHERE ucenik.Ime & ' ' & ucenik.Prezime = ?";
            var dt = Database.execQuery(query, new OleDbParameter("?", box));

            if (dt.Rows.Count > 0)
                _id_ucenik = dt.Rows[0]["id_ucenik"]?.ToString();
        }
        private void boxPredmet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string? box = boxPredmet.SelectedItem?.ToString();

            var query = "SELECT id_predmet FROM predmeti WHERE nazivPred = ?";
            var dt = Database.execQuery(query, new OleDbParameter("?", box));

            if (dt.Rows.Count > 0)
                _id_predmet = dt.Rows[0]["id_predmet"]?.ToString();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfilProf(_odeljenje));
        }

        private void UpisiOcenuBTN_Click(object sender, EventArgs e)
        {
            if (boxPredmet.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite predmet.", "Upozorenje o nedostatku predmeta");
                return;
            }

            if (boxImeUcenika.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite učenika.", "Upozorenje o nedostatku učenika");
                return;
            }

            if (boxOcene.SelectedItem == null)
            {
                MessageBox.Show("Molimo upišite ocenu.", "Upozorenje o nedostatku ocene");
                return;
            }

            if (string.IsNullOrWhiteSpace(textboxOpis.Text))
            {
                DialogResult m = MessageBox.Show("Da li ste sigurni da zelite da ostavite ocenu neopisanu?.", "Upozorenje o nedostatku opisa", MessageBoxButtons.YesNo);
                if (m == DialogResult.No)
                    return;
            }

            if (_id_ucenik == null || _id_predmet == null) {
                MessageBox.Show("Greška pri izboru učenika ili predmeta.");
                return; }

            var query = "INSERT INTO ocene (id_ucenik, id_predmet, id_profesor, broj_oc, opis, datum, polugodiste) VALUES (?, ?, ?, ?, ?, ?, ?)";

            Database.execNonQuery(query,
                new OleDbParameter("?", Convert.ToInt32(_id_ucenik)),
                new OleDbParameter("?", Convert.ToInt32(_id_predmet)),
                new OleDbParameter("?", LoginForm.ID_profesor.ToString()),
                new OleDbParameter("?", Convert.ToInt32(boxOcene.SelectedItem)),
                new OleDbParameter("?", textboxOpis.Text),
                new OleDbParameter("?", DateTime.Now.ToShortDateString()),
                new OleDbParameter("?", polugodiste));

            MessageBox.Show("Uspesno ste upisali ocenu!", "Uspesno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FM.OpenForm(this, new OdeljenjeProfilProf(_odeljenje));
        }
    }
}
