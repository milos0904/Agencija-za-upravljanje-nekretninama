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
    [Route("api/nekretninaposlovna")] //http://localhost:58906/api/nekretninaposlovna
    public class NekretninaPoslovnaController : ApiController
    {
        public List<NekretninaPoslovnaPregled> Get()
        {
            return DTOManager.UcitajPoslovne();
        }
        public NekretninaPoslovnaPregled Get(int id)
        {
            return DTOManager.UcitajPoslovnuNekretninu(id);
        }
        public string Post([FromBody]NekretninaPoslovnaPregled s)
        {
            return DTOManager.DodajPoslovnuNekretninu(s.Ulica, s.Broj, s.Sprat, s.Datum_izgradnje, s.Cena,s.Prodaja_Iznajmljivanje,s.Sala, s.ID_Kvarta, s.ID_Prodavca);
        }
        public string Put([FromBody]NekretninaPoslovnaPregled s)
        {
            return DTOManager.UpdatePoslovnuNekretninu(s.ID, s.Ulica, s.Broj, s.Sprat, s.Datum_izgradnje, s.Cena, s.Prodaja_Iznajmljivanje, s.Sala, s.ID_Kvarta, s.ID_Prodavca);

        }
        [HttpDelete]
        public void Delete(int id)
        {
            DTOManager.ObrisiPoslovnuNekretninu(id);
        }
    }
}
