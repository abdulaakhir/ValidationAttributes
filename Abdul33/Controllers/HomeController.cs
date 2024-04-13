using Abdul33.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Abdul33.Controllers
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
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }    //With the help of this what i am doing when i will fill the from and
                 //when i will submit the form then  it will do blank in all the 
                 //block 
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student std)
        {
            return View();

            //if(ModelState.IsValid)
            //{
            //    return "Name is: " + std.Name;
            //}
            //else
            //{
            //    return "Validation Failed.. ";
            //}
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
