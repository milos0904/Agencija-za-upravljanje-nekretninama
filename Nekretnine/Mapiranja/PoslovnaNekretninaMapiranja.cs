using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class PoslovnaNekretninaMapiranja:SubclassMap<PoslovnaNekretnina>
    {
        public PoslovnaNekretninaMapiranja()
        {
            DiscriminatorValue("p");//poslovne nekretnine

            //dodatni atributi
            Map(x => x.Sala, "sala");

            //lista oprema
            HasMany(x => x.Oprema).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
