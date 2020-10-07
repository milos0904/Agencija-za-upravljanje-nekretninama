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
using Nekretnine.Entiteti;

namespace Nekretnine
{
    public partial class ProdavacInfo : Form
    {
        Prodavci parent;
        bool dodaj;
        public ProdavacInfo()
        {
            InitializeComponent();
        }
        public ProdavacInfo(Prodavci p,bool d)
        {
            parent = p;
            InitializeComponent();
            dodaj = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dodaj)
                DTOManager.IzmeneProdavacFizicko(parent.prodavci[parent.rbr_prodavca].ID, textBox1.Text);
            else
                DTOManager.IzmeneProdavacFizicko(-1, textBox1.Text);
            textBox1.Text = "";

        }

        private void ProdavacInfo_Load(object sender, EventArgs e)
        {
            if (!dodaj)
            {
                textBox1.Text = parent.prodavci[parent.rbr_prodavca].JMBG;
            }

        }
       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && textBox1.Text.Length<14)
                e.Handled = true;
        }
    }
}
