using Nekretnine.Entiteti;
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

namespace Nekretnine
{
    public partial class PoslovnicaInfo : Form
    {
        Poslovnice parent;

        public PoslovnicaInfo()
        {
            InitializeComponent();
        }
        public PoslovnicaInfo(Poslovnice p )
        {
            this.parent = p;
            InitializeComponent();
        }
        #region Metode 
       
        private void ucitajSelektovano()
        {
            ISession s = DataLayer.GetSession();

            Poslovnica p = s.Load<Poslovnica>(parent.id_selektovanog);

            txtAdresa.Text = p.adresa;
            txtRadnoVreme.Text = p.radno_vreme;
            txtSef.Text = p.PripadaSefu.JMBG;

            s.Close();
        }
        #endregion

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                string jmbg = txtSef.Text;
                int id_sefa = DTOManager.vratiID_Sefa(jmbg);
                if (id_sefa == -1)
                {
                    MessageBox.Show("Ne postoji sef ciji je JMBG: " + jmbg);
                }
                else
                {
                    DTOManager.SacuvajPoslovnicu(txtAdresa.Text,txtRadnoVreme.Text,id_sefa);
                    

                    txtAdresa.Text = "";
                    txtRadnoVreme.Text = "";
                    txtSef.Text = "";
                    parent.UcitajPoslovnice();
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void PoslovnicaInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (parent.id_selektovanog != -1)
                {
                    btnSacuvaj.Visible = false;
                    btnSacuvajIzmene.Visible= true;

                    this.ucitajSelektovano();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnSacuvajIzmene_Click(object sender, EventArgs e)
        {
            try
            {
                int id_sefa = DTOManager.vratiID_Sefa(txtSef.Text);
                if(id_sefa == -1)
                {
                    MessageBox.Show("Ne postoji sef ciji je JMBG: " + txtSef.Text);
                    return;                            
                }
                
                if(!DTOManager.UpdatePoslovnica(parent.id_selektovanog,txtAdresa.Text,txtRadnoVreme.Text,id_sefa))
                {
                    MessageBox.Show("Nisu unete izmene");
                    return;
                }

                parent.UcitajPoslovnice();
                parent.id_selektovanog = -1;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
