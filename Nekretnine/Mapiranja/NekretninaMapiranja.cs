using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Nekretnine.Entiteti;

namespace Nekretnine.Mapiranja
{
    class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {
            //tabela
            Table("NEKRETNINA");

            DiscriminateSubClassesOnColumn("tip");
            //kljuc
            Id(x => x.ID).Column("ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Ime_ulice, "ime_ulice");
            Map(x => x.Broj, "broj");
            Map(x => x.Sprat, "sprat");
            Map(x => x.Datum_izgradnje, "datum_izgradnje");
            Map(x => x.Cena, "cena");
            Map(x => x.p_i, "p_i");
           // Map(x => x.Tip, "tip");

            //reference na kvart u kome se nalazi i prodavca cija je nekretnina
            References(x => x.Kvart).Column("ID_Kvarta");
            References(x => x.Prodavac).Column("ID_Prodavca");
        }
    }
}
