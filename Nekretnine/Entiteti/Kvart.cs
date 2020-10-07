using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class Kvart
    {
        public virtual int ID { get; set; }
        public virtual String Gradska_zona { get; set; }
        public virtual Poslovnica PripadaPoslovnici { get; set; }
        public virtual IList<Nekretnina> Nekretnine { get; set; }

        public Kvart()
        {
            Nekretnine = new List<Nekretnina>();
        }
    }
}
