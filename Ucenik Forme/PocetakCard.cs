using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Maturski
{
    public partial class PocetakCard : UserControl
    {
        public PocetakCard(string predmet, string opis, int ocena, string datum)
        {
            InitializeComponent();

            labelPredmet.Text = predmet;
            labelOpis.Text = opis;
            labelOpis.MaximumSize = new Size(300, 0);
            labelOcene.Text = ocena.ToString();
            labelDatum.Text = datum;
        }
    }
}
