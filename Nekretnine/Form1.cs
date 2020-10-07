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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUcitajNekretninu_Click(object sender, EventArgs e)
        {
            try { 
            ISession sesija = DataLayer.GetSession();
            Nekretnina nova = sesija.Load<PoslovnaNekretnina>(4);
            MessageBox.Show(nova.Ime_ulice);//Koch Haven
            }catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodavanjeNoveNekretnine_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                StambenaNekretnina st = new StambenaNekretnina();
                ProdavacFizickoLice pf = sesija.Load<ProdavacFizickoLice>(8);
                Kvart k = sesija.Load<Kvart>(4);
                MessageBox.Show("JMBG: " + pf.JMBG);
                MessageBox.Show(k.Gradska_zona);

                st.Ime_ulice = "Test ulica";
                st.Sprat = 4;
                st.p_i = "p"; //p-prodaja
                st.Datum_izgradnje = new DateTime(2019, 11, 13);
                st.Broj = 5;
                st.Broj_kupatila = 2;
                st.Cena = 55000;
                st.Prodavac = pf;
                st.Kvart = k;

                sesija.Save(st);
                sesija.Close();
                MessageBox.Show("Nekretnina je uspesno dodata");
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVezaManytoOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Nekretnina n = s.Load<Nekretnina>(7);

                MessageBox.Show(n.Prodavac.ID.ToString());
                MessageBox.Show(n.Kvart.Gradska_zona);
                MessageBox.Show(n.Starost().ToString());


                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajMusteriju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();

                MusterijaFizickoLice ml = sesija.Load<MusterijaFizickoLice>(6);
                MusterijaPravnoLice pl = sesija.Load<MusterijaPravnoLice>(4);



                MessageBox.Show("Musterija fizicko lice: " + ml.Ime + " JMBG: " + ml.JMBG);
                MessageBox.Show("Musterija pravno lice: " + pl.Ime + " ,pib: " + pl.Pib);

                sesija.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajMusteriju_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MusterijaFizickoLice ml = new MusterijaFizickoLice();
                UgovorOIznajmljivanju u = s.Load<UgovorOIznajmljivanju>(56);
                // MessageBox.Show("Stanarina: " + u.Stanarina);
                ml.Ime = "Milos";
                ml.Prezime = "Stankovic";
                ml.JMBG = "1232319445234";
                ml.Telefon = "064123324";
                ml.Adresa = "Nis";
                ml.Tip = "f";
                ml.UgovoriOIznajmljivanju.Add(u);

                MusterijaPravnoLice pl = new MusterijaPravnoLice();
                Kupoprodajni k = s.Load<Kupoprodajni>(1);
                //MessageBox.Show("ID: " + k.ID.ToString());
                pl.Ime = "Nikola";
                pl.Prezime = "Nikolic";
                pl.JMBG = "1232319454234";
                pl.Pib = "52";
                pl.Telefon = "0621238975";
                pl.Adresa = "Katiceva";
                pl.KupoprodajniUgovori.Add(k);

                s.Save(ml);
                MessageBox.Show("Musterija fizicko lice je uspesno dodat u bazu");
                s.Save(pl);
                MessageBox.Show("Musterija pravno lice je uspesno dodat u bazu");

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MusterijaFizickoLice mf = s.Load<MusterijaFizickoLice>(1);

                foreach (UgovorOIznajmljivanju u in mf.UgovoriOIznajmljivanju)
                {
                    MessageBox.Show("Datum sklapanja " + u.Datum_Sklapanja + " ,datum isteka " + u.Datum_Isteka);
                }

                MusterijaPravnoLice pl = s.Load<MusterijaPravnoLice>(4);

                foreach (Kupoprodajni k in pl.KupoprodajniUgovori)
                {
                    MessageBox.Show("Datum transakcije " + k.Datum_Transakcije + " kupuje " + k.Kupuje.Ime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnPrikaziAgenta_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnine.Entiteti.Agent a = s.Load<Nekretnine.Entiteti.Agent>(61);//holden towne

                MessageBox.Show(a.Ime);

                s.Close();
                
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOne_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Agent agent = s.Load<Agent>(58);

                MessageBox.Show(agent.ProdavacUsluge.Ime);///nikola

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajUgovor_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Kupoprodajni k = new Entiteti.Kupoprodajni();
                Entiteti.Poslovnica p = s.Load<Entiteti.Poslovnica>(5);
                k.Datum_Transakcije = new DateTime(2019, 8, 8);
                k.ProdavacNekretnina = s.Load<Entiteti.ProdavacNekretnina>(7);
                k.Sklapa_ugovor = s.Load<Entiteti.ProdavacUslugeZaposleni>(1);
                k.Kupuje = s.Load<Entiteti.Musterija>(4);



                s.Save(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajUgovor_Click(object sender, EventArgs e)
        {
            try { 
            ///uradi
            ISession sesija = DataLayer.GetSession();
            //Nekretnina nova = sesija.Load<PoslovnaNekretnina>(4);
            //MessageBox.Show(nova.Ime_ulice);//Koch Haven

            Ugovor u = sesija.Load<Ugovor>(2);
            Kupoprodajni k = sesija.Load<Kupoprodajni>(4);
            UgovorOIznajmljivanju i = sesija.Load<UgovorOIznajmljivanju>(58);
            MessageBox.Show(u.Sklapa_ugovor.Ime+Environment.NewLine + //dusan?
                k.Datum_Transakcije.ToString()+ Environment.NewLine+
                i.Stanarina.ToString()); //nije mapirano, dodaj to xD
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToOneUgovori_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Ugovor ugovor = s.Load<Ugovor>(56);

                MessageBox.Show(ugovor.ProdavacNekretnina.ID.ToString());//7
                MessageBox.Show(ugovor.Sklapa_ugovor.Ime);//Nikola

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajKvart_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Nekretnine.Entiteti.Kvart k = s.Load<Nekretnine.Entiteti.Kvart>(4);

                MessageBox.Show(k.Gradska_zona);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajKvart_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.Kvart k = new Entiteti.Kvart();
                Entiteti.Poslovnica p = s.Load<Entiteti.Poslovnica>(5);
                k.Gradska_zona = "Test_zona";
                k.PripadaPoslovnici = p;


                s.Save(k);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnMantyToOneK_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Kvart k = s.Load<Kvart>(5);

                MessageBox.Show(k.PripadaPoslovnici.id.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajOpemu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema o = new Oprema();
                PoslovnaNekretnina n = s.Load<PoslovnaNekretnina>(8);

                o.oprema = "video bin,pametna tabla, obicna tabla";
                o.Nekretnina = n;

                s.Save(o);
                MessageBox.Show("Oprema je uspesno dodata");
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnManyToOneO_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema o = s.Load<Oprema>(53);

                MessageBox.Show("Oprema: " + o.oprema + " ,pripada nekretnini ciji je ID: " + o.Nekretnina.ID);


                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajPoslovnicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnine.Entiteti.Poslovnica poslovnica = s.Load<Nekretnine.Entiteti.Poslovnica>(61);

                MessageBox.Show(poslovnica.id.ToString());

                s.Close();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SefPoslovniceZaposleni sfp = new SefPoslovniceZaposleni();
                Entiteti.Poslovnica p = new Entiteti.Poslovnica()
                {
                    adresa = "Krfska 17",
                    radno_vreme = "08-16",
                    PripadaSefu = sfp
                };

                Kvart k = new Kvart()
                {
                    Gradska_zona="",
                    PripadaPoslovnici=p 
                    //Sef = false
                };

                ProdavacUslugeZaposleni puz = new ProdavacUslugeZaposleni()
                {
                    Strucna_sprema = "ekonomista",
                    PripadaPoslovnici = p
                };

                Agent agent = new Agent() {
                    Ime = "Petar",
                    Procenat = 5,
                    Datum_Angazovanja = DateTime.Now,
                    Telefon = "0668889555",
                    ProdavacUsluge = puz
                };

                p.Kvartovi.Add(k);
                p.ProdavciUsluge.Add(puz);
                puz.Agenti.Add(agent);

                s.Save(p);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVezaOneToMany_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici sa zadatim brojem
                Nekretnine.Entiteti.Poslovnica p = s.Load<Nekretnine.Entiteti.Poslovnica>(5);

                foreach (Kvart k in p.Kvartovi)
                {
                    MessageBox.Show(k.Gradska_zona);
                }
                foreach (ProdavacUslugeZaposleni puz in p.ProdavciUsluge) {
                    MessageBox.Show(puz.Ime + " " + puz.Pozicija);
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnManyToOnePoslovnica_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Poslovnica poslovnica = s.Load<Poslovnica>(4);

                MessageBox.Show(poslovnica.PripadaSefu.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajProdavca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacFizickoLice f = s.Load<ProdavacFizickoLice>(8);
                ProdavacPravnoLice p = s.Load<ProdavacPravnoLice>(7);
                MessageBox.Show(f.JMBG + Environment.NewLine + p.PIB);
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajProdavca_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacFizickoLice f = new ProdavacFizickoLice();
                f.JMBG = "1011997745045";
                s.Save(f);
                
                MessageBox.Show(f.JMBG + Environment.NewLine + f.ID.ToString());
              
                ProdavacPravnoLice p = new ProdavacPravnoLice();
                p.PIB = "182546";
                s.Save(p);
                MessageBox.Show(p.PIB + Environment.NewLine + p.ID.ToString());

                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVezaOneToManyProdavac_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacNekretnina p = s.Load<ProdavacNekretnina>(8);
                string poruka = "";
                string delimiter = Environment.NewLine;
                foreach (Nekretnina n in p.Nekretnine)
                {
                    poruka += n.Ime_ulice + delimiter;
                }
                MessageBox.Show(poruka);
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Nekretnine.Entiteti.Zaposleni z = s.Load<Nekretnine.Entiteti.Zaposleni>(6);

                MessageBox.Show(z.Ime);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                Entiteti.ProdavacUslugeZaposleni z = new Entiteti.ProdavacUslugeZaposleni();


                z.Ime = "Pera2";
                z.JMBG = "2185988567822";
                z.Datum_Zaposlenja = new DateTime(2019, 12, 3);
                z.Strucna_sprema = "gimnazija";
                z.PripadaPoslovnici = s.Load<Entiteti.Poslovnica>(4);
                Entiteti.Agent a = s.Load<Entiteti.Agent>(60);
                z.Agenti.Add(a);

                Entiteti.SefPoslovniceZaposleni sef = new Entiteti.SefPoslovniceZaposleni();
                sef.Datum_postavljanja = new DateTime(2019, 5, 5);
                sef.Datum_Zaposlenja = new DateTime(2018, 5, 5);
                sef.Ime = "Maka";
                sef.JMBG = "2155989557322";
                sef.PripadaPoslovnici = s.Load<Entiteti.Poslovnica>(4);



                s.Save(z);
                s.Save(sef);


                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnVezaManyToOneZaposlen_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SefPoslovniceZaposleni sef = s.Load<SefPoslovniceZaposleni>(6);

                MessageBox.Show(sef.Ime + " je sef poslovnice na adresi " + sef.PripadaPoslovnici.adresa);

                ProdavacUslugeZaposleni p = s.Load<ProdavacUslugeZaposleni>(2);

                MessageBox.Show(p.Ime + " radi kao " + p.Strucna_sprema + " u poslovnici na adresi " + p.PripadaPoslovnici.adresa);
                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOneToManyZaposleni_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SefPoslovniceZaposleni ef = s.Load<SefPoslovniceZaposleni>(57);
                ProdavacUslugeZaposleni p = s.Load<ProdavacUslugeZaposleni>(58);
                string poruka = "";
                foreach (Agent a in p.Agenti)
                {
                    poruka += a.Ime + Environment.NewLine;
                }
                MessageBox.Show(poruka);
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnDodajAgenta_Click(object sender, EventArgs e)
        {

            try
            {
                //ProdavacUslugeZaposleni novi = new ProdavacUslugeZaposleni();
                
                ISession s = DataLayer.GetSession();
                ProdavacUslugeZaposleni novi = s.Load<ProdavacUslugeZaposleni>(58);
                Entiteti.Agent agent = new Entiteti.Agent()
                {
                    Ime = "Petar",
                    Procenat = 5,
                    Datum_Angazovanja = DateTime.Now,
                    Telefon = "0668889555",
                    ProdavacUsluge=novi
                };

                s.Save(agent);

                s.Flush();
                s.Close();



            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void btnUcitajOpremu_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema o = s.Load<Oprema>(53);
                MessageBox.Show("Oprema: " + o.oprema);

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
