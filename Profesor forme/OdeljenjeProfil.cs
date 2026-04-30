using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Maturski.Profesor_forme
{
    public partial class OdeljenjeProfil : Form
    {
        public OdeljenjeProfil(string? id_odeljenja)
        {
            InitializeComponent();
            label1.Text = id_odeljenja;

            
        }
    }
}
