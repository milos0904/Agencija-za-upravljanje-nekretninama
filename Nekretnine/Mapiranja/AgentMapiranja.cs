using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class AgentMapiranja : ClassMap<Agent>
    {
        public AgentMapiranja()
        {
            Table("AGENT");

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime, "IME");
            Map(x => x.Procenat, "PROCENAT");
            Map(x => x.Datum_Angazovanja, "DATUM_ANGAZOVANJA");
            Map(x => x.Telefon, "TELEFON");

            References(x => x.ProdavacUsluge).Column("ID_PRODAVCA");
        }
    }
}
/*
    
        

            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Gradksa_zona).Column("gradksa_zona");
            References(x => x.PripadaPoslovnici).Column("ID_Poslovnice").LazyLoad();
        }
    }
} */
