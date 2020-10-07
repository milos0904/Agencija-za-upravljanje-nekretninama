using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;

namespace Nekretnine
{
    public class PoslovnicaPregled
    {
        public int PoslovnicaID { get; set; }
        public string Adresa { get; set; }
        public string RadnoVreme { get; set; }
        public int ID_Sefa { get; set; }

        public PoslovnicaPregled(int id, string adr, string vreme,int id_sefa)
        {
            this.PoslovnicaID = id;
            this.Adresa = adr;
            this.RadnoVreme = vreme;
            this.ID_Sefa = id_sefa;
        }
    }

    public class NekretninaStambenaPregled
    {
        public int ID { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public int Sprat { get; set; }
        public DateTime Datum_izgradnje { get; set; }
        public int Cena { get; set; }
        public string Prodaja_Iznajmljivanje { get; set; }
        public int Broj_Kupatila { get; set; }
        public int ID_Kvarta { get; set; }
        public int ID_Prodavca { get; set; }
        public NekretninaStambenaPregled(int id, string u, int b, int s, DateTime d, int c, string p_i, int brK, int id_k, int id_p)
        {
            this.ID = id;
            this.Ulica = u;
            this.Broj = b;
            this.Sprat = s;
            this.Datum_izgradnje = d;
            this.Cena = c;
            this.Prodaja_Iznajmljivanje = p_i;
            this.Broj_Kupatila = brK;
            this.ID_Kvarta = id_k;
            this.ID_Prodavca = id_p;
        }
    }
    public class KvartPregled
    {
        public int KvartID { get; set; }
        public string gradskaZona { get; set; }
        public int PoslovnicaID { get; set; }

        public KvartPregled(int id, string zona, int idP = -1)
        {
            KvartID = id;
            gradskaZona = zona;
            PoslovnicaID = idP;
        }
    }
    public class NekretninaPoslovnaPregled
    {
        public int ID { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public int Sprat { get; set; }
        public DateTime Datum_izgradnje { get; set; }
        public int Cena { get; set; }
        public string Prodaja_Iznajmljivanje { get; set; }
        public string Sala { get; set; }
        public int ID_Kvarta { get; set; }
        public int ID_Prodavca { get; set; }
        public string Oprema { get; set; }


        public NekretninaPoslovnaPregled(int id,string u,int b,int s,DateTime d,int c,string p_i,string sala,int idk,int idP,string o)
        {
            this.ID = id;
            this.Ulica = u;
            this.Broj = b;
            this.Sprat = s;
            this.Datum_izgradnje = d;
            this.Cena = c;
            this.Prodaja_Iznajmljivanje = p_i;
            this.Sala = sala;
            this.ID_Kvarta = idk;
            this.ID_Prodavca = idP;
            this.Oprema = o;
        }

    }
    public class ZaposlenPregled
    {
        public int Id { get; set; }
        public string JMBG { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Ime { get; set; }
        public string StrucnaSprema { get; set; }
        public int PoslovnicaID { get; set; }
        public List<AgentPregled> MojiAgenti { get; set; }

        public ZaposlenPregled(int id, string jmbg, DateTime zaposlenje, string ime, string sprema, int idp=-1)
        {
            Id = id;
            JMBG = jmbg;
            DatumZaposlenja = zaposlenje;
            Ime = ime;
            StrucnaSprema = sprema;
            PoslovnicaID = idp;
            MojiAgenti = new List<AgentPregled>();
        }
    }

    public class SefPregled
    {
        public int Id { get; set; }
        public string JMBG { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string Ime { get; set; }
        public DateTime DatumPostavljanja { get; set; }
        public int PoslovnicaID { get; set; }

        public SefPregled(int id, string jmbg, DateTime zaposlenje, string ime, DateTime Datum, int idp = -1)
        {
            Id = id;
            JMBG = jmbg;
            DatumZaposlenja = zaposlenje;
            Ime = ime;
            DatumPostavljanja = Datum;
            PoslovnicaID = idp;
        }
        
    }

