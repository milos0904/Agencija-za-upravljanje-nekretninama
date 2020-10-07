using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class MusterijaMapiranja : ClassMap<Musterija>
    {
        public MusterijaMapiranja()
        {
            Table("MUSTERIJA");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Telefon, "TELEFON");
            Map(x => x.Adresa, "ADRESA");
            

            HasMany(x => x.KupoprodajniUgovori).KeyColumn("ID_MUSTERIJE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
