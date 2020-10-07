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
    public partial class AgencijaZaNekretnine : Form
    {
        public AgencijaZaNekretnine()
        {
            InitializeComponent();
        }

        private void btnPoslovnice_Click(object sender, EventArgs e)
        {
            Poslovnice poslovnice = new Poslovnice();
            poslovnice.ShowDialog();
        }

        private void btnNekretnine_Click(object sender, EventArgs e)
        {
            SveNekretnine s = new SveNekretnine();
            s.ShowDialog();
        }
        private void btnKvartovi_Click(object sender, EventArgs e)
        {
            Kvartovi kvartovi = new Kvartovi();
            kvartovi.ShowDialog();
        }

        private void btnProdavci_Click(object sender, EventArgs e)
        {
            Prodavci prodavci = new Prodavci();
            prodavci.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniISefovi zaposleniISefovi = new ZaposleniISefovi();
            zaposleniISefovi.ShowDialog();
        }

        private void AgencijaZaNekretnine_Load(object sender, EventArgs e)
        {

        }

        private void btnMusterije_Click(object sender, EventArgs e)
        {
            Musterije musterije = new Musterije();
            musterije.ShowDialog();
        }

        private void btnAgenti_Click(object sender, EventArgs e)
        {
            AgentiPrikazivanje agenti = new AgentiPrikazivanje();
            agenti.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            Ugovori ugovori = new Ugovori();
            ugovori.ShowDialog();
        }
    }
}
