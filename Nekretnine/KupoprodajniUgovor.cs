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
    
    public partial class KupoprodajniUgovor : Form
    {
        SveNekretnine parent;
        bool tipNekretnine; //true=stambena, false=poslovna
        public KupoprodajniUgovor()
        {
            InitializeComponent();
        }
        public KupoprodajniUgovor(SveNekretnine s,bool tip)
        {
            InitializeComponent();
            this.parent = s;
            this.tipNekretnine = tip;
        }

        private void btnKupiStambenu_Click(object sender, EventArgs e)
        {
            if (tipNekretnine)
            {
                string p = DTOManager.KupiStambenuNekretninu(this.parent.id_selektovanaStambena, System.DateTime.Now, int.Parse(txtIDProdavca.Text), int.Parse(txtIDMusterije.Text), int.Parse(txtIDZaposlenog.Text)); 
                if(p != "Prodato")
                {
                    MessageBox.Show(p);
                    return;
                }
                MessageBox.Show(p);
                txtIDZaposlenog.Text = "";
                txtIDProdavca.Text = "";
                txtIDMusterije.Text = "";
                this.parent.id_selektovanaStambena = -1;
            }
            else
            {
                string p = DTOManager.KupiPoslovnuNekretninu(this.parent.id_selektovanaPoslovna, System.DateTime.Now, int.Parse(txtIDProdavca.Text), int.Parse(txtIDMusterije.Text), int.Parse(txtIDZaposlenog.Text));
                if(p != "Prodato")
                {
                    MessageBox.Show(p);
                    return;
                }
                MessageBox.Show(p);
                txtIDZaposlenog.Text = "";
                txtIDProdavca.Text = "";
                txtIDMusterije.Text = "";
                this.parent.id_selektovanaPoslovna = -1;
            }
           
             
        }

        private void txtIDProdavca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDMusterije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDZaposlenog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
