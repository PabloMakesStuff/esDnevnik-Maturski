using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class UcenikIndividuo : Form
    {
        public string? odeljenje_ = null;
        public string? id_ucenik_ = null;
        public UcenikIndividuo(string? imeUcenik, string? id_ucenik, string? odeljenje)
        {
            InitializeComponent();
            labelImeUcenik.Text = "Ucenik: " + imeUcenik;
            odeljenje_ = odeljenje;
            id_ucenik_ = id_ucenik;
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfil(odeljenje_));
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            // var query = 
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
