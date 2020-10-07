using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class UgovorMapiranja : ClassMap<Ugovor>
    {
        /*References(x => x.PripadaProdavnici)
.Column("BROJP")
*/
        public UgovorMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.ID, "ID").Column("ID").GeneratedBy.TriggerIdentity();
            References(x => x.Sklapa_ugovor).Column("ID_ZAPOSLENOG");
            References(x => x.ProdavacNekretnina).Column("ID_PRODAVCA");
        }
    }
}
