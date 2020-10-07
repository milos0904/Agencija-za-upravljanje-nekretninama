using Nekretnine.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine
{
    public class DTOManager
    {
        #region PROBA
        public static string Proba()
        {
            return "uspesna";
        }
        #endregion

        #region Poslovnica
        public static List<PoslovnicaPregled> vratiPoslovnice()
        {
            List<PoslovnicaPregled> poslovnice = new List<PoslovnicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Poslovnica> svePoslovnice = from p in s.Query<Poslovnica>() select p;

                foreach (Poslovnica nova in svePoslovnice)
                {
                    poslovnice.Add(new PoslovnicaPregled(nova.id, nova.adresa, nova.radno_vreme,nova.PripadaSefu.ID));
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return poslovnice;

        }
        public static PoslovnicaPregled vratiPoslovnicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Poslovnica p = s.Load<Poslovnica>(id);

                PoslovnicaPregled poslovnica = new PoslovnicaPregled(p.id, p.adresa, p.radno_vreme,p.PripadaSefu.ID);

                s.Close();
                return poslovnica;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public static int vratiID_Sefa(string jmbg)
        {
            int ID_Sefa = -1;
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<SefPoslovniceZaposleni> zaposleni = from z in s.Query<SefPoslovniceZaposleni>() where z.JMBG == jmbg select z;

                //glupo je ovako, nadji drugo resenje!            
                foreach (SefPoslovniceZaposleni n in zaposleni)
                {
                    ID_Sefa = n.ID;
                }

                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return ID_Sefa;
        }
        public static void SacuvajPoslovnicu(string adresa, string r, int id_sefa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SefPoslovniceZaposleni sef = s.Load<SefPoslovniceZaposleni>(id_sefa);

                Poslovnica p = new Poslovnica();
                p.adresa = adresa;
                p.radno_vreme = r;
                p.PripadaSefu = sef;

                s.Save(p);
                s.Flush();
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static SefPoslovniceZaposleni vratiSefa(int id)
        {
            SefPoslovniceZaposleni sef = null;
            try
            {
                ISession s = DataLayer.GetSession();
                sef = s.Load<SefPoslovniceZaposleni>(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sef;
        }
        public static Poslovnica UcitajPoslovnicu(int id)
        {
            Poslovnica p = null;
            try
            {
                ISession s = DataLayer.GetSession();

                p = s.Load<Poslovnica>(id);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return p;
        }
        public static bool UpdatePoslovnica(int id_poslovnice, string adresa, string vreme, int id_sefa)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SefPoslovniceZaposleni sef = s.Load<SefPoslovniceZaposleni>(id_sefa);

                Poslovnica p = s.Load<Poslovnica>(id_poslovnice);
                if (p.adresa == adresa && p.radno_vreme == vreme && p.PripadaSefu.JMBG == sef.JMBG)
                {

                    return false;
                }

                p.adresa = adresa;
                p.radno_vreme = vreme;
                p.PripadaSefu = sef;

                s.Update(p);
                s.Flush();

                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static void ObrisiPoslovnicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Poslovnica p = s.Load<Poslovnica>(id);

                s.Delete(p);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Nekretnine
        public static List<NekretninaPoslovnaPregled> UcitajPoslovne()
        {
            List<NekretninaPoslovnaPregled> nekeretnine = new List<NekretninaPoslovnaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<PoslovnaNekretnina> lista = from n in s.Query<PoslovnaNekretnina>() select n;

                IEnumerable<Oprema> opreme = from o in s.Query<Oprema>() select o;
                string oprema = "";
                foreach (PoslovnaNekretnina n in lista)
                {
                    oprema = "";
                    foreach (Oprema pom in opreme)
                    {
                        if (pom.Nekretnina.ID == n.ID)
                        {
                            oprema += pom.oprema + ", ";
                        }

                    }
                    nekeretnine.Add(new NekretninaPoslovnaPregled(n.ID, n.Ime_ulice, n.Broj, n.Sprat, n.Datum_izgradnje, n.Cena, n.p_i, n.Sala, n.Kvart.ID, n.Prodavac.ID, oprema));
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nekeretnine;
        }

        public static List<NekretninaStambenaPregled> UcitajStambene()
        {
            List<NekretninaStambenaPregled> nekeretnine = new List<NekretninaStambenaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<StambenaNekretnina> lista = from n in s.Query<StambenaNekretnina>() select n;

                foreach (StambenaNekretnina n in lista)
                {
                    nekeretnine.Add(new NekretninaStambenaPregled(n.ID, n.Ime_ulice, n.Broj, n.Sprat, n.Datum_izgradnje, n.Cena, n.p_i, n.Broj_kupatila, n.Kvart.ID, n.Prodavac.ID));
                }
                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return nekeretnine;
        }

        public static void DodajStambenuNekretninu(string ulica, int broj, int sprat, DateTime d, int cena, int brKup, string p_i, int idKvarta, int idProdavca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina sn = new StambenaNekretnina();
                sn.Ime_ulice = ulica;
                sn.Broj = broj;
                sn.Sprat = sprat;
                sn.Datum_izgradnje = d;
                sn.Cena = cena;
                sn.Broj_kupatila = brKup;
                sn.p_i = p_i;
                Kvart k = s.Load<Kvart>(idKvarta);
                sn.Kvart = k;
                ProdavacNekretnina p = s.Load<ProdavacNekretnina>(idProdavca);
                sn.Prodavac = p;

                s.Save(sn);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static bool Da_li_postoji_kvart(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kvart kv = (Kvart)s.Get("Kvart", id);
                if (kv != null)
                {
                    s.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool Da_li_postoji_prodavac(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdavacNekretnina p = (ProdavacNekretnina)s.Get("ProdavacNekretnina", id);
                if (p != null)
                {
                    s.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool Da_li_postoji_musterija(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Musterija p = (Musterija)s.Get("Musterija", id);
                if (p != null)
                {
                    s.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool Da_li_postoji_zaposleni(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ProdavacUslugeZaposleni p = (ProdavacUslugeZaposleni)s.Get("ProdavacUslugeZaposleni", id);
                if (p != null)
                {
                    s.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static NekretninaStambenaPregled UcitajStambenuNekretninu(int id)
        {
            NekretninaStambenaPregled n = null;
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina st = s.Load<StambenaNekretnina>(id);
                n = new NekretninaStambenaPregled(st.ID, st.Ime_ulice, st.Broj, st.Sprat, st.Datum_izgradnje, st.Cena, st.p_i, st.Broj_kupatila, st.Kvart.ID, st.Prodavac.ID);
               
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return n;
        }

        public static bool UpdateStambenuNekretninu(int id, string adresa, int broj, int sprat, DateTime datum, int cena, string p_i, int brK, int idKvarta, int idProdavca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina st = s.Load<StambenaNekretnina>(id);

                if (st.Ime_ulice == adresa && st.Broj == broj && st.Sprat == sprat && st.Datum_izgradnje == datum && st.Cena == cena && st.p_i == p_i && st.Broj_kupatila == brK && st.Kvart.ID == idKvarta && st.Prodavac.ID == idProdavca)
                {
                    return false;
                }
                st.Ime_ulice = adresa;
                st.Broj = broj;
                st.Sprat = sprat;
                st.Datum_izgradnje = datum;
                st.Cena = cena;
                st.p_i = p_i;
                st.Broj_kupatila = brK;
                st.Kvart.ID = idKvarta;
                st.Prodavac.ID = idProdavca;

                s.Update(st);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static void ObrisiStambenuNekretninu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina st = s.Load<StambenaNekretnina>(id);

                s.Delete(st);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string KupiStambenuNekretninu(int id, DateTime datum_tranksakcije, int idProdavca, int idMusterije, int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StambenaNekretnina n = s.Load<StambenaNekretnina>(id);
                if (n.p_i == "i")
                    return "Ne prodaje se";
                if (!Da_li_postoji_musterija(idMusterije))
                {
                    return "Ne postoji musterija";
                }
                if (!Da_li_postoji_prodavac(idProdavca))
                {
                    return "Ne postoji prodavac";
                }
                if (!Da_li_postoji_zaposleni(idZaposlenog))
                {
                    return "Ne postoji zaposleni";

                }
                Nekretnine.Entiteti.Kupoprodajni k = new Kupoprodajni();

                k.Datum_Transakcije = datum_tranksakcije;
                k.Kupuje = s.Load<Musterija>(idMusterije);
                k.ProdavacNekretnina = s.Load<ProdavacNekretnina>(idProdavca);
                k.Sklapa_ugovor = s.Load<ProdavacUslugeZaposleni>(idZaposlenog);

                s.Save(k);
                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Prodato";
        }
        public static string IznajmiStambenuNekretninu(int idNekretnine, int stanarina, DateTime pocetak, DateTime kraj, int idMusterije, int idProdavca, int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //trenutno nemam ideju kako drugacije da uradim, malo je glupo ovako
                IEnumerable<UgovorOIznajmljivanju> ugovori = from u in s.Query<UgovorOIznajmljivanju>() where u.Izdaje_se.ID == idNekretnine select u;

                if (ugovori.Count<UgovorOIznajmljivanju>() != 0)
                    return "iznajmljeno";
                if (!Da_li_postoji_musterija(idMusterije))
                {
                    return "ne postoji musterija";
                }
                if (!Da_li_postoji_prodavac(idProdavca))
                {
                    return "ne postoji prodavac";
                }
                if (!Da_li_postoji_zaposleni(idZaposlenog))
                {
                    return "ne postoji zaposleni";
                }

                UgovorOIznajmljivanju ugovor = new UgovorOIznajmljivanju();

                StambenaNekretnina sn = s.Load<StambenaNekretnina>(idNekretnine);

                if (sn.p_i == "p")
                    return "nekretnina se ne izdaje vec prodaje";

                ugovor.Izdaje_se = sn;
                ugovor.Stanarina = stanarina;
                ugovor.Datum_Sklapanja = pocetak;
                ugovor.Datum_Isteka = kraj;
                ugovor.Zakupac = s.Load<MusterijaFizickoLice>(idMusterije);
                ugovor.ProdavacNekretnina = s.Load<ProdavacNekretnina>(idProdavca);
                ugovor.Sklapa_ugovor = s.Load<ProdavacUslugeZaposleni>(idZaposlenog);

                s.Save(ugovor);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "uspesno";
        }
        public static string DodajPoslovnuNekretninu(string ulica, int broj, int sprat, DateTime datum, int cena, string p_i, string sala, int idKvarta, int idProdavca)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!Da_li_postoji_kvart(idKvarta))
                {
                    return "Ne postoji kvart";
                }
                if (!Da_li_postoji_prodavac(idProdavca))
                {
                    return "Ne postoji prodavac";
                }

                PoslovnaNekretnina pn = new PoslovnaNekretnina();

                pn.Ime_ulice = ulica;
                pn.Broj = broj;
                pn.Sprat = sprat;
                pn.Datum_izgradnje = datum;
                pn.Cena = cena;
                pn.p_i = p_i;
                pn.Sala = sala;
                pn.Kvart = s.Load<Kvart>(idKvarta);
                pn.Prodavac = s.Load<ProdavacNekretnina>(idProdavca);

                s.Save(pn);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "dodato";
        }

        public static string UpdatePoslovnuNekretninu(int idNekretnine, string ulica, int broj, int sprat, DateTime datum, int cena, string p_i, string sala, int idKvarta, int idProdavca)
        {

            try
            {
                ISession s = DataLayer.GetSession();

                if (!(Da_li_postoji_kvart(idKvarta)))
                {
                    return "ne postoji kvart";
                }
                if (!(Da_li_postoji_prodavac(idProdavca)))
                {
                    return "ne postoji prodavac";
                }

                PoslovnaNekretnina p = s.Load<PoslovnaNekretnina>(idNekretnine);

                p.Ime_ulice = ulica;
                p.Broj = broj;
                p.Sprat = sprat;
                p.Datum_izgradnje = datum;
                p.Cena = cena;
                p.p_i = p_i;
                p.Sala = sala;
                p.Kvart = s.Load<Kvart>(idKvarta);
                p.Prodavac = s.Load<ProdavacNekretnina>(idProdavca);

                s.Update(p);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "uspesno";
        }
        public static NekretninaPoslovnaPregled UcitajPoslovnuNekretninu(int id)
        {
            NekretninaPoslovnaPregled n = null;
            try
            {
                ISession s = DataLayer.GetSession();
                PoslovnaNekretnina p = s.Load<PoslovnaNekretnina>(id);

                IEnumerable<Oprema> opreme = from o in s.Query<Oprema>() select o;
                string oprema = "";
            
               foreach (Oprema pom in opreme)
               {
                  if (pom.Nekretnina.ID == p.ID)
                  {
                     oprema += pom.oprema + ", ";
                  }

               }
                
                n = new NekretninaPoslovnaPregled(p.ID, p.Ime_ulice, p.Broj, p.Sprat, p.Datum_izgradnje, p.Cena, p.p_i, p.Sala, p.Kvart.ID, p.Prodavac.ID,oprema);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return n;
        }
        public static string IznajmiPoslovnuNekretninu(int idNekretnine, int stanarina, DateTime pocetak, DateTime kraj, int idMusterije, int idProdavca, int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //trenutno nemam ideju kako drugacije da uradim, malo je glupo ovako
                IEnumerable<UgovorOIznajmljivanju> ugovori = from u in s.Query<UgovorOIznajmljivanju>() where u.Izdaje_se.ID == idNekretnine select u;

                if (ugovori.Count<UgovorOIznajmljivanju>() != 0)
                    return "iznajmljeno";
                if (!Da_li_postoji_musterija(idMusterije))
                {
                    return "ne postoji musterija";
                }
                if (!Da_li_postoji_prodavac(idProdavca))
                {
                    return "ne postoji prodavac";
                }
                if (!Da_li_postoji_zaposleni(idZaposlenog))
                {
                    return "ne postoji zaposleni";
                }

                UgovorOIznajmljivanju ugovor = new UgovorOIznajmljivanju();

                PoslovnaNekretnina sn = s.Load<PoslovnaNekretnina>(idNekretnine);

                if (sn.p_i == "p")
                    return "nekretnina se ne izdaje vec prodaje";

                ugovor.Izdaje_se = sn;
                ugovor.Stanarina = stanarina;
                ugovor.Datum_Sklapanja = pocetak;
                ugovor.Datum_Isteka = kraj;
                ugovor.Zakupac = s.Load<MusterijaFizickoLice>(idMusterije);
                ugovor.ProdavacNekretnina = s.Load<ProdavacNekretnina>(idProdavca);
                ugovor.Sklapa_ugovor = s.Load<ProdavacUslugeZaposleni>(idZaposlenog);

                s.Save(ugovor);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "uspesno";
        }

        #endregion
        
        #region Kvart       
        public static List<KvartPregled> vratiKvartove()
        {
            List<KvartPregled> rezultat = new List<KvartPregled>();
            try
            { 
                ISession s = DataLayer.GetSession();
                IEnumerable<Kvart> sviKvartovi = from k in s.Query<Kvart>() select k;

                foreach(Kvart k in sviKvartovi)
                {
                    rezultat.Add(new KvartPregled(k.ID, k.Gradska_zona, k.PripadaPoslovnici.id));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }

        public static KvartPregled KvartCeo(int id)
        {
            KvartPregled rez = null;

            try
            {
                ISession s = DataLayer.GetSession();
                Kvart k = s.Load<Kvart>(id);
                rez = new KvartPregled(k.ID, k.Gradska_zona, k.PripadaPoslovnici.id);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rez;
        }

        public static int IzmeneNovoKvart(int id, string zona, int idP)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart k;
                if (id == -1)
                {  //novo
                    k = new Kvart();
                }
                else //izmenjeno xD
                {
                    k = s.Load<Kvart>(id);
                }

                k.Gradska_zona = zona;
                Poslovnica p = s.Load<Poslovnica>(idP);
                k.PripadaPoslovnici = p;

                if (id == -1)
                {
                    s.Save(k);
                }
                else
                {
                    s.Update(k);
                    s.Flush();
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1; //ako obj ne postoji kod s.lodar Poslovnica
                // ili guglaj kakve ex baca ovaj isession.load pa moze poseban catch blok :)
            }
            return 0;
        }

        public static bool ObrisiKvart(int id, int idZamene)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart k = s.Load<Kvart>(id);
                Kvart zamena = s.Load<Kvart>(idZamene);
                zamena.Nekretnine = k.Nekretnine;
                foreach(Nekretnina n in zamena.Nekretnine)
                {
                    n.Kvart = zamena;
                }

                s.Update(zamena);
                s.Delete(k);

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region Zaposleni
        public static List<ZaposlenPregled> vratiZaposlene()
        {
            List<ZaposlenPregled> rezultat = new List<ZaposlenPregled>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProdavacUslugeZaposleni> sviZaposleni = from z in s.Query<ProdavacUslugeZaposleni>() select z;

                foreach(ProdavacUslugeZaposleni z in sviZaposleni)
                {
                    rezultat.Add(new ZaposlenPregled(z.ID, z.JMBG, z.Datum_Zaposlenja, z.Ime, z.Strucna_sprema, z.PripadaPoslovnici.id));
                }
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rezultat;
        }

        public static ZaposlenPregled GetZaposlenPregled(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                
                ProdavacUslugeZaposleni zaposleni = s.Load<ProdavacUslugeZaposleni>(id);
                ZaposlenPregled rez = new ZaposlenPregled(zaposleni.ID, zaposleni.JMBG, zaposleni.Datum_Zaposlenja, zaposleni.Ime, zaposleni.Strucna_sprema, zaposleni.PripadaPoslovnici.id);
                
                foreach(Agent a in zaposleni.Agenti)
                {
                    rez.MojiAgenti.Add(new AgentPregled(a.Ime, a.Datum_Angazovanja, a.Procenat, a.Telefon, zaposleni.ID, a.ID));
                }

                return rez;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static List<SefPregled> vratiSefove()
        {
            List<SefPregled> rezultat = new List<SefPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<SefPoslovniceZaposleni> sviSefovi = from sef in s.Query<SefPoslovniceZaposleni>() select sef;

                foreach(SefPoslovniceZaposleni sef in sviSefovi)
                {
                    if(sef.PripadaPoslovnici!=null)
                        rezultat.Add(new SefPregled(sef.ID, sef.JMBG, sef.Datum_Zaposlenja, sef.Ime, sef.Datum_postavljanja, sef.PripadaPoslovnici.id));
                    else
                        rezultat.Add(new SefPregled(sef.ID, sef.JMBG, sef.Datum_Zaposlenja, sef.Ime, sef.Datum_postavljanja));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }

        public static bool IzmeneNovoZaposlen(List<AgentPregled> agenti, string JMBG, DateTime zaposlenje, string ime, string sprema, int idP, int id=-1)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacUslugeZaposleni radni;
                if (id == -1)
                {
                    radni = new ProdavacUslugeZaposleni();
                    radni.Agenti = new List<Entiteti.Agent>();
                }
                else
                    radni = s.Load<ProdavacUslugeZaposleni>(id);

                foreach(AgentPregled ag in agenti)
                {
                    Agent novi = new Agent
                    {
                        Ime = ag.Ime,
                        Procenat = ag.Procenat,
                        Telefon = ag.Telefon,
                        Datum_Angazovanja = ag.DatumAngazovanja,
                        ProdavacUsluge = radni
                    };

                    radni.Agenti.Add(novi);
                }

                radni.PripadaPoslovnici = s.Load<Poslovnica>(idP);
                radni.JMBG = JMBG;
                radni.Datum_Zaposlenja = zaposlenje;
                radni.Ime = ime;
                radni.Strucna_sprema = sprema;

                if (id == -1)
                    s.Save(radni);
                else
                {
                    s.Update(radni);
                    s.Flush();
                }
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static bool IzmeneNovoSef(string JMBG, DateTime zaposlenje, string ime, DateTime postavljen, int idP, int id = -1)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                SefPoslovniceZaposleni sef;
                if (id == -1)
                    sef = new SefPoslovniceZaposleni();
                else
                    sef = s.Load<SefPoslovniceZaposleni>(id);

                sef.JMBG = JMBG;
                sef.Datum_Zaposlenja = zaposlenje;
                sef.Ime = ime;
                sef.Datum_postavljanja = postavljen;
                if (id == -1)
                {
                    s.Save(sef);
                }
                sef.PripadaPoslovnici = s.Load<Poslovnica>(idP);
                sef.PripadaPoslovnici.PripadaSefu = sef;
                //kao nesto dodaj da se sacuva sef pa da se azurira poslovnica zbog stranog kljuca mada ako ima cascade all ne bi trebalo da je ovo potrebno xD
                
                    s.Update(sef);
                    s.Flush();

                s.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        public static void ObrisiZaposlenog(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacUslugeZaposleni brisi = s.Load<ProdavacUslugeZaposleni>(id);
                s.Delete(brisi);

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public  static void ObrisiSefa(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                SefPoslovniceZaposleni sef = s.Load<SefPoslovniceZaposleni>(id);
                // sef.Pozicija = "p"; da li moze ovako da se unazadi? xd
                if (sef.PripadaPoslovnici != null)
                {
                    sef.PripadaPoslovnici.PripadaSefu = null;
                    sef.PripadaPoslovnici = null;
                }

                s.Delete(sef);
                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Kupoprodajni
        public static List<KupoprodajniPregled> vratiKupoprodajneUgovore()
        {
            List<KupoprodajniPregled> rezultat = new List<KupoprodajniPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kupoprodajni> sviUgovori = from k in s.Query<Kupoprodajni>() select k;

                foreach (Kupoprodajni k in sviUgovori)
                {
                    rezultat.Add(new KupoprodajniPregled(k.ID, k.Datum_Transakcije));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }

        #endregion

        #region UgovorOIznajmljivanju
        public static List<UgovorOIznajmljivanjuPregled> vratiUgovoreOIznajmljivanju()
        {
            List<UgovorOIznajmljivanjuPregled> rezultat = new List<UgovorOIznajmljivanjuPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<UgovorOIznajmljivanju> sviUgovori = from k in s.Query<UgovorOIznajmljivanju>() select k;

                foreach (UgovorOIznajmljivanju k in sviUgovori)
                {
                    rezultat.Add(new UgovorOIznajmljivanjuPregled(k.ID, k.Datum_Isteka, k.Datum_Sklapanja, k.Stanarina));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        #endregion

        #region Musterija
        public static List<MusterijaFizickoLicePregled> vratiFMusterije() {
            List<MusterijaFizickoLicePregled> rezultat = new List<MusterijaFizickoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<MusterijaFizickoLice> sveFMusterije = from k in s.Query<MusterijaFizickoLice>() select k;

                foreach (MusterijaFizickoLice k in sveFMusterije)
                {
                    rezultat.Add(new MusterijaFizickoLicePregled(k.ID, k.JMBG, k.Ime, k.Prezime, k.Adresa, k.Telefon));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        public static List<MusterijaPravnoLicePregled> vratiPMusterije()
        {
            List<MusterijaPravnoLicePregled> rezultat = new List<MusterijaPravnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<MusterijaPravnoLice> svePMusterije = from k in s.Query<MusterijaPravnoLice>() select k;

                foreach (MusterijaPravnoLice k in svePMusterije)
                {
                    rezultat.Add(new MusterijaPravnoLicePregled(k.ID, k.Pib, k.JMBG, k.Ime, k.Prezime, k.Adresa, k.Telefon));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        public static void obrisiMusterijuFizicko(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                MusterijaFizickoLice k = s.Load<MusterijaFizickoLice>(id);
                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void obrisiMusterijuPravno(int id)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                MusterijaPravnoLice k = s.Load<MusterijaPravnoLice>(id);
                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static bool IzmeneMusterijaPravno(int id, string PIB, string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                MusterijaPravnoLice radni;
                if (id == -1)
                {
                    radni = new MusterijaPravnoLice();
                }
                else
                    radni = s.Load<MusterijaPravnoLice>(id);

                radni.Pib = PIB;
                radni.JMBG = jmbg;
                radni.Ime = ime;
                radni.Prezime = prezime;
                radni.Adresa = adresa;
                radni.Telefon = telefon;

                if (id == -1)
                    s.Save(radni);
                else
                {
                    s.Update(radni);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool IzmeneMusterijaFizicko(int id, string jmbg, string ime, string prezime, string adresa, string telefon)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                MusterijaFizickoLice radni;
                if (id == -1)
                {
                    radni = new MusterijaFizickoLice();
                }
                else
                    radni = s.Load<MusterijaFizickoLice>(id);

                radni.JMBG = jmbg;
                radni.Ime = ime;
                radni.Prezime = prezime;
                radni.Adresa = adresa;
                radni.Telefon = telefon;

                if (id == -1)
                    s.Save(radni);
                else
                {
                    s.Update(radni);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region Prodavac
        public static List<ProdavacFizickoLicePregled> vratiFProdavce() {
            List<ProdavacFizickoLicePregled> rezultat = new List<ProdavacFizickoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProdavacFizickoLice> sviFProdavci = from k in s.Query<ProdavacFizickoLice>() select k;

                foreach (ProdavacFizickoLice k in sviFProdavci)
                {
                    rezultat.Add(new ProdavacFizickoLicePregled(k.ID, k.JMBG));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        public static List<ProdavacPravnoLicePregled> vratiPProdavce()
        {
            List<ProdavacPravnoLicePregled> rezultat = new List<ProdavacPravnoLicePregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<ProdavacPravnoLice> sviFProdavci = from k in s.Query<ProdavacPravnoLice>() select k;

                foreach (ProdavacPravnoLice k in sviFProdavci)
                {
                    rezultat.Add(new ProdavacPravnoLicePregled(k.ID, k.PIB));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        public static ProdavacFizickoLicePregled vratiFProdavca(int id)
        {
            ProdavacFizickoLicePregled rez = null;

            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacFizickoLice k = s.Load<ProdavacFizickoLice>(id);
                rez = new ProdavacFizickoLicePregled(k.ID, k.JMBG);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rez;
        }
        public static ProdavacPravnoLicePregled vratiPProdavca(int id) {
            ProdavacPravnoLicePregled rez = null;

            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacPravnoLice k = s.Load<ProdavacPravnoLice>(id);
                rez = new ProdavacPravnoLicePregled(k.ID, k.PIB);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rez;
        }

        public static bool IzmeneProdavacPravno(int id,string PIB)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacPravnoLice radni;
                if (id == -1)
                {
                    radni = new ProdavacPravnoLice();
                }
                else
                    radni = s.Load<ProdavacPravnoLice>(id);
                
                radni.PIB = PIB;
             
                if (id == -1)
                    s.Save(radni);
                else
                {
                    s.Update(radni);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        public static bool IzmeneProdavacFizicko(int id, string JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                ProdavacFizickoLice radni;
                if (id == -1)
                {
                    radni = new ProdavacFizickoLice();
                }
                else
                    radni = s.Load<ProdavacFizickoLice>(id);

                radni.JMBG = JMBG;

                if (id == -1)
                    s.Save(radni);
                else
                {
                    s.Update(radni);
                    s.Flush();
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        #endregion

        #region Agent
        public static List<AgentPregled> prikaziAgent() {
            List<AgentPregled> rezultat = new List<AgentPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Agent> sviAgenti = from k in s.Query<Agent>() select k;

                foreach (Agent k in sviAgenti)
                {
                    rezultat.Add(new AgentPregled(k.Ime,k.Datum_Angazovanja,k.Procenat,k.Telefon,k.ProdavacUsluge.ID,k.ID));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rezultat;
        }
        public static AgentPregled vratiAgenta(int id) {
            AgentPregled rez = null;

            try
            {
                ISession s = DataLayer.GetSession();
                Agent k = s.Load<Agent>(id);
                rez = new AgentPregled(k.Ime, k.Datum_Angazovanja, k.Procenat, k.Telefon,k.ProdavacUsluge.ID,k.ID);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return rez;
        }
        public static bool dodajAgent(string ime, int proc, string tel, DateTime? date,int idZap) {
            try
            {
                ISession s = DataLayer.GetSession();
                Agent radni;
                ProdavacUslugeZaposleni prodavac = s.Get<ProdavacUslugeZaposleni>(idZap);
                if (prodavac == null)
                    return false;
                radni = new Agent();
                radni.Ime = ime;
                radni.Procenat = proc;
                radni.Telefon = tel;
                radni.Datum_Angazovanja = date;
                radni.ProdavacUsluge = prodavac;
                s.Save(radni);
                s.Close();
                     }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;


            }
            return true;
        }
        public static bool izmeniAgent(int id,string ime,int proc,string tel)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agent radni;
                
                radni = s.Load<Agent>(id);

                radni.Ime = ime;
                radni.Procenat = proc;
                radni.Telefon = tel;

                    s.Update(radni);
                    s.Flush();
                 
              
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                
             
            }
            return true;
        }
        #endregion

        #region Oprema
        public static bool DodajOpremu(int idNekretnine, string oprema)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslovnaNekretnina pn = s.Load<PoslovnaNekretnina>(idNekretnine);

                Oprema o = new Oprema();

                o.Nekretnina = pn;
                o.oprema = oprema;

                s.Save(o);
                s.Flush();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static List<Oprema> VratiOpreme(int idNekretnine)
        {
            List<Oprema> sveOpreme = new List<Oprema>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oprema> opreme = from o in s.Query<Oprema>() where o.Nekretnina.ID == idNekretnine select o;

                foreach (Oprema o in opreme)
                {
                    sveOpreme.Add(o);
                }

              s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sveOpreme;
        }
        public static List<OpremaPregled> VratiSvuOpremu()
        {
            List<OpremaPregled> sve = new List<OpremaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oprema> opreme = from o in s.Query<Oprema>() select o;

                foreach (Oprema o in opreme)
                {
                    sve.Add(new OpremaPregled(o.ID,o.Nekretnina.ID,o.oprema));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return sve;
        }
        public static bool UpdateOprema(int id_opreme, string nova_oprema)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema o =(Oprema) s.Get("Oprema",id_opreme);
                if (o == null)
                    return false;
                o.oprema = nova_oprema;

                s.Update(o);
                s.Flush();

                s.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static Oprema vratiOpremu(int id)
        {
            Oprema o = new Oprema();

            try
            {
                ISession s = DataLayer.GetSession();

                o = (Oprema)s.Get("Oprema", id);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return o;
        }
        public static void ObrisiOpremu(int idOpreme)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema o = s.Load<Oprema>(idOpreme);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ObrisiPoslovnuNekretninu(int idNekretnine)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslovnaNekretnina pn = s.Load<PoslovnaNekretnina>(idNekretnine);

                s.Delete(pn);
                s.Flush();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static string KupiPoslovnuNekretninu(int id, DateTime datum_tranksakcije, int idProdavca, int idMusterije, int idZaposlenog)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslovnaNekretnina n = s.Load<PoslovnaNekretnina>(id);
                if (n.p_i == "i")
                    return "Ne prodaje se";

                if ((!Da_li_postoji_musterija(idMusterije)))
                {
                    return "Ne postoji musterija";
                }
                if ((!Da_li_postoji_prodavac(idProdavca)))
                {
                    return "Ne postoji prodavac";
                }
                if((!Da_li_postoji_zaposleni(idZaposlenog)))
                {
                    return "Ne postoji zaposleni";
                }

                Nekretnine.Entiteti.Kupoprodajni k = new Kupoprodajni();
                k.Datum_Transakcije = datum_tranksakcije;
                k.Kupuje = s.Load<Musterija>(idMusterije);
                k.ProdavacNekretnina = s.Load<ProdavacNekretnina>(idProdavca);
                k.Sklapa_ugovor = s.Load<ProdavacUslugeZaposleni>(idZaposlenog);

                s.Save(k);
                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "Prodato";
        }
        #endregion

    }

}
