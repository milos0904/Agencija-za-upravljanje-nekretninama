using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;

namespace Agencija.Controllers
{
    [Route("api/ProdavacFizickoLice")]
    public class ProdavciFizickoLiceController : ApiController
    {

        public List<ProdavacFizickoLicePregled> Get()
        {
            return DTOManager.vratiFProdavce();
        }
        public ProdavacFizickoLicePregled Get(int id)
        {
            return DTOManager.vratiFProdavca(id);
        }

        [HttpPost]
        public string Post([FromBody] ProdavacFizickoLicePregled p)
        {
            if (DTOManager.IzmeneProdavacFizicko(-1, p.JMBG))
                return "uspesno dodat";
            else return "nije dodat";
        }
        [HttpPut]
        public string Put([FromBody] ProdavacFizickoLicePregled p)
        {
            if (DTOManager.IzmeneProdavacFizicko(p.ID, p.JMBG))
                return "uspesno izmenjen";
            else return "nije izmenjen";
        }
    }
}

