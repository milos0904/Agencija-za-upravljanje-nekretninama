using Nekretnine.Entiteti;
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
    public partial class OpremaUpdate : Form
    {
        SveNekretnine parent;
        public int idSelektovane_Opreme { get; set; }
        public OpremaUpdate()
        {
            InitializeComponent();
            this.idSelektovane_Opreme = -1;
        }
        public OpremaUpdate(SveNekretnine p)
        {
            InitializeComponent();
            parent = p;
            this.idSelektovane_Opreme = -1;
        }
        #region Metode
        public void UcitajOpreme()
        {
            List<Oprema> sveOpreme = DTOManager.VratiOpreme(this.parent.id_selektovanaPoslovna);
            listViewOpreme.Items.Clear();
            foreach (Oprema o in sveOpreme)
            {
                ListViewItem item = new ListViewItem(new string[] {o.ID.ToString(),o.oprema});
                listViewOpreme.Items.Add(item);
            }
            listViewOpreme.Refresh();
        }
        private DialogResult ObrisiSelektovano()
        {
            return MessageBox.Show("Da li zaista zelite da obrisete?", "Obavestenje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        #endregion
        private void OpremaUpdate_Load(object sender, EventArgs e)
        {
            if(parent.id_selektovanaPoslovna !=-1)
            {
                this.UcitajOpreme();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listViewOpreme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite opremu");
                return;
            }
            idSelektovane_Opreme = Int32.Parse(listViewOpreme.SelectedItems[0].SubItems[0].Text);
            OpremaInfo o = new OpremaInfo(this);
            o.ShowDialog();
            
        }

        private void btnObrisiOpremu_Click(object sender, EventArgs e)
        {
            if (listViewOpreme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite opremu");
                return;
            }
            idSelektovane_Opreme = Int32.Parse(listViewOpreme.SelectedItems[0].SubItems[0].Text);

            if(ObrisiSelektovano()== System.Windows.Forms.DialogResult.Yes)
            {
                DTOManager.ObrisiOpremu(idSelektovane_Opreme);
                this.UcitajOpreme();
            }
        }
    }
}
