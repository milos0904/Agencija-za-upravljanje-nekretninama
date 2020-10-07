using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public abstract class Ugovor // table per concrete class
    {
        public virtual int ID { get; set; }
        public virtual ProdavacNekretnina ProdavacNekretnina { get; set; }
        public virtual ProdavacUslugeZaposleni Sklapa_ugovor { get; set; }
    }
}
