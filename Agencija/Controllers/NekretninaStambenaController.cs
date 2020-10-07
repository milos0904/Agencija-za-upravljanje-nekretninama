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
    [Route("api/nekretninastambena")] //http://localhost:58906/api/nekretninastambena
    public class NekretninaStambenaController : ApiController
    {
        public List<NekretninaStambenaPregled> Get()
        {
            return DTOManager.UcitajStambene();
        }
        public NekretninaStambenaPregled Get(int id)
        {
            return DTOManager.UcitajStambenuNekretninu(id);
        }
        public string Post([FromBody]NekretninaStambenaPregled s)
        {
            DTOManager.DodajStambenuNekretninu(s.Ulica, s.Broj, s.Sprat, s.Datum_izgradnje, s.Cena, s.Broj_Kupatila, s.Prodaja_Iznajmljivanje, s.ID_Kvarta, s.ID_Prodavca);
            return "uspesno";
        }
        public string Put([FromBody]NekretninaStambenaPregled s)
        {
            if (DTOManager.UpdateStambenuNekretninu(s.ID, s.Ulica, s.Broj, s.Sprat, s.Datum_izgradnje, s.Cena, s.Prodaja_Iznajmljivanje, s.Broj_Kupatila, s.ID_Kvarta, s.ID_Prodavca))
                return "uspesno";
            else
                return "neuspesno";
        }
        [HttpDelete]
        public void Delete(int id)
        {
            DTOManager.ObrisiStambenuNekretninu(id);
        }
    }
}
