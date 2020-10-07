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
    public partial class Prodavci : Form
    {

        public List<ProdavacFizickoLicePregled> prodavci;

        public List<ProdavacPravnoLicePregled> prodavciPravna;
        public int rbr_prodavca;
        public Prodavci()
        {

            InitializeComponent();
            rbr_prodavca = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void Prodavci_Load(object sender, EventArgs e)
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
                prodavci = DTOManager.vratiFProdavce();

                foreach (ProdavacFizickoLicePregled p in prodavci)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.JMBG });
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
                    prodavciPravna = DTOManager.vratiPProdavce();

                    foreach (ProdavacPravnoLicePregled p in prodavciPravna)
                    {
                        ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.PIB });
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

        private void button1_Click(object sender, EventArgs e)
        {
            //dodajFizicko
            ProdavacInfo p = new ProdavacInfo(this,true);
            p.ShowDialog();
            ucitajFizicka();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dodajPravno
            ProdavacPravnaInfo p = new ProdavacPravnaInfo(this,true);
            p.ShowDialog();
            ucitajPravna();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //izmeniFizicko
            if(listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite prodavca klikom na njegov ID!");
                return;
            }
            rbr_prodavca = listView1.SelectedItems[0].Index;
            ProdavacInfo p = new ProdavacInfo(this, false);
            p.ShowDialog();
            ucitajFizicka();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //izmeniPRavno
            if(listView2.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite prodavca klikom na njegov ID!");
                return;
            }
            rbr_prodavca = listView2.SelectedItems[0].Index;
            ProdavacPravnaInfo p = new ProdavacPravnaInfo(this, false);
            p.ShowDialog();
            ucitajPravna();
        }

       
    }
}
