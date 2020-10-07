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
    public partial class AgentiPrikazivanje : Form
    {
        public List<AgentPregled> agenti;
        public int rbrAgent;
        public AgentiPrikazivanje()
        {
            InitializeComponent();
            rbrAgent = -1;
            agenti = new List<AgentPregled>();
        }

        private void AgentiPrikazivanje_Load(object sender, EventArgs e)
        {
            ucitajAgent();

        }
        #region Method 
        public void ucitajAgent()
        {
            try
            {
                listView1.Items.Clear();
                agenti = DTOManager.prikaziAgent();
                
                foreach (AgentPregled p in agenti)
                {
                    ListViewItem item = new ListViewItem(new string[] { p.Id.ToString(),p.Ime,p.DatumAngazovanja.ToString(),p.Telefon,p.Procenat.ToString(),p.IdZaposlenog.ToString() });
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite agenta klikom na njegov ID!");
                return;
            }
            rbrAgent = listView1.SelectedItems[0].Index;
            AgentInfo a = new AgentInfo(this);
            a.ShowDialog();
            ucitajAgent();
        }
    }
}
