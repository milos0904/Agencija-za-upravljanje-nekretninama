using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class SefPoslovniceZaposleni : Zaposleni
    {
        public virtual DateTime Datum_postavljanja { get; set; }
        public virtual Poslovnica PripadaPoslovnici { get; set; }
    }
}
