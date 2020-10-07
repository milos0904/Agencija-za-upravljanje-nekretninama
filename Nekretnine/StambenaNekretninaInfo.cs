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
    public partial class StambenaNekretninaInfo : Form
    {
        SveNekretnine parent;
        public StambenaNekretninaInfo()
        {
            InitializeComponent();
        }
        public StambenaNekretninaInfo(SveNekretnine s)
        {
            InitializeComponent();
            parent = s;
            
        }
        #region Metode
        private void PopuniFormu()
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina n = s.Load<StambenaNekretnina>(this.parent.id_selektovanaStambena);
                txtUlica.Text = n.Ime_ulice;
                numericBroj.Value = n.Broj;
                numericSprat.Value = n.Sprat;
                datumIzgradnje.Value = n.Datum_izgradnje;
                if (n.p_i == "p")
                    radioProdaja.Checked = true;
                else
                    radioIznajmljivanje.Checked = true;
                numBrojKupatila.Value = n.Broj_kupatila;
                txtCenaStambene.Text = n.Cena.ToString();
                numIDKvarta.Value = n.Kvart.ID;
                numIDProdavca.Value = n.Prodavac.ID;
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        private void StambenaNekretninaInfo_Load(object sender, EventArgs e)
        {
            if(parent.id_selektovanaStambena != -1)
            {
                btnDodajStambenu.Visible = false;
                btnIzmeniStambenu.Visible = true;
                this.PopuniFormu();
            }
            
        }

        private void btnDodajStambenu_Click(object sender, EventArgs e)
        {
            if (txtUlica.Text == "" || txtCenaStambene.Text == "")
            {
                MessageBox.Show("Popunite sva polja");
                return;
            }

            if (!(DTOManager.Da_li_postoji_kvart(int.Parse(numIDKvarta.Value.ToString()))))
            {
                MessageBox.Show("Ne postoji taj kvart");
                return;
            }
              
            if (!(DTOManager.Da_li_postoji_prodavac(int.Parse(numIDProdavca.Value.ToString()))))
            {
                MessageBox.Show("Ne postoji prodavac");
                return;
            }
            string p=null; //prodaje se
            if (radioProdaja.Checked)
                p = "p"; //iznajmljuje se
            else
                p = "i";
            
            DTOManager.DodajStambenuNekretninu(txtUlica.Text, int.Parse(numericBroj.Value.ToString()), int.Parse(numericSprat.Value.ToString()),datumIzgradnje.Value, int.Parse(txtCenaStambene.Text), int.Parse(numBrojKupatila.Value.ToString()),p, int.Parse(numIDKvarta.Value.ToString()), int.Parse(numIDProdavca.Value.ToString()));

            txtUlica.Text = "";
            txtCenaStambene.Text = "";
            numericBroj.Value = 0;
            numericSprat.Value = 0;
            numBrojKupatila.Value = 0;
            numIDKvarta.Value = 0;
            numIDProdavca.Value = 0;
            datumIzgradnje.Value = System.DateTime.Now;
            radioProdaja.Checked = true;

            parent.UcitajSveStambene();


        }

        private void btnIzmeniStambenu_Click(object sender, EventArgs e)
        {
            string p_i = null; //prodaja, iznajmljivanje
            if (radioProdaja.Checked)
                p_i = "p";
            else
                p_i = "i";


            if(!(DTOManager.UpdateStambenuNekretninu(this.parent.id_selektovanaStambena,txtUlica.Text,int.Parse(numericBroj.Value.ToString()),int.Parse(numericSprat.Value.ToString()),datumIzgradnje.Value,int.Parse(txtCenaStambene.Text),p_i,int.Parse(numBrojKupatila.Value.ToString()),int.Parse(numIDKvarta.Value.ToString()),int.Parse(numIDProdavca.Value.ToString()))))
            {
                MessageBox.Show("Nisu unete izmene");
                return;
            }

            this.parent.id_selektovanaStambena = -1;
            this.parent.UcitajSveStambene();
            this.Close();

        }

        private void txtCenaStambene_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
