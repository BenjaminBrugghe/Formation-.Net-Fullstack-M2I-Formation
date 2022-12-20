using Microsoft.AspNetCore.Mvc;
using TpAnnuaireAPI.Models;

namespace TpAnnuaireAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            List<Contact> _contactList = new();

            _contactList = Contact.GetAll();

            return _contactList;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            List<Contact> _contactList = new();
            Contact _contact = new();

            _contactList = Contact.GetAll();

            foreach (Contact c in _contactList)
            {
                if (c.Id == id)
                {
                    _contact = c;
                }
            }

            return _contact;
        }

        // POST api/<ContactController>
        [HttpPost]
        public IActionResult Post([FromBody] Contact contact)
        {
            Contact _contact = new Contact();
            _contact = contact;

            contact.Add();

            return Ok(new { message = "Contact ajouté", contact });
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Contact contact)
        {
            Contact _contact = new Contact();
            _contact = contact;

            contact.Update();

            return Ok(new { message = "Contact modifié", contact });
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            List<Contact> _contactList = new();
            Contact _contact = new();

            _contactList = Contact.GetAll();

            foreach (Contact c in _contactList)
            {
                if (c.Id == id)
                {
                    _contact = c;
                }
            }

            _contact.Delete();

            return Ok(new { message = "Contact supprimé", Id = id });
        }
    }
}
