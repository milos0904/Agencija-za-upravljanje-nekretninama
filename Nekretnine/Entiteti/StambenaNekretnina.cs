using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class StambenaNekretnina : Nekretnina
    {
        public virtual int Broj_kupatila { get; set; }
    }
}
