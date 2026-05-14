using System.Data.OleDb;

namespace Maturski
{
    public partial class RegistarForm : Form
    {
        public RegistarForm()
        {
            this.Text = "Register";
            this.Icon = new Icon(FM.ikonica);
            InitializeComponent();
            LabelOdeljenje.Visible = false;
            textBoxOdeljenje.Visible = false;
        }
        private void RegistarBTN_Click(object sender, EventArgs e)
        {
            int refId = 0;
            string ime = ImeText.Text.Trim();
            string prezime = PrezimeText.Text.Trim();
            string email = Email.Text.Trim();
            string sifra = Sifra.Text.Trim();
            string odeljenje = textBoxOdeljenje.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifra) || string.IsNullOrEmpty(prezime) || string.IsNullOrEmpty(ime))
            {
                MessageBox.Show("Unesite email i sifru");
                return;
            }

            if (ComboBox1.Text == "Ucenik")
            {
                // proverava da li odeljenje ima razred asociran sa njim
                // probao sam da korisitm char.Any(IsDigit) ali prosto ne radi
                // ne znam zasto
                bool provera = false;
                foreach (char c in odeljenje)
                    if (char.IsDigit(c))
                    {
                        provera = true;
                        break;
                    }

                if (!provera)
                {
                    MessageBox.Show("Unesite odeljenje u formatu 'XY' gde je X razred a Y odeljenje");
                    return;
                }

                Database.execNonQuery(
                    "INSERT INTO ucenik (ime, prezime, odeljenje) VALUES (?, ?, ?)",
                    new OleDbParameter("ime", ime),
                    new OleDbParameter("prezime", prezime),
                    new OleDbParameter("odeljenje", odeljenje)
                );

                var dt = Database.execQuery("SELECT @@IDENTITY AS LastId");
                refId = Convert.ToInt32(dt.Rows[0]["LastId"]);

                MessageBox.Show("Uspesno ste napravili nalog!");
            }

            else if (ComboBox1.Text == "Profesor")
            {
                Database.execNonQuery(
                    "INSERT INTO profesor (ime, prezime) VALUES (?, ?)",
                    new OleDbParameter("ime", ime),
                    new OleDbParameter("prezime", prezime)
                );

                var dt = Database.execQuery("SELECT @@IDENTITY AS LastId");
                refId = Convert.ToInt32(dt.Rows[0]["LastId"]);
            }

            Database.execNonQuery(
                "INSERT INTO korisnici (email, sifra, status, ref_id) VALUES (?, ?, ?, ?)",
                new OleDbParameter("email", email),
                new OleDbParameter("sifra", sifra),
                new OleDbParameter("status", ComboBox1.Text),
                new OleDbParameter("ref_id", refId)
                );

            FM.OpenForm(this, new LoginForm());
        }
        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new LoginForm());
        }

        private void comboBoxChange(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "Ucenik")
            {
                LabelOdeljenje.Visible = true;
                textBoxOdeljenje.Visible = true;
            }
            else
            {
                LabelOdeljenje.Visible = false;
                textBoxOdeljenje.Visible = false;
            }
        }
    }
}
