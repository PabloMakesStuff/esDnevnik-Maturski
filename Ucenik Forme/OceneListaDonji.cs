using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski.Ucenik_Forme
{
    public partial class OceneListaDonji : UserControl
    {
        public OceneListaDonji(string predmet, double? ocena1, double? ocena2)
        {
            InitializeComponent();
            labelImePred.Text = predmet;
            labelOcenaPrvo.Text = ocena1.HasValue ? ocena1.Value.ToString() : "";
            labelOcenaDrugo.Text = ocena2.HasValue ? ocena2.Value.ToString() : "";
        }

        private void OceneListaDonji_Load(object sender, EventArgs e)
        {

        }
    }
}
