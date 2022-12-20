using CoursCookiesSession.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CoursCookiesSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Création d'un objet à stocker dans les cookies

            List<String> liste = new List<String>() { "Toto", "Titi", "Tata"};

            // Création d'une clé pour les cookies

            HttpContext.Session.SetString("key-session", "value-session");

            // Envoi des valeurs

            HttpContext.Session.SetString("liste", JsonConvert.SerializeObject(liste));

            return View();
        }

        public IActionResult Privacy()
        {
            string value = HttpContext.Session.GetString("key-session");
            string chaineJson = HttpContext.Session.GetString("liste");

            List<string> liste = JsonConvert.DeserializeObject<List<string>>(chaineJson);

            ViewBag.Liste = liste;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
