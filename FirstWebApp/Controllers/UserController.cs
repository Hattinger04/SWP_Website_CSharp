using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models; 

namespace FirstWebApp.Controllers
{
    public class UserController : Controller
    {
    public IActionResult Index()
        {
            User user = new User()
            {
                UserID = 100,
                Username = "Simon",
                Password = "Simon"
            }; 
            // Daten des Users an die View übergeben
            return View(user);
        }

        [HttpGet]
        public IActionResult Registration()
        {   
            return View();
        }
        [HttpPost]
        public IActionResult Registration(User userDataFromForm)
        {
            if(userDataFromForm == null)
            {
                return RedirectToAction("Registration");
            }
            // Falls Formular richtig ausgeführt wurde
            ValidateRegistrationData(userDataFromForm);
            if (ModelState.IsValid)
            {
                // TODO: DB
                return View("_Message", new Message("Registrierung", "Ihre Daten wurden erfolgreich abgespeichert"));
            }
            return View();
        }

        private void ValidateRegistrationData(User user)
        {
            if (user == null)
            {
                return; 
            }
            if(user.Username == null || (user.Username.Trim().Length < 4))
            {
                ModelState.AddModelError("Username", "Der Benutzername muss mind. 4 Zeichen lang sein!"); 
            }
            if (user.Password == null || (user.Password.Length < 8))
            {
                ModelState.AddModelError("Password", "Das Passwort muss mind. 8 Zeichen lang sein!");
            }
            
            if(user.Birthdate >= DateTime.Now)
            {
                ModelState.AddModelError("Birthdate", "Geboren in der Zukunft?!");
            }
             
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
