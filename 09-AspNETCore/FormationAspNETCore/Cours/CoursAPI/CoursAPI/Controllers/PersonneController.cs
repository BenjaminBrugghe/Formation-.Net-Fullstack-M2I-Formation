using CoursAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoursAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonneController : ControllerBase
    {
        // GET: api/<PersonneController>
        [HttpGet]
        public IEnumerable<Personne> Get()
        {
            List<Personne> _personneList = new List<Personne>()
            {
                new Personne() { Nom="Brugghe", Prenom="Benjamin", Email="Email@gmail.com", Telephone="0607080910" },
                new Personne() { Nom="Mister", Prenom="Bean", Email="Email@gmail.com", Telephone="0607080910" },
                new Personne() { Nom="Monsieur", Prenom="Anderson", Email="Email@gmail.com", Telephone="0607080910" }
            };
            return _personneList;
        }

        // GET api/<PersonneController>/5
        [HttpGet("{id}")]
        public Personne Get(int id)
        {
            return new Personne() { Nom="TestGetId", Prenom="TestGetId", Email = "Test@gmail.com", Telephone = "0607080910" };
        }

        // POST api/<PersonneController>
        [HttpPost]
        public IActionResult Post([FromBody] Personne personne)
        {
            //personne.Add();
            return Ok(new { message = "Personne ajoutée", personne });
        }

        // PUT api/<PersonneController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Personne personne)
        {
            personne.Id = id;
            return Ok(new { message = "Personne modifiée", personne });
        }

        // DELETE api/<PersonneController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(new { message = "Personne supprimée", Id = id });
        }
    }
}
