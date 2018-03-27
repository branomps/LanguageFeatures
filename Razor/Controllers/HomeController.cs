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
        public ViewResult Index()
        {
            ViewBag.StockLevel = 2;
            Product myProduct = new Product()
            {
                ProductID = 1,
                Name = "Kayak",
                Description = "A boaat for one person",
                Category = "Watersports",
                Price = 275M
            };
            return View(myProduct);
        }
    }
}