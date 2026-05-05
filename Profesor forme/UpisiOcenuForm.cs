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
    public partial class UpisiOcenuForm : Form
    {
        string polugodiste = (DateTime.Now.Month >= 9) ? "1" : "2";
        private string? _odeljenje = null;
        private string? _id_predmet = null;
        public UpisiOcenuForm(string? odeljenje)
        {
            _odeljenje = odeljenje;
            InitializeComponent();

            var query = "SELECT ucenik.ime, ucenik.prezime " +
                        "FROM ucenik " +
                        "WHERE ucenik.odeljenje = ? ";
            var dt = Database.execQuery(query, new System.Data.OleDb.OleDbParameter("?", odeljenje));

            foreach (DataRow row in dt.Rows)
            {
                string? ime = row["Ime"].ToString();
                string? prezime = row["Prezime"].ToString();

                boxImeUcenika.Items.Add(ime + " " + prezime);
            }
        }
        private void boxPredmet_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string? box = boxPredmet.SelectedItem?.ToString();

            var query = "SELECT id_predmet FROM predmeti WHERE nazivPred = ?";
            var dt = Database.execQuery(query, new System.Data.OleDb.OleDbParameter("?", box));

            if (dt.Rows.Count > 0)
                _id_predmet = dt.Rows[0]["id_predmet"].ToString();
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

            if (textboxOpis.Text == null || textboxOpis.Text == "")
            {
                DialogResult m = MessageBox.Show("Da li ste sigurni da zelite da ostavite ocenu neopisanu?.", "Upozorenje o nedostatku opisa", MessageBoxButtons.YesNo);
                if (m == DialogResult.No)
                    return;
            }

            var query = "INSERT INTO ocene (id_ucenik, id_predmet, id_profesor, broj_oc, opis, datum, polugodiste) VALUES (?, ?, ?, ?, ?, ?, ?)";

            Database.execNonQuery(query, new OleDbParameter[] {
               new OleDbParameter("?", LoginForm.ID_ucenik.ToString()),
               new OleDbParameter("?", _id_predmet),
               new OleDbParameter("?", LoginForm.ID_profesor.ToString()),
               new OleDbParameter("?", boxOcene.SelectedItem.ToString()),
               new OleDbParameter("?", textboxOpis.Text),
               new OleDbParameter("?", DateTime.Now.TimeOfDay),
               new OleDbParameter("?", polugodiste)
           });
        }

        
    }
}
