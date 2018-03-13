using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return View(new string[] { "C#", "Language", "Features"});

            List<string> results = new List<string>();

            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;
                results.Add(string.Format($"Name : {name}, Price : {price}"));
            }

            return View(results);
        }
    }
}