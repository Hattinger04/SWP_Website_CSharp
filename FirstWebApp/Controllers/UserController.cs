﻿using Microsoft.AspNetCore.Mvc;
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

            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}
