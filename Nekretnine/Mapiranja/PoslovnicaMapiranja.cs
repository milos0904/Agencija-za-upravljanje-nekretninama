using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class PoslovnicaMapiranja : ClassMap<Poslovnica>
    {
        public PoslovnicaMapiranja()
        {
            Table("POSLOVNICA");

            Id(x => x.id).Column("id").GeneratedBy.TriggerIdentity();
            Map(x => x.radno_vreme).Column("radno_vreme");
            Map(x => x.adresa).Column("adresa");

            References(x => x.PripadaSefu).Column("id_sefa").Unique().Cascade.All();//kad se brise poslovnica brise se i sef? xD

            HasMany(x => x.Kvartovi).KeyColumn("ID_Poslovnice").Cascade.All().Inverse().ForeignKeyCascadeOnDelete();
            HasMany(x => x.ProdavciUsluge).KeyColumn("ID_POSLOVNICE").Cascade.All().Inverse().ForeignKeyCascadeOnDelete();
        }
    }

}
