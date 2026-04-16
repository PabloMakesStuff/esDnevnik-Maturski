using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Maturski
{
    public partial class RegistarForm : Form
    {
        public RegistarForm()
        {
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
                string razred = odeljenje.Last<char>().ToString();
                string odeljenje1 = odeljenje.Substring(0, odeljenje.Length - 1);

                Database.execNonQuery(
                    "INSERT INTO ucenik (ime, prezime, odeljenje, razred) VALUES (?, ?, ?, ?)",
                    new OleDbParameter("ime", ime),
                    new OleDbParameter("prezime", prezime),
                    new OleDbParameter("odeljenje", odeljenje1),
                    new OleDbParameter("razred", razred)
                );

                var dt = Database.execQuery("SELECT @@IDENTITY AS LastId");
                refId = Convert.ToInt32(dt.Rows[0]["LastId"]);
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
