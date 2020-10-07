using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public abstract class Nekretnina //table per class hijer..
    {
        public virtual int ID { get; set; }
        public virtual string Ime_ulice { get; set; }
        public virtual int Broj { get; set; }
        public virtual int Sprat { get; set; }
        public virtual DateTime Datum_izgradnje { get; set; }
        public virtual int Cena { get; set; }
        public virtual string p_i{ get; set; } //za prodaju ili za izdavanje
        public virtual string Tip { get; set; }

        //kvart i prodavac reference
        public virtual Kvart Kvart { get; set; }
        public virtual ProdavacNekretnina Prodavac { get; set; }

        public virtual System.TimeSpan Starost()
        {
            System.TimeSpan rez = DateTime.Now - Datum_izgradnje;
            
            return rez;//.totalDays npr vraca koliko ukupno dana je izracunao
        }
    }
}
