using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nekretnine.Entiteti;
using FluentNHibernate.Mapping;

namespace Nekretnine.Mapiranja
{
    class UgovorOIznajmljivanjuMapiranja : SubclassMap<UgovorOIznajmljivanju>
    {
        public UgovorOIznajmljivanjuMapiranja() {
            Table("UGOVOR_O_IZNAJMLJIVANJU");
            Abstract();

            References(x => x.Zakupac).Column("ID_MUSTERIJE");
            References(x => x.Izdaje_se).Column("ID_NEKRETNINE");
            Map(x => x.Datum_Isteka, "DATUM_ISTEKA");
            Map(x => x.Datum_Sklapanja, "DATUM_SKLAPANJA");
            Map(x => x.Stanarina, "STANARINA");
        }
    }
}
