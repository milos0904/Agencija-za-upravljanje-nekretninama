using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;

namespace Agencija.Controllers
{
    [Route("api/zaposleni")]
    public class ZaposleniController : ApiController
    {
        public List<ZaposlenPregled> Get()
        {
            return DTOManager.vratiZaposlene();
        }

        public ZaposlenPregled Get(int id)
        {
            return DTOManager.GetZaposlenPregled(id);
        }

        public string Post([FromBody]ZaposlenPregled zaposlen)//novi zaposleni
        {
            if (DTOManager.IzmeneNovoZaposlen(new List<AgentPregled>(), zaposlen.JMBG, zaposlen.DatumZaposlenja, zaposlen.Ime, zaposlen.StrucnaSprema, zaposlen.PoslovnicaID))
                return "Uspesno dodat zaposleni";
            return "Doslo je do greske, proverite id poslovnice";
        }
        
        public string Put([FromBody]ZaposlenPregled zaposlen)//azuriranje zaposlenog
        {            
            if (DTOManager.IzmeneNovoZaposlen(new List<AgentPregled>(), zaposlen.JMBG, zaposlen.DatumZaposlenja, zaposlen.Ime, zaposlen.StrucnaSprema, zaposlen.PoslovnicaID, zaposlen.Id))
                return "Uspesno azuriran zaposleni";
            return "Doslo je do greske, proverite id poslovnice";
        }
        
        public void Delete(int id)
        {
            DTOManager.ObrisiZaposlenog(id);
        }
    }
}
