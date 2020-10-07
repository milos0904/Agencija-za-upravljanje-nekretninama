using Nekretnine.Entiteti;
using NHibernate;
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
    public partial class Kvartovi : Form
    {
        public int id_selektovanog { get; set; }
        public Kvartovi()
        {
            InitializeComponent();
            this.id_selektovanog = -1;
        }

        private void Kvartovi_Load(object sender, EventArgs e)
        {
            this.UcitajKvartove();
        }

        private void btnDodajKvart_Click(object sender, EventArgs e)
        {
            KvartInfo k = new KvartInfo(this, true);//true: da li je novo
            k.ShowDialog();
        }

        private void btnObrisiKvart_Click(object sender, EventArgs e)
        {
            if (listViewKvartovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kvart");
                return;
            }
            id_selektovanog = Int32.Parse(listViewKvartovi.SelectedItems[0].SubItems[0].Text);
            DialogResult dg = MessageBox.Show("Da li stvarno zelite da obrisete?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (dg == System.Windows.Forms.DialogResult.Yes)
            {//onda brisii

                KvartZamena idNovogKvarta = new KvartZamena(this);
                idNovogKvarta.ShowDialog();
                
            }

        }

        private void btnIzmeniKvart_Click(object sender, EventArgs e)
        {
            if (listViewKvartovi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite kvart");
                return;
            }
            id_selektovanog = Int32.Parse(listViewKvartovi.SelectedItems[0].SubItems[0].Text);
           
            KvartInfo k = new KvartInfo(this, false);
            k.ShowDialog();
        }

        #region Metode
        public void UcitajKvartove()
        {
            try
            {
                listViewKvartovi.Items.Clear();
                List<KvartPregled> kvartovi = DTOManager.vratiKvartove();

                foreach (KvartPregled p in kvartovi)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.KvartID.ToString(), p.gradskaZona });
                    listViewKvartovi.Items.Add(item);
                }
                listViewKvartovi.Refresh();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
