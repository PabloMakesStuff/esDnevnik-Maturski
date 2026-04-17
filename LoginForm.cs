using Maturski.Profesor_forme;
using System.ComponentModel;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maturski
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            //privremeno za testiranje, OBAVEZNO OBRISI KASNIJE!!!!!!!!!
            Email.Text = "zk@gmail.com";
            Sifra.Text = "12345";
        }
        public static int ID_ucenik { get; set; }
        public static int ID_profesor { get; set; }

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
                    ID_ucenik = refId;
                    FM.OpenForm(this, new UcenikForm());
                }

                else if (status == "profesor")
                {
                    var profesor = Database.execQuery(
                        "SELECT * FROM profesor WHERE id_profesor = ?",
                        new OleDbParameter("id", refId)
                    );

                    //ProfesorForm f = new ProfesorForm(profesor);
                    ID_profesor = refId;
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
