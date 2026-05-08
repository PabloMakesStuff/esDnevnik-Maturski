namespace Maturski.Profesor_forme
{
    public partial class UcenikProfilIndividuo : UserControl
    {
        public string? id_ucenik_ = null;
        public string? odeljenje_ = null;
        public UcenikProfilIndividuo(string? imeUcenik, string? id_ucenik, string? odeljenje)
        {
            InitializeComponent();
            labelImeUcenika.Text = imeUcenik;
            id_ucenik_ = id_ucenik;
            odeljenje_ = odeljenje;
        }

        private void UcenikIndividuoBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this.FindForm(), new ProfesorUcenikProfil(labelImeUcenika.Text, id_ucenik_, odeljenje_));
        }
    }
}
