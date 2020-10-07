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
    public partial class PoslovnaNekretninaInfo : Form
    {
        SveNekretnine parent;
        public PoslovnaNekretninaInfo()
        {
            InitializeComponent();
        }
        public PoslovnaNekretninaInfo(SveNekretnine p)
        {
            InitializeComponent();
            parent = p;
        }
        #region Metode
        private void PopuniFormu()
        {
            try
            {
                
                ISession s = DataLayer.GetSession();

                PoslovnaNekretnina pn = s.Load<PoslovnaNekretnina>(parent.id_selektovanaPoslovna);

                txtNazivUlice.Text = pn.Ime_ulice;
                numericBroj.Value = pn.Broj;
                numericSprat.Value = pn.Sprat;
                dateIzgradnja.Value = pn.Datum_izgradnje;
                txtCena.Text = pn.Cena.ToString();
                if (pn.p_i == "p")
                    radioProdaja.Checked = true;
                else
                    radioIznajmljivanje.Checked = true;
                if (pn.Sala == "true")
                    radioPoseduje.Checked = true;
                else
                    radioNePoseduje.Checked = true;

                numericIDKvarta.Value = pn.Kvart.ID;
                numericIDProdavca.Value = pn.Prodavac.ID;

                s.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btnDodajNekretninu_Click(object sender, EventArgs e)
        {
            string p_i = "p";
            if (radioIznajmljivanje.Checked)
                p_i = "i";
            string sala = "true";
            if (radioNePoseduje.Checked)
                sala = "false";

            string r = DTOManager.DodajPoslovnuNekretninu(txtNazivUlice.Text, int.Parse(numericBroj.Value.ToString()), int.Parse(numericSprat.Value.ToString()), dateIzgradnja.Value, int.Parse(txtCena.Text), p_i, sala, int.Parse(numericIDKvarta.Value.ToString()), int.Parse(numericIDProdavca.Value.ToString()));

            if (r.Equals("dodato"))
            {
                MessageBox.Show("Uspesno dodata nekretnina");
                txtNazivUlice.Text = "";
                numericBroj.Value = 0;
                txtCena.Text = "";
                numericSprat.Value = 0;
                dateIzgradnja.Value = System.DateTime.Now;
                radioNePoseduje.Checked = false;
                radioPoseduje.Checked = true;
                radioProdaja.Checked = true;
                radioIznajmljivanje.Checked = false;
                parent.UcitajSvePoslovne();
            }
            else
                MessageBox.Show(r);

        }

        private void btnIzmeniNekretninu_Click(object sender, EventArgs e)
        {
            string p_i = "p"; //prodaja
            if (radioIznajmljivanje.Checked)
                p_i = "i"; //iznajmljivanje

            string sala = "false";
            if (radioPoseduje.Checked)
                sala = "true"; //ima salu
            string p = DTOManager.UpdatePoslovnuNekretninu(this.parent.id_selektovanaPoslovna, txtNazivUlice.Text, int.Parse(numericBroj.Value.ToString()), int.Parse(numericSprat.Value.ToString()), dateIzgradnja.Value, int.Parse(txtCena.Text), p_i, sala, int.Parse(numericIDKvarta.Value.ToString()), int.Parse(numericIDProdavca.Value.ToString()));

            if (p == "uspesno")
            {
                MessageBox.Show("Uspesno ste azurirali");
                this.parent.id_selektovanaPoslovna = -1;
                this.parent.UcitajSvePoslovne();
                this.Close();
            }
            else
                MessageBox.Show(p);
        }

        private void PoslovnaNekretninaInfo_Load(object sender, EventArgs e)
        {
            if (parent.id_selektovanaPoslovna != -1)
            {
                btnDodajNekretninu.Visible = false;
                btnIzmeniNekretninu.Visible = true;
                this.PopuniFormu();
            }
        }

        private void txtCena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
