using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class KupoprodajniMapiranja : SubclassMap<Kupoprodajni>
    {
        public KupoprodajniMapiranja() {
            Table("KUPOPRODAJNI");
            Abstract();

            References(x => x.Kupuje).Column("ID_MUSTERIJE");
            Map(x => x.Datum_Transakcije, "DATUM_TRANSAKCIJE");
        }
    }
}
