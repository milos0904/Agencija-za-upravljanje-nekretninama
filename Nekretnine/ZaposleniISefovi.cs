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
    public partial class ZaposleniISefovi : Form
    {
        public List<ZaposlenPregled> zaposleni;
        public int rbr_zaposlen;

        public List<SefPregled> sefovi;
        public int rbr_sef;

        public ZaposleniISefovi()
        {
            InitializeComponent();
            rbr_zaposlen = -1;
            rbr_sef = -1;
        }

        private void ZaposleniISefovi_Load(object sender, EventArgs e)
        {
            UcitajSefove();
            UcitajZaposlene();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            ZaposleniInfo zaposleniInfo = new ZaposleniInfo(this, true);
            zaposleniInfo.ShowDialog();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (listViewZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite zaposlenog!");
                return;
            }
            rbr_zaposlen = listViewZaposleni.SelectedItems[0].Index;
            ZaposleniInfo zaposleniInfo = new ZaposleniInfo(this, false);
            zaposleniInfo.ShowDialog();
        }

        private void btnObrisiZaposlenog_Click(object sender, EventArgs e)
        {
            if (listViewZaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite zaposlenog!");
                return;
            }
            int rbr = listViewZaposleni.SelectedItems[0].Index;
            int id = zaposleni[rbr].Id;
            DTOManager.ObrisiZaposlenog(id);
            UcitajZaposlene();
        }

        private void btnDodajSefa_Click(object sender, EventArgs e)
        {
            SefInfo child = new SefInfo(this, true);
            child.Show();
        }

        private void btnIzmeniSefa_Click(object sender, EventArgs e)
        {
            if(listViewSefovi.SelectedItems.Count==0)
            {
                MessageBox.Show("Odaberite sefa!");
                return;
            }
            rbr_sef = listViewSefovi.SelectedItems[0].Index;
            SefInfo child = new SefInfo(this, false);
            child.Show();
        }

        private void btnObrisiSefa_Click(object sender, EventArgs e)
        {
            if (listViewSefovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite sefa!");
                return;
            }
            rbr_sef = listViewSefovi.SelectedItems[0].Index;
            int id = sefovi[rbr_sef].Id;
            DTOManager.ObrisiSefa(id);
            UcitajSefove();
        }


        #region Metode
        public void UcitajZaposlene()
        {
            listViewZaposleni.Items.Clear();
            zaposleni = DTOManager.vratiZaposlene();

            foreach (ZaposlenPregled z in zaposleni)
            {
                listViewZaposleni.Items.Add(
                    new ListViewItem(new string[] { z.Id.ToString(), z.JMBG, z.DatumZaposlenja.ToString(), z.Ime, z.StrucnaSprema })
                    );
            }
            listViewZaposleni.Refresh();
        }

        public void UcitajSefove()
        {
            listViewSefovi.Items.Clear();
            sefovi = DTOManager.vratiSefove();

            foreach (SefPregled sef in sefovi)
            {
                listViewSefovi.Items.Add(
                    new ListViewItem(new string[] { sef.Id.ToString(), sef.JMBG, sef.DatumZaposlenja.ToString(), sef.Ime, sef.DatumPostavljanja.ToString() })
                    );
            }
            listViewSefovi.Refresh();
        }
        #endregion

    }
}
