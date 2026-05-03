using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class UpisiOcenuForm : Form
    {
        private string? _odeljenje = null;
        public UpisiOcenuForm(string? odeljenje)
        {
            _odeljenje = odeljenje;
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new OdeljenjeProfilProf(_odeljenje));
        }
    }
}
