using Microsoft.AspNetCore.Mvc;
using SWAPI.MVC.Models;
using System.Diagnostics;

namespace SWAPI.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<string> _names;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            //                               0       1      2        3
            _names = new List<string>() { "Terry","Rigo","Benard","Jessi"};
        }

        public IActionResult Index()
        {
            //get a random numeric value....
            //we want to make sure that we consider the _names collections .Count()
            //4ppl max
            //remember? Collections start at zero!!!
            Random rnd = new Random();
            //this will give back an index value that we can use to "grab" a specific name
            int value = rnd.Next(0, _names.Count);

            //TempData["name"] = _names[value];

            return View(model: _names[value]);
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

        
    }
}
