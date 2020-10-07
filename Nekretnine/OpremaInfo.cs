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
    public partial class OpremaInfo : Form
    {
        SveNekretnine parent=null;
        OpremaUpdate o_parent=null;
        public OpremaInfo()
        {
            InitializeComponent();
        }
        public OpremaInfo(SveNekretnine p)
        {
            InitializeComponent();
            parent = p;
        }
        public OpremaInfo(OpremaUpdate p)
        {
            InitializeComponent();
            o_parent = p;
        }
        #region Metode
        private void PopuniTxtBox()
        {
            Oprema o = DTOManager.vratiOpremu(this.o_parent.idSelektovane_Opreme);
            if (o != null)
                txtOprema.Text = o.oprema;
        }
        #endregion
        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            if(DTOManager.DodajOpremu(this.parent.id_selektovanaPoslovna, txtOprema.Text))
            {
                txtOprema.Text = "";
                this.parent.UcitajSvePoslovne();
            }

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (DTOManager.UpdateOprema(this.o_parent.idSelektovane_Opreme, txtOprema.Text))
            {
                this.o_parent.idSelektovane_Opreme = -1;
                txtOprema.Text = "";
                this.o_parent.UcitajOpreme();
            }
            else
                MessageBox.Show("Neuspesno");
           
        }

        private void OpremaInfo_Load(object sender, EventArgs e)
        {
            if( this.o_parent != null && this.o_parent.idSelektovane_Opreme !=-1)
            {
                btnDodajOpremu.Visible = false;
                btnIzmeni.Visible = true;
                this.PopuniTxtBox();
            }
        }
    }
}
