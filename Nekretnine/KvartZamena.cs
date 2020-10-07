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
    public partial class KvartZamena : Form
    {
        Kvartovi parent;

        public KvartZamena()
        {
            InitializeComponent();
        }

        public KvartZamena(Kvartovi roditelj)
        {
            InitializeComponent();
            parent = roditelj;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            if (!DTOManager.ObrisiKvart(parent.id_selektovanog, int.Parse(textBox1.Text)))
            {
                MessageBox.Show("ne postoji trazeni kvart");
                return;
            }
            parent.UcitajKvartove();
            parent.id_selektovanog = -1;
            this.Close();
        }
    }
}
