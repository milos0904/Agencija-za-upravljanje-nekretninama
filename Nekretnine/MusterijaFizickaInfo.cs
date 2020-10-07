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
    public partial class MusterijaFizickaInfo : Form
    {
        Musterije parent;
        bool dodaj;

        public MusterijaFizickaInfo()
        {
            InitializeComponent();
        }

        
        public MusterijaFizickaInfo(Musterije p, bool d)
        {
            parent = p;
            dodaj = d;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
      /*  private void button1_Click(object sender, EventArgs e)
        {
            if (!dodaj)
                DTOManager.IzmeneMusterijaFizicko(parent.musterijaFizicko[parent.rbr_musterije].ID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            else
                DTOManager.IzmeneMusterijaFizicko(-1, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox1.Text = "";

        }*/
        private void MusterijaFizickaInfo_Load(object sender, EventArgs e)
        {
            if (!dodaj)
            {
                textBox1.Text = parent.musterijaFizicko[parent.rbr_musterije].JMBG;
                textBox2.Text = parent.musterijaFizicko[parent.rbr_musterije].Ime;
                textBox3.Text = parent.musterijaFizicko[parent.rbr_musterije].Prezime;
                textBox4.Text = parent.musterijaFizicko[parent.rbr_musterije].Adresa;
                textBox5.Text = parent.musterijaFizicko[parent.rbr_musterije].Telefon;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && textBox1.Text.Length < 14)
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!dodaj)
                DTOManager.IzmeneMusterijaFizicko(parent.musterijaFizicko[parent.rbr_musterije].ID, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            else
                DTOManager.IzmeneMusterijaFizicko(-1, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            textBox1.Text = "";
        }
    }
}
