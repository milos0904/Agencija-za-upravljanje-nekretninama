using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nekretnine.Entiteti
{
    public class MusterijaFizickoLice : Musterija
    {
        public virtual IList<UgovorOIznajmljivanju> UgovoriOIznajmljivanju { get; set; }


        public MusterijaFizickoLice() : base()
        {
            this.UgovoriOIznajmljivanju = new List<UgovorOIznajmljivanju>();
        }
    }
}
