using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using FirstWebApp.Models.DB;
using System.Data.Common;

namespace FirstWebApp.Controllers
{
    public class UserController : Controller
    {

    private IRepositoryUsers repo = new RepositoryUsersDB(); 

    public IActionResult Index()
        {
            try {
                repo.Connect();
                return View(repo.GetAllUsers());
            } catch(DbException) {
                return View("_Message", new Message("Datenbankfehler!", "Die Benutzer konnten nicht geladen werden! Versuchen sie es später erneut.")); 
            } finally {
                repo.Disconnect(); 
            }
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
                try {
                    repo.Connect(); 
                    if(repo.Insert(userDataFromForm)) {
                        return View("_Message", new Message("Registrierung", "Ihre Daten wurden erfolgreich abgespeichert"));
                    } else {
                        return View("_Message", new Message("Registrierung", "Ihre Daten NICHT wurden erfolgreich abgespeichert", "Bitte versuchen sie es später erneut!"));
                    }
                } catch(DbException ex) {
                    return View("_Message", new Message("Registrierung", "Datenbankfehler!" + ex.Message, "Bitte versuchen sie es später erneut!"));
                } finally {
                    repo.Disconnect(); 
                }
                
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
