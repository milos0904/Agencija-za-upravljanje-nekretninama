using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class ProdavacUslugeZaposleni : Zaposleni
    {
        public virtual String Strucna_sprema { get; set; }
        public virtual Poslovnica PripadaPoslovnici { get; set; }

        public virtual IList<Agent> Agenti { get; set; }
        public virtual IList<Kupoprodajni> Kupoprodajnis { get; set; }
        public virtual IList<UgovorOIznajmljivanju> OIznajmljivanjus { get; set; }

        public ProdavacUslugeZaposleni()
        {
            Agenti = new List<Agent>();
            Kupoprodajnis = new List<Kupoprodajni>();
            OIznajmljivanjus = new List<UgovorOIznajmljivanju>();
        }
    }
}
