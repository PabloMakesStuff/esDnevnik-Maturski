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
        }
        private void RegistarBTN_Click(object sender, EventArgs e)
        {
            int refId = 0;
            string ime = ImeText.Text.Trim();
            string prezime = PrezimeText.Text.Trim();
            string email = Email.Text.Trim();
            string sifra = Sifra.Text.Trim();

            if(email == null || sifra == null)
            {
                MessageBox.Show("Unesite email i sifru");
                return;
            }

            if (ComboBox1.Text == "Ucenik")
            {
                Database.execNonQuery(
                    "INSERT INTO ucenik (ime, prezime) VALUES (?, ?)",
                    new OleDbParameter("ime", ime),
                    new OleDbParameter("prezime", prezime)
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
                new OleDbParameter("status",ComboBox1.Text),
                new OleDbParameter("ref_id", refId)
                );

            FM.OpenForm(this, new LoginForm());
        }
    }
}
