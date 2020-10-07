using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class Oprema
    {
        public virtual PoslovnaNekretnina Nekretnina { get; set; }
        public virtual int ID { get; set; }
        public virtual string oprema { get; set; }
    }
}
