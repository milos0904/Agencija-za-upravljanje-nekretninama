using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class StambenaNekretninaMapiranja:SubclassMap<StambenaNekretnina>
    {
        public StambenaNekretninaMapiranja()
        {
            DiscriminatorValue("s");

            //svojstva
            Map(x => x.Broj_kupatila, "broj_kupatila");
        }

    }
}
