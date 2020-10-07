using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class ProdavacUslugeZaposleniMapiranja : SubclassMap<ProdavacUslugeZaposleni>
    {
        public ProdavacUslugeZaposleniMapiranja() {
            DiscriminatorValue("p");
            Map(x => x.Strucna_sprema).Column("STRUCNA_SPREMA");
            References(x => x.PripadaPoslovnici).Column("ID_Poslovnice").LazyLoad();

            HasMany(x => x.Agenti).KeyColumn("ID_Prodavca").Cascade.All().Inverse();
            HasMany(x => x.Kupoprodajnis).KeyColumn("ID_ZAPOSLENOG").Cascade.SaveUpdate();
            HasMany(x => x.OIznajmljivanjus).KeyColumn("ID_ZAPOSLENOG").Cascade.SaveUpdate();
        }
    }
}
