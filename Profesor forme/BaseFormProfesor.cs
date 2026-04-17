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
    public partial class BaseFormProfesor : Form
    {
        public BaseFormProfesor()
        {
            InitializeComponent();
        }

        private void IzlogujSeBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new LoginForm());
        }
    }
}
