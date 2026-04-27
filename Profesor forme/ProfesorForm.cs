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
    public partial class ProfesorForm : BaseFormProfesor
    {
        public ProfesorForm()
        {
            InitializeComponent();
        }
        private void ProfesorForm_Load(object sender, EventArgs e)
        {
            var dt = Database.execQuery(
                "SELECT ime FROM profesor WHERE id_profesor = ?",
                new OleDbParameter("?", LoginForm.ID_profesor)
                );

            string ime = "";

            // ako ne vrati nista
            if (dt.Rows.Count > 0)
                ime = dt.Rows[0]["ime"].ToString() + "!";

            labelDobarDan.Text = "Dobar dan, " + ime;

            // kako sada da uzmem odeljenja za ID_profesora i koji predmet predaje tom odeljenju? Treba mi i naziv predmeta i naziv odeljenja, a imam samo ID_profesora
            //var query = Database.execQuery("");
        }
    }
}
