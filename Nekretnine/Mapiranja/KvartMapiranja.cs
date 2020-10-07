using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class KvartMapiranja : ClassMap<Kvart>
    {
        public KvartMapiranja() {
            Table("KVART");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Gradska_zona).Column("gradska_zona");
            References(x => x.PripadaPoslovnici).Column("ID_Poslovnice").LazyLoad();
            //HasMany(x => x.Oprema).KeyColumn("ID_NEKRETNINE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Nekretnine).KeyColumn("ID_Kvarta").LazyLoad().Cascade.SaveUpdate();//ostaju sirocici sa null :D
        }
    }
}
