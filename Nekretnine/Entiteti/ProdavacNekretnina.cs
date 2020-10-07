using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public abstract class ProdavacNekretnina //table per class
    {
        public virtual int ID { get; set; }
        public virtual string Tip { get; set; }
        public virtual IList<Nekretnina> Nekretnine { get; set; }

        public ProdavacNekretnina()
        {
            Nekretnine = new List<Nekretnina>();
        }
        
    }
}
