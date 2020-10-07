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
    public partial class KvartInfo : Form
    {
        Kvartovi parent;
        bool novo;
        int id;

        public KvartInfo()
        {
            InitializeComponent();
        }

        public KvartInfo(Kvartovi k, bool novo)
        {
            InitializeComponent();
            parent = k;
            this.novo = novo;
            id = -1;
        }

        private void KvartInfo_Load(object sender, EventArgs e)
        {
            if (!novo)
            {
                KvartPregled k = DTOManager.KvartCeo(parent.id_selektovanog);
                txtGradskaZona.Text = k.gradskaZona;
                txtPoslovnica.Text = k.PoslovnicaID.ToString();
                id = k.KvartID;
            }
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            //setuj parent.id_selektovanog=-1 :D
            int idp = int.Parse(txtPoslovnica.Text);
            if(DTOManager.IzmeneNovoKvart(id, txtGradskaZona.Text, idp)==-1)
            {
                MessageBox.Show("Ne postoji trazena poslovnica");
                return;//imas sansu samo  to da izmenis :D
            }
            parent.id_selektovanog = -1;
            parent.UcitajKvartove();
            this.Close();
        }
        
        private void txtPoslovnica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
