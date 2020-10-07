using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class Agent
    {
        public virtual int ID { get; set; }
        public virtual string Ime { get; set; }
        public virtual int Procenat { get; set; }
        public virtual DateTime? Datum_Angazovanja { get; set; }
        public virtual string Telefon { get; set; }
        public virtual ProdavacUslugeZaposleni ProdavacUsluge { get; set; }
    }
}
