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
    public partial class Ugovori : Form
    {
        public List<KupoprodajniPregled> KupoprodajniUgovori;
        public List<UgovorOIznajmljivanjuPregled> ugovoriOIznajmljivanjuUgovori;

        
        public int rbr_ugovora;
        public Ugovori()
        {
            InitializeComponent();
            rbr_ugovora = -1;
        }

        private void Ugovori_Load(object sender, EventArgs e)
        {
            this.ucitajKupoprodajne();
            this.ucitajUgovoreOIznajmljivanju();
        }

        #region Methods
        public void ucitajUgovoreOIznajmljivanju()
        {
            try
            {
                listView2.Items.Clear();
                ugovoriOIznajmljivanjuUgovori = DTOManager.vratiUgovoreOIznajmljivanju();

                foreach (UgovorOIznajmljivanjuPregled p in ugovoriOIznajmljivanjuUgovori)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.ID.ToString(), p.Datum_Isteka.ToString(), p.Datum_Sklapanja.ToString(), p.Stanarina.ToString() });
                    listView2.Items.Add(item);
                }
                listView2.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void ucitajKupoprodajne() {
            try
            {
                listView1.Items.Clear();
                KupoprodajniUgovori = DTOManager.vratiKupoprodajneUgovore();

                foreach (KupoprodajniPregled p in KupoprodajniUgovori)
                {
                    ListViewItem item = new ListViewItem(new string[] {p.ID.ToString(), p.Datum_Transakcije.ToString()});
                    listView1.Items.Add(item);
                }
                listView1.Refresh();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
        
    }
}
