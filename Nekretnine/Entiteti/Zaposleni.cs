using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public abstract class Zaposleni //koristimo table per class 
    {
        public virtual int ID { get; set; }
        public virtual string JMBG { get; set; }
        public virtual DateTime Datum_Zaposlenja { get; set; }
        public virtual string  Ime { get;  set; }
        public virtual string Pozicija { get; set; }


        public Zaposleni()
        {
            
        }

    }
}