    public class ProdavacFizickoLicePregled
    {
        public int ID { get; set; }
        public string JMBG { get; set; }
 
        public ProdavacFizickoLicePregled(int i,string j)
        {
            ID = i;
            JMBG = j;
  
        }
    }

    public class ProdavacPravnoLicePregled
    {
        public int ID { get; set; }
        public string PIB { get; set; }
        public ProdavacPravnoLicePregled(int i, string j)
        {
            ID = i;
            PIB = j;
           
            
        }
    }


    public class AgentPregled
    {
        public string Ime { get; set; }
        public DateTime? DatumAngazovanja { get; set; }
        public int Procenat { get; set; }
        public string Telefon { get; set; }
        public int Id { get; set; }
        public int IdZaposlenog { get; set; }

        public AgentPregled(string ime, DateTime? angazovanje, int proc, string tel, int idz=-1, int id=-1)
        {
            this.Ime = ime;
            DatumAngazovanja = angazovanje;
            Procenat = proc;
            Telefon = tel;
            this.Id = id;
            IdZaposlenog = idz;
        }
    }
    public class MusterijaFizickoLicePregled
    {
        public int ID { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public MusterijaFizickoLicePregled(int id, string jmbg, string ime, string prezime, string adresa, string telefon) {
            ID = id;
            JMBG = jmbg;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Telefon = telefon;
        }
    }

    public class MusterijaPravnoLicePregled
    {
        public int ID { get; set; }
        public string PIB { get; set; }
        public string JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public MusterijaPravnoLicePregled(int id, string pib, string jmbg, string ime, string prezime, string adresa, string telefon) {
            ID = id;
            PIB = pib;
            JMBG = jmbg;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            Telefon = telefon;
        }
    }
     /*public class UgovorPregled
    {
        public int UgovorID { get; set; }
        public int ProdavacNekretninaID { get; set; }
        public int ProdavacUslugeZaposleniID { get; set; }

        public UgovorPregled(int id, int idPN = -1, int idPUZ = -1)
        {
            UgovorID = id;
            ProdavacNekretninaID = idPN;
            ProdavacUslugeZaposleniID = idPUZ;
        }
    }*/
   public class KupoprodajniPregled
    {
        public int ID { get; set; }
        public DateTime Datum_Transakcije { get; set; }
        public int MusterijaID { get; set; }
        public int ProdavacNekretninaID { get; set; }
        public int ProdavacUslugeZaposleniID { get; set; }

        public KupoprodajniPregled(int id, DateTime datum_transakcije, int idp1=-1, int idp2=-1, int idp3=-1) {
            ID = id;
            Datum_Transakcije = datum_transakcije;
            MusterijaID = idp1;
            ProdavacNekretninaID = idp2;
            ProdavacUslugeZaposleniID = idp3;
        }
    }
    
    public class UgovorOIznajmljivanjuPregled
    {
        public int ID { get; set; }
        public int ZakupacID { get; set; }
        public int Izdaje_se { get; set; }
        public DateTime Datum_Isteka { get; set; }
        public DateTime Datum_Sklapanja { get; set; }
        public int Stanarina { get; set; }

        public UgovorOIznajmljivanjuPregled(int id, DateTime datum_isteka, DateTime datum_sklapanja, int x, int idp1 = -1, int idp2 = -1)
        {
            ID = id;
            Datum_Isteka = datum_isteka;
            Datum_Sklapanja = datum_sklapanja;
            Stanarina = x;
            ZakupacID = idp1;
            Izdaje_se = idp2;
        }
    }
    public class OpremaPregled
    {
        public int ID { get; set; }
        public int ID_Nekretnine { get; set; }
        public string Oprema { get; set; }

        public OpremaPregled(int id,int idn,string o)
        {
            this.ID = id;
            this.ID_Nekretnine = idn;
            this.Oprema = o;
        }
    }
}
