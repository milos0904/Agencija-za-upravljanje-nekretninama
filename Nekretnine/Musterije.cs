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
    public partial class Musterije : Form
    {
        public List<MusterijaFizickoLicePregled> musterijaFizicko;
        public List<MusterijaPravnoLicePregled> musterijaPravna;
        public int rbr_musterije;
        public int rbr_pravnogLica;
        public Musterije()
        {
            InitializeComponent();
            rbr_musterije = -1;
            rbr_pravnogLica = -1;
        }

        private void Musterije_Load(object sender, EventArgs e)
        {
            this.ucitajFizicka();
            this.ucitajPravna();
        }

        #region Method
        public void ucitajFizicka()
        {
            try
            {
                listView1.Items.Clear();
                musterijaFizicko = DTOManager.vratiFMusterije();

                foreach (MusterijaFizickoLicePregled p in musterijaFizicko)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.JMBG, p.Ime, p.Prezime, p.Adresa, p.Telefon });
                    listView1.Items.Add(item);
                }
                listView1.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ucitajPravna()
        {
            try
            {
                listView2.Items.Clear();
                musterijaPravna = DTOManager.vratiPMusterije();

                foreach (MusterijaPravnoLicePregled p in musterijaPravna)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.PIB, p.JMBG, p.Ime, p.Prezime, p.Adresa, p.Telefon });
                    listView2.Items.Add(item);
                }
                listView2.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
       
        private void button6_Click_1(object sender, EventArgs e)
        {
            //dodajFizicko
            MusterijaFizickaInfo m = new MusterijaFizickaInfo(this, true);
            m.ShowDialog();
            ucitajFizicka();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //izmeniFizicko
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite musteriju klikom na njen ID!");
                return;
            }
            rbr_musterije = listView1.SelectedItems[0].Index;
            MusterijaFizickaInfo m = new MusterijaFizickaInfo(this, false);
            m.ShowDialog();
            ucitajFizicka();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //dodajPravno
            MusterijaPravnaInfo m = new MusterijaPravnaInfo(this, true);
            m.ShowDialog();
            ucitajPravna();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //izmeniPRavno
            if (listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite musteriju klikom na njen ID!");
                return;
            }
            rbr_pravnogLica = listView2.SelectedItems[0].Index;
            MusterijaPravnaInfo m = new MusterijaPravnaInfo(this, false);
            m.ShowDialog();
            ucitajPravna();
        }

        /*private void button4_Click(object sender, EventArgs e)
        {

        }*/
    }
}
