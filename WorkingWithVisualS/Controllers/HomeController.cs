using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualS.Models;

namespace WorkingWithVisualS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()  => View(SimpleRepository.SharedRepository.Products);
      
    }
}