namespace Maturski.Profesor_forme
{
    public partial class UcenikOceneCard : UserControl
    {
        public UcenikOceneCard(string? broj_oc, string? opis, string? nazivPred)
        {
            InitializeComponent();

            labelOcena.Text = broj_oc;
            labelOpis.Text = opis;
            labelPredmet.Text = nazivPred;
        }
    }
}
