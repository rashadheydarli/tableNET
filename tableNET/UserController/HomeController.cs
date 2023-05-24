using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace tableNET.UserController
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            ViewBag.Name = "Rashad";
            ViewData["Surname"] = "Heydarli";
            ViewData["Age"] = 27;
            ViewBag.Country = "Azerbaijan";
            ViewBag.PhoneNumber = +9941111111;
            
            return View();
        }
    }
}

