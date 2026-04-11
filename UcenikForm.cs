using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Maturski
{
    public partial class UcenikForm : BaseForm
    {
        public UcenikForm()
        {
            InitializeComponent();
            int ID_ucenik = LoginForm.ID_ucenik;
            PocetakBTN_Click(null, null);
        }

        // dodati upitnici da bi kompajler ucutao
        private void PocetakBTN_Click(object? sender, EventArgs? e)
        {
            ButtonChange(PocetakBTN);
            flowpanelMain.Controls.Clear();

            // otvara konekciju sa serverom i cita iz base
            // prema id_ucenik, cita ocene i predmete i prikazuje ih u flowpanelu
            using (var connection = Database.GetConnection())
            {
                connection.Open();

                // MII BOMBACLATT
                var command = new OleDbCommand(
                    "SELECT predmeti.nazivPred AS Predmet, ocene.opis AS Opis, ocene.broj_oc AS Ocena, ocene.datum AS Datum " +
                    "FROM (ocene INNER JOIN predmeti ON ocene.id_predmet = predmeti.id_predmet) " +
                    "WHERE ocene.id_ucenik = ?",
                    connection
                    );

                command.Parameters.AddWithValue("?", LoginForm.ID_ucenik);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string predmet = reader["Predmet"].ToString();
                        string opis = reader["Opis"].ToString();

                        int ocena = (int)reader["Ocena"];

                        string datum = reader["Datum"].ToString();

                        var card = new OceneCard(predmet, opis, ocena, datum);
                        flowpanelMain.Controls.Add(card);
                    }
                }
            }
        }

        private void OceneBTN_Click(object sender, EventArgs e)
        {
            ButtonChange(OceneBTN);
            flowpanelMain.Controls.Clear();
        }

        private void IzostanciBTN_Click(object sender, EventArgs e)
        {
            ButtonChange(IzostanciBTN);
            flowpanelMain.Controls.Clear();
        }

        public void ButtonChange(System.Windows.Forms.Button btn)
        {
            PocetakBTN.Font = FM.btnFont;
            OceneBTN.Font = FM.btnFont;       
            IzostanciBTN.Font = FM.btnFont;

            btn.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
        }
    }
}