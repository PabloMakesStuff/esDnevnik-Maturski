using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;

namespace Maturski
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //privremeno za testiranje, OBAVEZNO OBRISI KASNIJE!!!!!
            Email.Text = "djdj@gmail.com";
            Sifra.Text = "12345";
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string sifra = Sifra.Text;

            if (email == null || sifra == null)
            {
                MessageBox.Show("Unesite email i sifru");
                return;
            }

            var dt = Database.execQuery("SELECT * FROM Korisnici WHERE Email = ? AND Sifra = ?",
                new OleDbParameter("@Email", email),
                new OleDbParameter("@Sifra", sifra)
                );

            if (dt.Rows.Count > 0)
            {
                // filtriranje statusa, nije bas potrebno ali smanjuje glavobolju
                string status = dt.Rows[0]["status"].ToString().Trim().ToLower();
                int refId = Convert.ToInt32(dt.Rows[0]["ref_id"]);

                if (status == "ucenik")
                {
                    var ucenik = Database.execQuery(
                        "SELECT * FROM ucenik WHERE id_ucenik = ?",
                        new OleDbParameter("id", refId)
                    );

                    //UcenikForm f = new UcenikForm(ucenik);
                    FM.OpenForm(this, new UcenikForm());
                }

                else if (status == "profesor")
                {
                    var profesor = Database.execQuery(
                        "SELECT * FROM profesor WHERE id_profesor = ?",
                        new OleDbParameter("id", refId)
                    );

                    //ProfesorForm f = new ProfesorForm(profesor);
                    FM.OpenForm(this,new ProfesorForm());
                }
                else
                {
                    MessageBox.Show("Nepoznat status.");
                }
            }

            else
            {
                MessageBox.Show("Unesite email i sifru");
            }
        }
        private void RegistarBTN_Click(object sender, EventArgs e)
        {
            FM.OpenForm(this, new RegistarForm());
        }
    }
}
