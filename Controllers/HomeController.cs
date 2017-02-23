using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.AspNetCore.Http;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
        
            HttpContext.Session.SetString("User", "Rami");
            return Json(true);
            
        
    }

        public IActionResult About()
        {
        var userContent = HttpContext.Session.GetString("User");
        return Json(userContent);
    }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
