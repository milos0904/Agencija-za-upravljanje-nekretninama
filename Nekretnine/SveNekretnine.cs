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
    public partial class SveNekretnine : Form
    {
        public int id_selektovanaStambena { get; set; }
        public int id_selektovanaPoslovna { get; set; }
        public SveNekretnine()
        {
            InitializeComponent();
            this.id_selektovanaPoslovna = -1;
            this.id_selektovanaStambena = -1;
        }
        

        #region Metode
        public void UcitajSvePoslovne()
        {
            listViewSvePoslovne.Items.Clear();
            List<NekretninaPoslovnaPregled> lista = DTOManager.UcitajPoslovne();
            foreach(NekretninaPoslovnaPregled n in lista)
            {
                string p = "Nema";
                if(n.Sala == "true")
                {
                    p = "Ima";
                }
                ListViewItem item = new ListViewItem(new string[] { n.ID.ToString(), n.Ulica, n.Broj.ToString(), n.Sprat.ToString(), n.Datum_izgradnje.ToString(), n.Cena.ToString(), n.Prodaja_Iznajmljivanje,p, n.ID_Kvarta.ToString(), n.ID_Prodavca.ToString(),n.Oprema });
                listViewSvePoslovne.Items.Add(item);
            }
            listViewSvePoslovne.Refresh();
        }
        public void UcitajSveStambene()
        {
            listViewStambene.Items.Clear();
            List<NekretninaStambenaPregled> lista = DTOManager.UcitajStambene();
            foreach (NekretninaStambenaPregled n in lista)
            {
                ListViewItem item = new ListViewItem(new string[] { n.ID.ToString(), n.Ulica, n.Broj.ToString(), n.Sprat.ToString(), n.Datum_izgradnje.ToString(), n.Cena.ToString(),n.Prodaja_Iznajmljivanje,n.Broj_Kupatila.ToString(),n.ID_Kvarta.ToString(),n.ID_Prodavca.ToString()});
                listViewStambene.Items.Add(item);
            }
            listViewStambene.Refresh();
        }
        private DialogResult ObrisiSelektovano()
        {
            return MessageBox.Show("Da li zaista zelite da obrisete?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion
        private void SveNekretnine_Load(object sender, EventArgs e)
        {
            this.UcitajSvePoslovne();
            this.UcitajSveStambene();
        }

        private void btnIznajmiStambenu_Click(object sender, EventArgs e)
        {
            if (listViewStambene.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite stambenu nekretninu");
                return;
            }
            this.id_selektovanaStambena = Int32.Parse(listViewStambene.SelectedItems[0].SubItems[0].Text);
            Iznajmljivanje s = new Iznajmljivanje(this,true); //true je stambena, false je poslovna
            s.ShowDialog();
        }

        private void btnDodajStambenu_Click(object sender, EventArgs e)
        {
            this.id_selektovanaStambena = -1;
            StambenaNekretninaInfo s = new StambenaNekretninaInfo(this);
            s.ShowDialog();           
        }

        private void btnIzmeniStambenu_Click(object sender, EventArgs e)
        {
            if (listViewStambene.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite stambenu nekretninu");
                return;
            }
            this.id_selektovanaStambena= Int32.Parse(listViewStambene.SelectedItems[0].SubItems[0].Text);
            StambenaNekretninaInfo s = new StambenaNekretninaInfo(this);
            s.ShowDialog();
        }

        private void btnObrisiStabmenu_Click(object sender, EventArgs e)
        {
            if (listViewStambene.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaStambena = Int32.Parse(listViewStambene.SelectedItems[0].SubItems[0].Text);
            if (this.ObrisiSelektovano() == System.Windows.Forms.DialogResult.Yes)
            {
                DTOManager.ObrisiStambenuNekretninu(this.id_selektovanaStambena);

                this.UcitajSveStambene();
                this.id_selektovanaStambena = -1;
            }
        }

        private void btnKupiStambenu_Click(object sender, EventArgs e)
        {
            if(listViewStambene.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaStambena = Int32.Parse(listViewStambene.SelectedItems[0].SubItems[0].Text);
            KupoprodajniUgovor k = new KupoprodajniUgovor(this,false); //false znaci da je stambena,pogledaj u KupoprodajniUgovor
            k.ShowDialog();
        }

        private void btnDodajPoslovnu_Click(object sender, EventArgs e)
        {
            this.id_selektovanaPoslovna = -1;
            PoslovnaNekretninaInfo p = new PoslovnaNekretninaInfo(this);
            p.ShowDialog();
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaPoslovna = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            OpremaInfo o = new OpremaInfo(this);
            o.ShowDialog();
        }

        private void btnIzmeniPoslovnu_Click(object sender, EventArgs e)
        {
            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaPoslovna = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            PoslovnaNekretninaInfo p = new PoslovnaNekretninaInfo(this);
            p.ShowDialog();
        }

       
        private void btnIzmeniOpremu_Click(object sender, EventArgs e)
        {

            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaPoslovna = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            OpremaUpdate o = new OpremaUpdate(this);
            o.ShowDialog();
            this.UcitajSvePoslovne();
        }

        private void btnObrisiPoslovnu_Click(object sender, EventArgs e)
        {
            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaPoslovna = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            if (this.ObrisiSelektovano() == System.Windows.Forms.DialogResult.Yes)
            {
                DTOManager.ObrisiPoslovnuNekretninu(id_selektovanaPoslovna);
                this.UcitajSvePoslovne();
            }
        }

        private void btnKupiPoslovnu_Click(object sender, EventArgs e)
        {
            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite nekretninu");
                return;
            }
            this.id_selektovanaPoslovna = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            KupoprodajniUgovor k = new KupoprodajniUgovor(this, true);//true-poslovna, pogledati Kupoprodajni ugovor
            k.ShowDialog();
        }

        private void btnIznajmiPoslovnu_Click(object sender, EventArgs e)
        {
            if (listViewSvePoslovne.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite poslovnu nekretninu");
                return;
            }

            this.id_selektovanaStambena = Int32.Parse(listViewSvePoslovne.SelectedItems[0].SubItems[0].Text);
            Iznajmljivanje s = new Iznajmljivanje(this, false); //true je stambena, false je poslovna
            s.ShowDialog();
        }
    }
}
