using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class ProdavacPravnoLiceMapiranja : SubclassMap<ProdavacPravnoLice>
    {

        public ProdavacPravnoLiceMapiranja()
        {
            DiscriminatorValue("p");
            Map(x => x.PIB, "PIB");
        }
    }
}
