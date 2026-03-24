using Microsoft.AspNetCore.Mvc;

namespace LA.UI.Controllers
{
    public class ConceptsController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.Message = "This data is from ViewBag";
            //ViewData["Message"] = "This data is from ViewData";
            TempData["Message"] = "This data is from TempData";
            return View();
        }

        public IActionResult NextPage()
        {
            return View();
        }
    }
}
