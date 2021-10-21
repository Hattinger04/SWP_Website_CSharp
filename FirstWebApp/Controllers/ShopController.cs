using FirstWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shop()
        {
            List <Article> articles = ArticleFromDB(); 
            return View(articles);
        }
        public IActionResult Basket()
        {
            return View();
        }
        private List<Article> ArticleFromDB()
        {
            return new List<Article>() {
                new Article() { ArticleID = 1, ArticleName = "RaspberryPI", Brand = "PI", ReleaseDate= new DateTime(2021,10,5) },
                new Article() { ArticleID = 2, ArticleName = "Handy", Brand = "Samsung", ReleaseDate= new DateTime(2014,11,8) },
                new Article() { ArticleID = 3, ArticleName = "Maus ", Brand = "Razor", ReleaseDate= new DateTime(2017,5,10) },
                new Article() { ArticleID = 4, ArticleName = "Uhr", Brand = "Rolex", ReleaseDate= new DateTime(1991,8,23) }
            };
        }
    }
    // Ist nicht von DB, kann es aber geben
    
}
