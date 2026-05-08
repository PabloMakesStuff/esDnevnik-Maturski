namespace Maturski.Ucenik_Forme
{
    public partial class IzostanciListaDonji : UserControl
    {
        public IzostanciListaDonji(string predmet, int opravdani, int neopravdani, int neregulisani)
        {
            InitializeComponent();
            labelPredmet.Text = predmet;
            labelOpravdani.Text = opravdani.ToString();
            labelNeopravdani.Text = neopravdani.ToString();
            labelNeregulisani.Text = neregulisani.ToString();
        }
    }
}
