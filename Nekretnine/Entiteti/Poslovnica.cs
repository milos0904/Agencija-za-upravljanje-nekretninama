using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class Poslovnica////id,adresa,radno_vreme,id_sefa, lista kvartova i lista prodavaca usluge
    {
        public virtual int id { get; set; }
        public virtual string adresa { get; set; }
        public virtual string radno_vreme { get; set; }
        public virtual SefPoslovniceZaposleni PripadaSefu { get; set; }
        public virtual IList<Kvart> Kvartovi { get; set; }
        public virtual IList<ProdavacUslugeZaposleni> ProdavciUsluge { get; set; }

        public Poslovnica()
        {
            Kvartovi = new List<Kvart>();
            ProdavciUsluge = new List<ProdavacUslugeZaposleni>();
        }
        
    }
}
