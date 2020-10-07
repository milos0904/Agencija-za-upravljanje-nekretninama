using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class ZaposleniMapiranja : ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja() {
            Table("ZAPOSLENI");

            DiscriminateSubClassesOnColumn("pozicija");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();
            Map(x => x.JMBG).Column("jmbg");
            Map(x => x.Datum_Zaposlenja).Column("datum_zaposlenja");
            Map(x => x.Ime).Column("ime");

            
        }

    }
}
