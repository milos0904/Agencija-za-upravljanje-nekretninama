using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class SefPoslovniceZaposleniMapiranja : SubclassMap<SefPoslovniceZaposleni>
    {
        public SefPoslovniceZaposleniMapiranja()
        {
            DiscriminatorValue("s");
            Map(x => x.Datum_postavljanja).Column("DATUM_POSTAVLJANJA");
            // References(x => x.PripadaPoslovnici).Column("ID_Poslovnice").LazyLoad();
            HasOne(x => x.PripadaPoslovnici).Cascade.All().PropertyRef(x => x.PripadaSefu);//kad se brise sef poslovnica ostaje
            
        }
    }
}
