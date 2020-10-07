using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;

namespace Agencija.Controllers
{
    [Route("api/ProdavacPravnoLice")]
    public class ProdavciPravnoLiceController : ApiController
    {
        public List<ProdavacPravnoLicePregled> Get() {
            return DTOManager.vratiPProdavce();
        }
        public ProdavacPravnoLicePregled Get(int id) {
            return DTOManager.vratiPProdavca(id);
        }

        [HttpPost]
        public string Post([FromBody] ProdavacPravnoLicePregled p)
        {
            if (DTOManager.IzmeneProdavacPravno(-1, p.PIB))
                return "uspesno dodat";
            else return "nije dodat";
        }
        [HttpPut]
        public string Put([FromBody] ProdavacPravnoLicePregled p)
        {
            if (DTOManager.IzmeneProdavacPravno(p.ID, p.PIB))
                return "uspesno izmenjen";
            else return "nije izmenjen";
        }
    }
}
