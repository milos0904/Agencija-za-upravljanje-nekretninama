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
    public partial class ZaposleniInfo : Form
    {
        ZaposleniISefovi parent;
        List<AgentPregled> mojiAgenti;
        bool novo;
        int id;

        public ZaposleniInfo()
        {
            InitializeComponent();
            novo = true;
            mojiAgenti = new List<AgentPregled>();
        }
        public ZaposleniInfo(ZaposleniISefovi zaposleni, bool novo)
        {
            InitializeComponent();
            parent = zaposleni;
            this.novo = novo;
            id = -1;

            mojiAgenti = new List<AgentPregled>();
        }

        private void ZaposleniInfo_Load(object sender, EventArgs e)
        {
            //ucitavas sefa ako moze :D
            if(!novo)
            {
                //pa ucitaj brt
                txtJMBG.Text = parent.zaposleni[parent.rbr_zaposlen].JMBG.ToString();
                dtZaposlenje.Value = parent.zaposleni[parent.rbr_zaposlen].DatumZaposlenja;
                txtIme.Text = parent.zaposleni[parent.rbr_zaposlen].Ime;
                txtStrucna.Text = parent.zaposleni[parent.rbr_zaposlen].StrucnaSprema;
                txtPoslovnica.Text = parent.zaposleni[parent.rbr_zaposlen].PoslovnicaID.ToString();
                id = parent.zaposleni[parent.rbr_zaposlen].Id;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(!DTOManager.IzmeneNovoZaposlen(mojiAgenti, txtJMBG.Text, dtZaposlenje.Value, txtIme.Text, txtStrucna.Text, int.Parse(txtPoslovnica.Text), id))
            {
                MessageBox.Show("Ne postoji poslovnica sa zadatim id");
                return;
            }
            parent.UcitajZaposlene();
            this.Close();
        }

        private void btnAngazuj_Click(object sender, EventArgs e)
        {
            NoviAgent child = new NoviAgent(this);
            child.Show();
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


        #region Metode
        public void DodajAgenta(string ime, DateTime angazovanje, int proc, string tel)
        {
            mojiAgenti.Add(new AgentPregled(ime, angazovanje, proc, tel));
        }
        #endregion

        private void txtStrucna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
