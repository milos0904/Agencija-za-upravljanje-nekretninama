using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class ProdavacNekretninaMapiranja : ClassMap<ProdavacNekretnina>
    {
        public ProdavacNekretninaMapiranja() {
            Table("PRODAVAC_NEKRETNINE");
            DiscriminateSubClassesOnColumn("TIP");
            Id(x => x.ID, "ID").Column("ID").GeneratedBy.TriggerIdentity();
            HasMany(x => x.Nekretnine).KeyColumn("ID_Prodavca").Cascade.All();
        }
    }
}