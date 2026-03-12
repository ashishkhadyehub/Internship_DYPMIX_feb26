using System.Diagnostics;
using dotnetcore_training.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_training.Controllers
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

            //int a = 70;
            //return View(a);
            //string name = "Test Student";
            //return View("Index",name);

            Student student = new Student();
            student.Id = 1;
            student.Name = "Test Student";
            student.City = "Pune";


            return View(student);
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
