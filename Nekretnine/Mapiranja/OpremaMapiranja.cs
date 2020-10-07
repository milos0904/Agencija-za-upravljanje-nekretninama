using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class OpremaMapiranja:ClassMap<Oprema>
    {
        public OpremaMapiranja()
        {
            Table("OPREMA");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.oprema, "OPREMA");

            //mapiranje many to one veze sa many strane
            References(x => x.Nekretnina).Column("ID_NEKRETNINE").Cascade.All();//lazyLoad se podrazumeva
        }
    }
}
