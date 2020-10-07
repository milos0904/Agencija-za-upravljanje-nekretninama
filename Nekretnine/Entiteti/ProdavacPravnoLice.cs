using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class ProdavacPravnoLice : ProdavacNekretnina
    {
        public virtual string PIB { get; set; }
      
    }
}
