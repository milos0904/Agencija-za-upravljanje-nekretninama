using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Nekretnine.Entiteti;

namespace Nekretnine
{
    public partial class ProdavacPravnaInfo : Form
    {
         Prodavci parent;
        bool dodaj;
        public ProdavacPravnaInfo()
        {
            InitializeComponent();
        }
        public ProdavacPravnaInfo(Prodavci p,bool d)
        {
            parent = p;
            dodaj = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dodaj)
            {
                DTOManager.IzmeneProdavacPravno(parent.prodavciPravna[parent.rbr_prodavca].ID, textBox1.Text);
            }
            else
            {
                DTOManager.IzmeneProdavacPravno(-1, textBox1.Text);
            
            }
            textBox1.Text = "";
        }

        private void ProdavacPravnaInfo_Load(object sender, EventArgs e)
        {
            if (!dodaj)
            {
                textBox1.Text = parent.prodavciPravna[parent.rbr_prodavca].PIB;

              
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && textBox1.Text.Length < 14)
                e.Handled = true;
        }
    }
}
