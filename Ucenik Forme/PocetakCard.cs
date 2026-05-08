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
