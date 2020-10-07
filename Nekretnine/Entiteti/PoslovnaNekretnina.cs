using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class PoslovnaNekretnina : Nekretnina
    {
        public virtual string Sala { get; set; }
        public virtual IList<Oprema> Oprema { get; set; }

        public PoslovnaNekretnina()
        {
            Oprema = new List<Oprema>();
        }
    }
}
