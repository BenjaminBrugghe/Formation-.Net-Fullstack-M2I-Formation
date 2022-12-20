using CoursAspNETCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoursAspNETCore.Controllers
{
    public class PersonneController : Controller
    {
        // GET: PersonneControleur
        public ActionResult Index()
        {
            ViewBag.Data = "Je suis dans le ViewBag.Data";

            Personne.Personnes = new();
            Personne p = new()
            {
                Nom = "Brugghe",
                Prenom = "Benjamin",
                Email = "Email@gmail.com",
            };
            Personne.Personnes.Add(p);
            p = new()
            {
                Nom = "Mister",
                Prenom = "Bean",
                Email = "Mister@Bean.uk",
            };
            Personne.Personnes.Add(p);
            p = new()
            {
                Nom = "Nom3",
                Prenom = "Prenom3",
                Email = "nom@prenom.com",
            };
            Personne.Personnes.Add(p);
            return View(Personne.Personnes);
        }

        // GET: PersonneControleur/Details/5
        public ActionResult Details(int id)
        {
            Personne p = new();
            p = Personne.Find(id);

            return View(p);
        }

        // GET: PersonneControleur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonneControleur/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneControleur/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonneControleur/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonneControleur/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonneControleur/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
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
