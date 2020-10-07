using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class MusterijaFizickoLiceMapiranja : SubclassMap<MusterijaFizickoLice>
    {
        public MusterijaFizickoLiceMapiranja()
        {
            DiscriminatorValue("f"); //f- fizicko lice

            HasMany(x => x.UgovoriOIznajmljivanju).KeyColumn("ID_MUSTERIJE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
