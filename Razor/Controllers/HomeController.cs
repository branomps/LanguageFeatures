using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.StockLevel = 5;
            Product[] myProduct =
            {
                new Product {Name ="Kayak", Price = 275M},
                new Product {Name ="Lifejacket", Price = 48.50M},
                new Product {Name ="Soccer ball", Price = 19.50M},
                new Product {Name ="Corner flag" , Price = 34.95M},
                new Product {Name ="Soccer Web", Price = 20M}
            };
            return View(myProduct);
        }
    }
}