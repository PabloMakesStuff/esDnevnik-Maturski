using System.Data;
using System.Data.OleDb;

namespace Maturski.Profesor_forme
{
    public partial class UpisiNeopravdaniForm : Form
    {
        private string? _id_predmet = null;
        private string? _odeljenje = null;
        private string? _id_ucenik = null;
        public UpisiNeopravdaniForm(string? odeljenje)
        {
            InitializeComponent();
            _odeljenje = odeljenje;

            var query = "SELECT ucenik.ime, ucenik.prezime " +
                        "FROM ucenik " +
                        "WHERE ucenik.odeljenje = ? ";

            var dt = Database.execQuery(query, new OleDbParameter("?", OdeljenjeProfilProf._odeljenje?.ToString()));

            foreach (DataRow row in dt.Rows)
            {
                string? ime = row["Ime"].ToString();
                string? prezime = row["Prezime"].ToString();

                boxImeUcenika.Items.Add(ime + " " + prezime);
            }
        }
        // posto ne znam kako da vadim id_ucenik i id_predmet
        // ove dve funkcije funkcionisu tako
        private void boxPredmet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? box = boxPredmet.SelectedItem?.ToString();

            var query = "SELECT ID_predmet FROM predmeti WHERE nazivPred = ?";
            var dt = Database.execQuery(query, new OleDbParameter("?", box));

            if (dt.Rows.Count > 0)
            {
                _id_predmet = dt.Rows[0]["ID_predmet"].ToString();
            }
        }
        private void boxImeUcenika_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string? box = boxImeUcenika.SelectedItem?.ToString();

            var query = "SELECT ID_ucenik FROM ucenik WHERE ucenik.Ime + ' ' + ucenik.Prezime = ?";
            var dt = Database.execQuery(query, new OleDbParameter("?", box));

            if (dt.Rows.Count > 0)
                _id_ucenik = dt.Rows[0]["id_ucenik"]?.ToString();
        }
        private void UpisiIzostanakBTN_Click(object sender, EventArgs e)
        {
            if (boxImeUcenika.Text == "" || boxImeUcenika.Text == null)
            {
                MessageBox.Show("Molimo izaberite učenika.", "Upozorenje o nedostatku učenika");
                return;
            }
            if (boxPredmet.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite predmet.", "Upozorenje o nedostatku predmeta");
                return;
            }
            if (boxStatus.SelectedItem == null)
            {
                MessageBox.Show("Molimo izaberite status opravdanja.", "Upozorenje o nedostatku statusa");
                return;
            }

            var query = "INSERT INTO izostanci (ID_ucenik, ID_predmet, datum, status) VALUES (?,?,?,?)";

            Database.execNonQuery(query, new OleDbParameter[] {
                new OleDbParameter("?", _id_ucenik),
                new OleDbParameter("?", _id_predmet),
                new OleDbParameter("?", DateTime.Now.ToString()),
                new OleDbParameter("?", boxStatus.SelectedItem.ToString())
            });

            MessageBox.Show("Uspesno ste upisali neopravdani!", "Uspesno!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfilProf(_odeljenje));
        }

        
    }
}