using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class MusterijaPravnoLiceMapiranja : SubclassMap<MusterijaPravnoLice>
    {
        public MusterijaPravnoLiceMapiranja()
        {
            DiscriminatorValue("p"); // p- pravno lice

            Map(x => x.Pib, "PIB");


        }
    }
}
