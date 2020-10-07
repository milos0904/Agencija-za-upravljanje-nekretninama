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
    public partial class Poslovnice : Form
    {
        public int id_selektovanog { get; set; }
        public Poslovnice()
        {
            InitializeComponent();
            this.id_selektovanog = -1;
        }
        #region Metode
        public void UcitajPoslovnice()
        {
            try
            {
                listViewSvePoslovnice.Items.Clear();
                List<PoslovnicaPregled> poslovnice = DTOManager.vratiPoslovnice();

                foreach (PoslovnicaPregled p in poslovnice)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.PoslovnicaID.ToString(), p.Adresa, p.RadnoVreme });

                    listViewSvePoslovnice.Items.Add(item);
                }
                listViewSvePoslovnice.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        DialogResult ObrisiSelektovan()
        {
            return MessageBox.Show("Da li stvarno zelite da obrisete?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion

        private void Poslovnice_Load(object sender, EventArgs e)
        {
            this.UcitajPoslovnice();
        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            PoslovnicaInfo pInfo = new PoslovnicaInfo(this);
            pInfo.ShowDialog();
        }

        private void btnObrisiSelektovanu_Click(object sender, EventArgs e)
        {
            
                if (listViewSvePoslovnice.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Odaberite poslovnicu");
                    return;
                }
                id_selektovanog = Int32.Parse(listViewSvePoslovnice.SelectedItems[0].SubItems[0].Text);
                if (this.ObrisiSelektovan() == System.Windows.Forms.DialogResult.Yes)
                {

                    DTOManager.ObrisiPoslovnicu(id_selektovanog);


                    this.UcitajPoslovnice();
                    this.id_selektovanog = -1;
                }
            
           
        }

        private void btnIzmeniPoslovnicu_Click(object sender, EventArgs e)
        {
            if(listViewSvePoslovnice.SelectedItems.Count==0)
            {
                MessageBox.Show("Odaberite poslovnicu");
                return;
            }
            id_selektovanog = Int32.Parse(listViewSvePoslovnice.SelectedItems[0].SubItems[0].Text);
            PoslovnicaInfo p = new PoslovnicaInfo(this);
            p.ShowDialog();
        }
    }
}
