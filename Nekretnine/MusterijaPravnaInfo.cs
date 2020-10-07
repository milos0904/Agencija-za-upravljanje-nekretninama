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
    public partial class MusterijaPravnaInfo : Form
    {
        Musterije parent;
        bool dodaj;
        public MusterijaPravnaInfo()
        {
            InitializeComponent();
        }

        

        public MusterijaPravnaInfo(Musterije m, bool d) {
            parent = m;
            dodaj = d;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!dodaj)
            {
                DTOManager.IzmeneMusterijaPravno(parent.musterijaPravna[parent.rbr_pravnogLica].ID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            }
            else {
                DTOManager.IzmeneMusterijaPravno(-1, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            }
            textBox1.Text = "";
        }
        private void MusterijaPravnaInfo_Load(object sender, EventArgs e)
        {
            if (!dodaj) {
                textBox1.Text = parent.musterijaPravna[parent.rbr_pravnogLica].PIB;
                textBox2.Text = parent.musterijaPravna[parent.rbr_pravnogLica].JMBG;
                textBox3.Text = parent.musterijaPravna[parent.rbr_pravnogLica].Ime;
                textBox4.Text = parent.musterijaPravna[parent.rbr_pravnogLica].Prezime;
                textBox5.Text = parent.musterijaPravna[parent.rbr_pravnogLica].Adresa;
                textBox6.Text = parent.musterijaPravna[parent.rbr_pravnogLica].Telefon;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && textBox1.Text.Length < 14)
                e.Handled = true;
        }
    }
    
}
