using Microsoft.AspNetCore.Mvc;
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

        

        public IActionResult Index(UserModel u)
        {
         
            
            return View();
        }

        public IActionResult Privacy()
        {
           
            return View();
        }
      
     

        public class UserModel
        {
            public string Suggestion { get; set; }
        }

        public class suggestionButton
        {
            public string suggestionType { get; set; }

        }

       



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}