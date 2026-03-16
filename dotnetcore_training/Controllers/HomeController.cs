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

            //Student student = new Student();
            //student.Id = 1;
            //student.Name = "Test Student";
            //student.City = "Pune";

            List<Student> studentList= new List<Student>();
            studentList.Add(new Student { Id = 1, Name = "Ram", City = "Pune" });
            studentList.Add(new Student { Id = 2, Name = "A", City = "Kolhapur" });
            studentList.Add(new Student { Id = 3, Name = "B", City = "Mumbai" });
            studentList.Add(new Student { Id = 4, Name = "C", City = "Nagpur" });

            return View(studentList);
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
