using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;

namespace Agencija.Controllers
{

    [Route("api/Agent")]
    public class AgentController : ApiController
    {
        public List<AgentPregled> Get() {
            return DTOManager.prikaziAgent();
        }
        public AgentPregled Get(int id)
        {
            return DTOManager.vratiAgenta(id);
        }
        public string Post([FromBody] AgentPregled a)
        {
            if (DTOManager.dodajAgent( a.Ime, a.Procenat, a.Telefon,a.DatumAngazovanja,a.IdZaposlenog))
                return "dodat";
            else return "nije dodat";
        }
        public string Put([FromBody] AgentPregled a)
        {
            if (DTOManager.izmeniAgent(a.Id, a.Ime, a.Procenat, a.Telefon))
                return "izmenjen";
            else return "nije izmenjen";

        }
    }
}
