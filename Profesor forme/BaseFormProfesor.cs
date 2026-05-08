namespace Maturski.Profesor_forme
{
    public partial class BaseFormProfesor : Form
    {
        public BaseFormProfesor()
        {
            InitializeComponent();
        }

        private void IzlogujSeBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new LoginForm());
        }
    }
}
