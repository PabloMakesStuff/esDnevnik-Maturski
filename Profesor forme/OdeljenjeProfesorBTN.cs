namespace Maturski.Profesor_forme
{
    public partial class OdeljenjeProfesorBTN : UserControl
    {
        public OdeljenjeProfesorBTN(string? odeljenje, string? predmet)
        {

            Anchor = AnchorStyles.None;
            InitializeComponent();

            labelOdeljenje.Text = odeljenje;
            labelPredmet.Text = predmet;
        }

        private void helperBTN_Click(object sender, EventArgs e)
        {
            string odeljenje = labelOdeljenje.Text;
            FM.OpenForm(this.FindForm(), new OdeljenjeProfilProf(odeljenje));
        }
    }
}
