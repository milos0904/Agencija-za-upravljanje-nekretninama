using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class ProdavacFizickoLiceMapiranja : SubclassMap<ProdavacFizickoLice>
    {
        public ProdavacFizickoLiceMapiranja() {
            DiscriminatorValue("f");
            Map(x=> x.JMBG,"JMBG");
        }
    }
}
