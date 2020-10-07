using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class UgovorOIznajmljivanju : Ugovor
    {
        public virtual MusterijaFizickoLice Zakupac { get; set; }
        public virtual Nekretnina Izdaje_se { get; set; }
        public virtual DateTime Datum_Isteka{ get; set; }
        public virtual DateTime Datum_Sklapanja { get; set; }
        public virtual int Stanarina { get; set; }
        
    }
}
