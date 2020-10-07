using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;

namespace Agencija.Controllers
{
    [Route("api/sef")]
    public class SefController : ApiController
    {
        public List<SefPregled> Get()
        {
            return DTOManager.vratiSefove();
        }

        public string Post([FromBody]SefPregled sef) //noiv
        {
            if (DTOManager.IzmeneNovoSef(sef.JMBG, sef.DatumZaposlenja, sef.Ime, sef.DatumPostavljanja, sef.PoslovnicaID))
                return "Uspesno dodat sef";
            return "Doslo je od greske, proverite id poslovnice";
        }

        public string Put([FromBody]SefPregled sef) //azuriraj
        {
            if (DTOManager.IzmeneNovoSef(sef.JMBG, sef.DatumZaposlenja, sef.Ime, sef.DatumPostavljanja, sef.PoslovnicaID, sef.Id))
                return "Uspesno azuriran sef";
            return "Doslo je od greske, proverite id poslovnice i id sefa";
        }

        public void Delete(int id)
        {
            DTOManager.ObrisiSefa(id);
        }
    }
}
