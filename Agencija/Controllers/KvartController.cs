using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nekretnine;
/* Ovo je samo proba, logika bi mogla da se menje. Takodje njihova organizacija je sad malo drugacija: umesto jednog fajla DTO sa klasama
 * postoji folder DTO gde je svaka klasa u posebnom fajlu i umesto DTOManagera imaju DataProvider, tako da mozemo i tako da radimo.
 * Jedino sto mi se kod njih ne svidja je sto u negde u controleru rade direktno sa klasama entiteta (npr Get() vraca listu Vojnika kao entiteta)
 * 
   EE da kad radite pazite da ne vraca neku glupost kao sto meni ovaj get vraca listu kvartova cija je poslovnica -1 posto sam tamo tako pisala ^_^' 
   Pazite i kod upisa, updatea i brisanja (strani kljucevi)
   
   I sto se mene tice moze svako ono sto je radio prosli put, znaci ja cu kvart i zaposleni i sve sto ide uz to */
namespace Agencija.Controllers
{
    [Route("api/kvart")] //http://localhost:58906/api/kvart je url za postman ako je port aplikacije 58906
    public class KvartController : ApiController
    {
        public List<KvartPregled> Get()
        {
            return DTOManager.vratiKvartove();
        }

        public KvartPregled Get(int id)
        {
            return DTOManager.KvartCeo(id);
        }

        public string Post([FromBody]KvartPregled k)//novi kvart
        {
            if( DTOManager.IzmeneNovoKvart(-1, k.gradskaZona, k.PoslovnicaID) == -1 )
                return "doslo je do greske, proverite id poslovnice";//dodaj novi kvart?
            return "uspesno";
        }

        public string Put(int id, [FromBody]KvartPregled k) // izmeni stari
        {
           if( DTOManager.IzmeneNovoKvart(id, k.gradskaZona, k.PoslovnicaID) == -1 )//moze i povratna vrednost ako se tako zeli
                return "doslo je do greske, proverite id poslovnice";//dodaj novi kvart?
            return "uspesno";
        }

        [HttpDelete]//, Route("{id, idZ}")
        public string Delete(int idB, int idZ)
        {
            if(!DTOManager.ObrisiKvart(idB, idZ))
                return "doslo je do greske, proverite id kvarta kome se prepisuju nekretnine";//dodaj novi kvart?
            return "uspesno";
        }
    }
}
/* ne znam sto ali na pocetku nije hteo onaj postman da vidi nista osim get metoda pa sam pokusavala da mu razotkrijem ovu delete metodu.
 * Mislila sam da je do toga sto se parametri zovu isto ili da fali ovo [HttpDelete], ali onda je sve proradilo tako da taj dodatak ima
   samo Delete metoda. A i ako nesto u buducnosti ne radi mozda ovaj [Http] bude ipak potreban pa ga neka*/