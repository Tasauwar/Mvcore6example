using Microsoft.AspNetCore.Mvc;
using mvcgitexample.Models;
using System.Diagnostics;

namespace mvcgitexample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //add test method for merging changes
    //add comment for testing merge code
>
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
         public IActionResult TestPrivacy()
        {
            return View();
        }
        public IActionResult TestTestPrivacy()
        {
            return View();
        }



    }
}
