using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebApp.Models;
using FirstWebApp.Models.DB;
using System.Data.Common;

namespace FirstWebApp.Controllers {
    public class UserController : Controller {

        private IRepositoryUsers repo = new RepositoryUsersDB();

        public async Task<IActionResult> Index() {
            try {
                await repo.ConnectAsync();
                return View(await repo.GetAllUsers());
            } catch (DbException) {
                return View("_Message", new Message("Datenbankfehler!", "Die Benutzer konnten nicht geladen werden! Versuchen sie es später erneut."));
            } finally {
                await repo.DisconnectAsync();
            }
        }

        [HttpGet]
        public IActionResult Registration() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Registration(User userDataFromForm) {
            if (userDataFromForm == null) {
                return RedirectToAction("Registration");
            }
            ValidateRegistrationData(userDataFromForm);
            if (ModelState.IsValid) {
                try {
                    await repo.ConnectAsync();
                    if (repo.Insert(userDataFromForm).Result) {
                        return View("_Message", new Message("Registrierung", "Ihre Daten wurden erfolgreich abgespeichert"));
                    } else {
                        return View("_Message", new Message("Registrierung", "Ihre Daten NICHT wurden erfolgreich abgespeichert", "Bitte versuchen sie es später erneut!"));
                    }
                } catch (DbException ex) {
                    return View("_Message", new Message("Registrierung", "Datenbankfehler!" + ex.Message, "Bitte versuchen sie es später erneut!"));
                } finally {
                    await repo.DisconnectAsync();
                }

            }
            return View(userDataFromForm);
        }
        private void ValidateRegistrationData(User user) {
            if (user == null) {
                return;
            }
            if (user.Username == null || (user.Username.Trim().Length < 4)) {
                ModelState.AddModelError("Username", "Der Benutzername muss mind. 4 Zeichen lang sein!");
            }
            if (user.Password == null || (user.Password.Length < 8)) {
                ModelState.AddModelError("Password", "Das Passwort muss mind. 8 Zeichen lang sein!");
            }

            if (user.Birthdate >= DateTime.Now) {
                ModelState.AddModelError("Birthdate", "Geboren in der Zukunft?!");
            }

        }
        [HttpGet]
        public IActionResult Login() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User userDataFromForm) {
            if (userDataFromForm == null) {
                return RedirectToAction("Login");
            }
            try {
                await repo.ConnectAsync();
                if (await repo.Login(userDataFromForm.Username, userDataFromForm.Password) != null) {
                    return View("_Message", new Message("Login", "User " + userDataFromForm.Username + " erfolgreich angemeldet!"));
                } else {
                    return View("_Message", new Message("Login", "Ihr Username oder Password war falsch", "Bitte überprüfen sie ihre Daten!"));
                }
            } catch (DbException ex) {
                return View("_Message", new Message("Registrierung", "Datenbankfehler! " + ex.Message, "Bitte versuchen sie es später erneut!"));
            } finally {
                await repo.DisconnectAsync();      
            }
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int id) {
            try {
                await repo.ConnectAsync();
                await repo.Delete(id);
                return RedirectToAction("Index");
            } catch (DbException) {
                return View("_Message", new Message("Datenbankfehler!", "Der Benutzer konnte nicht gelöscht werden! Versuchen sie es später erneut."));
            } finally {
                await repo.DisconnectAsync();
            }
        }
        [HttpGet]
        public IActionResult Update() {
            return View();
        }

        // email muss gleich lauten wie in js - ajax request - data
        [HttpGet]
        public async Task<IActionResult> CheckEmail(string email) {
            try {
                await repo.ConnectAsync();
                Console.WriteLine("Emails:" + await repo.IsEmailExisting(email)); 
                return new JsonResult(await repo.IsEmailExisting(email)); 
            } catch(DbException) {
                
            } finally {
                await repo.DisconnectAsync(); 
            }
            return new JsonResult(false);
        }

        // Wird so natürlich nicht funktionieren 
        [HttpPost]
        public async Task<IActionResult> Update(User user, int id) {
            try {
                await repo.ConnectAsync();
                await repo.ChangeUserData(id, user);
                return RedirectToAction("Index");
            } catch (DbException) {
                return View("_Message", new Message("Datenbankfehler!", "Der Benutzer konnte nicht geändert werden! Versuchen sie es später erneut."));
            } finally {
                await repo.DisconnectAsync();
            }
        }
    }
}