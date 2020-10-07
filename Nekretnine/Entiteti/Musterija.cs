using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public abstract class Musterija //table per class
    {
        public virtual int ID { get; set; }
        public virtual string JMBG { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string Telefon { get; set; }
        public virtual string Tip { get; set; }
        public virtual IList<Kupoprodajni> KupoprodajniUgovori { get; set; }

        public Musterija()
        {
            this.KupoprodajniUgovori = new List<Kupoprodajni>();
        }
    }
}
