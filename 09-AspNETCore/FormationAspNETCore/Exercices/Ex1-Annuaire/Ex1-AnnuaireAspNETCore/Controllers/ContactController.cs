using Ex1_AnnuaireAspNETCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ex1_AnnuaireAspNETCore.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            // Création d'une liste de contact vide
            List<Contact> contacts = new();

            // Je rempli ma liste grace à la méthode GetAll qui nous retourne une liste de contact
            contacts = Contact.GetAll();

            // Je retourne la liste à la vue
            return View(contacts);
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            // Création d'un contact vide
            Contact contact = new();

            //contact.Id = id; 
            contact = contact.Get(id).Item2;

            return View(contact);
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            Contact newContact = new();

            return View(newContact);
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Contact c)
        {
            Contact c2 = new Contact();
            c2 = c;
            c2.Add();

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            // Création d'un contact vide
            Contact contact = new();

            //contact.Id = id; 
            contact = contact.Get(id).Item2;

            return View(contact);
        }

        // POST: ContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Contact c)
        {
            Contact c2 = new Contact();
            c2 = c;
            c2.Update();

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            // Création d'un contact vide
            Contact contact = new();

            //contact.Id = id; 
            contact = contact.Get(id).Item2;

            return View(contact);
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Contact c)
        {
            Contact c2 = new Contact();
            c2 = c;
            c2.Delete();

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
