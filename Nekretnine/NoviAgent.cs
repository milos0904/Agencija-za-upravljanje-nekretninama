using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nekretnine
{
    public partial class NoviAgent : Form
    {
        ZaposleniInfo parent;

        public NoviAgent()
        {
            InitializeComponent();
        }

        public NoviAgent(ZaposleniInfo roditelj)
        {
            InitializeComponent();
            parent = roditelj;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            parent.DodajAgenta(txtIme.Text, dtAngazovanje.Value, (int)numProcenat.Value, txtTelefon.Text);
            Close();
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
