using Nekretnine;
using Nekretnine.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Agencija.Controllers
{
    [Route("api/poslovnica")] //http://localhost:58906/api/poslovnica
    public class PoslovnicaController : ApiController
    {
        public List<PoslovnicaPregled> Get()
        {
            return DTOManager.vratiPoslovnice();
        }
        public PoslovnicaPregled Get(int id)
        {
           return DTOManager.vratiPoslovnicu(id);
        }
        public string Post([FromBody]PoslovnicaPregled p)
        {
            DTOManager.SacuvajPoslovnicu(p.Adresa, p.RadnoVreme, p.ID_Sefa);
            return "uspesno";
        }
        public string Put([FromBody]PoslovnicaPregled p)
        {
            if (DTOManager.UpdatePoslovnica(p.PoslovnicaID, p.Adresa, p.RadnoVreme, p.ID_Sefa))
                return "uspesno";
            else
                return "neuspesno";

        }
        public string Delete(int id)
        {
            DTOManager.ObrisiPoslovnicu(id);
            return "obrisano";
        }
    }
}
