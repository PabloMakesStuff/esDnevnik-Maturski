using System.Data;
using System.Data.OleDb;

namespace Maturski.Profesor_forme
{
    public partial class ProfesorForm : BaseFormProfesor
    {
        public ProfesorForm()
        {
            InitializeComponent();
            this.Text = "esDnevnik";
            this.Icon = new Icon(FM.ikonica);
        }
        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            var dt = Database.execQuery(
                "SELECT ime FROM profesor WHERE id_profesor = ?",
                new OleDbParameter("?", LoginForm.ID_profesor));

            string ime = "";

            // ako ne vrati nista
            if (dt.Rows.Count > 0)
                ime = dt.Rows[0]["ime"].ToString() + "!";

            labelDobarDan.Text = "Dobar dan, " + ime;

            var query =
                "SELECT p.ID_profesor, pr.nazivPred AS Predmet, o.odeljenje AS Odeljenje " +
                "FROM (ProfesorPredmetOdeljenje AS p " +
                "INNER JOIN predmeti AS pr ON p.ID_predmet = pr.ID_predmet) " +
                "INNER JOIN odeljenje AS o ON p.ID_odeljenja = o.ID_odeljenja " +
                "WHERE p.ID_profesor = ? " +
                "ORDER BY pr.nazivPred, o.odeljenje;";

            var dt2 = Database.execQuery(query, new OleDbParameter("?", LoginForm.ID_profesor));

            foreach (DataRow row in dt2.Rows)
            {
                string? odeljenje = row["Odeljenje"].ToString();
                string? predmet = row["Predmet"].ToString();
                tablePanelChild.Controls.Add(new OdeljenjeProfesorBTN(odeljenje, predmet));
            }
        }
    }
}
