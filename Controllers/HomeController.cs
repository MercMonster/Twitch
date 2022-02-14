﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Twitch.Models;

namespace Twitch.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            
        }

        

        public IActionResult Index()
        {
         
            
            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }
      
     

       [HttpPost]
       public ActionResult Index(Suggestion s)
        {
            return View(s);
        }

        




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}