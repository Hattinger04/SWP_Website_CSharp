using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Allgemeine Sachen wie home, Impressum, über uns, ...
namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View(getMitarbeiterFromDB());
        }

        public IActionResult Impressum()
        {
            return View();
        }

        private List<Mitarbeiter> getMitarbeiterFromDB()
        {
            return new List<Mitarbeiter>()
            {
                new Mitarbeiter(){MitarbeiterID = 0, Firstname = "Simon", Lastname = "Greiderer", Gehalt = 7000},
                new Mitarbeiter(){MitarbeiterID = 1, Firstname = "Guido", Lastname = "Kurz", Gehalt = 1500 },
                new Mitarbeiter(){MitarbeiterID = 2, Firstname = "Julius", Lastname = "Greil", Gehalt = 3000}
            }; 
        }
    }
}
