using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class Kupoprodajni : Ugovor
    {
        public virtual DateTime Datum_Transakcije { get; set; }
        public virtual Musterija Kupuje { get; set; }
        


    }
}
