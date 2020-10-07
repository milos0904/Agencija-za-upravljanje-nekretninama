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
    public partial class Iznajmljivanje : Form
    {
        SveNekretnine parent;
        bool tipNekretnine; //true je stambena, false je poslovna
        public Iznajmljivanje()
        {
            InitializeComponent();
        }
        public Iznajmljivanje(SveNekretnine p,bool tip)
        {
            InitializeComponent();
            this.parent = p;
            tipNekretnine = tip;
        }


        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if(txtStanarina.Text=="" || txtIDmusterije.Text=="" || txtIDProdavca.Text=="" || txtIDZaposlenog.Text =="")
            {
                MessageBox.Show("Popunite sva polja");
                return;
            }
            if(tipNekretnine)
            {
                string s = DTOManager.IznajmiStambenuNekretninu(parent.id_selektovanaStambena, int.Parse(txtStanarina.Text), dateTimepocetak.Value, dateTimekraj.Value, int.Parse(txtIDmusterije.Text), int.Parse(txtIDProdavca.Text), int.Parse(txtIDZaposlenog.Text));

                if (s.Equals("uspesno"))
                    MessageBox.Show("Uspesno ste iznajmili");
                else
                    MessageBox.Show(s);
                this.parent.id_selektovanaStambena = -1;
                txtStanarina.Text = "";
                dateTimepocetak.Value= System.DateTime.Now;
                dateTimekraj.Value = System.DateTime.Now;
                txtIDmusterije.Text = "";
                txtIDProdavca.Text = "";
                txtIDZaposlenog.Text = "";
                this.Close();
            }
            else
            {
                string s = DTOManager.IznajmiPoslovnuNekretninu(parent.id_selektovanaStambena, int.Parse(txtStanarina.Text), dateTimepocetak.Value, dateTimekraj.Value, int.Parse(txtIDmusterije.Text), int.Parse(txtIDProdavca.Text), int.Parse(txtIDZaposlenog.Text));

                if (s.Equals("uspesno"))
                    MessageBox.Show("Uspesno ste iznajmili");
                else
                    MessageBox.Show(s);
                this.parent.id_selektovanaPoslovna = 1;
                txtStanarina.Text = "";
                dateTimepocetak.Value = System.DateTime.Now;
                dateTimekraj.Value = System.DateTime.Now;
                txtIDmusterije.Text = "";
                txtIDProdavca.Text = "";
                txtIDZaposlenog.Text = "";
                this.Close();
            }  
        }

        private void txtStanarina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDmusterije_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtIDProdavca_KeyPress(object sender, KeyPressEventArgs e)
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
