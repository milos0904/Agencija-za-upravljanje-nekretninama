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
    public partial class SefInfo : Form
    {
        bool novo;
        ZaposleniISefovi parent;
        int id;

        public SefInfo()
        {
            InitializeComponent();
        }

        public SefInfo(ZaposleniISefovi roditelj, bool novo)
        {
            InitializeComponent();
            parent = roditelj;
            this.novo = novo;
            id = -1;
        }

        private void SefInfo_Load(object sender, EventArgs e)
        {
            if(!novo)
            {
                txtIme.Text = parent.sefovi[parent.rbr_sef].Ime;
                txtJMBG.Text = parent.sefovi[parent.rbr_sef].JMBG;
                dtZaposlenje.Value = parent.sefovi[parent.rbr_sef].DatumZaposlenja;
                dtPostavljanja.Value = parent.sefovi[parent.rbr_sef].DatumPostavljanja;
                txtPoslovnica.Text = parent.sefovi[parent.rbr_sef].PoslovnicaID.ToString();
                id = parent.sefovi[parent.rbr_sef].Id;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!DTOManager.IzmeneNovoSef(txtJMBG.Text, dtZaposlenje.Value, txtIme.Text, dtPostavljanja.Value, int.Parse(txtPoslovnica.Text), id))
            {
                MessageBox.Show("ne postoji poslovnica");
                return;
            }
            parent.UcitajSefove();
            this.Close();
        }

        private void txtJMBG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtPoslovnica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
