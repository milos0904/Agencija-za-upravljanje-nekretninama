using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;
using Nekretnine.Entiteti;

namespace Agencija.Controllers
{
    [Route("api/oprema")] //http://localhost:58906/api/oprema
    public class OpremaController : ApiController
    {
        public List<OpremaPregled> Get()
        {
            return DTOManager.VratiSvuOpremu();
        }
        public string Post([FromBody]OpremaPregled o)
        {
            if (DTOManager.DodajOpremu(o.ID_Nekretnine, o.Oprema))
                return "dodato";
            else
                return "neuspesno";
        }
        public string Put([FromBody]OpremaPregled o)
        {
            if (DTOManager.UpdateOprema(o.ID, o.Oprema))
                return "uspesno";
            else
                return "neuspesno";
        }
        [HttpDelete]
        public void Delete(int id)
        {
            DTOManager.ObrisiOpremu(id);
        }
    }
}
