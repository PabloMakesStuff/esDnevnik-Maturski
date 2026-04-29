using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class OdeljenjaProfesor : UserControl
    {
        public OdeljenjaProfesor(string? odeljenje, string? predmet)
        {

            Anchor = AnchorStyles.None;
            InitializeComponent();

            labelOdeljenje.Text = odeljenje;
            labelPredmet.Text = predmet;
        }

        private void helperBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this.FindForm(), new UcenikProfil());
        }
    }
}
