using Microsoft.AspNetCore.Mvc;

namespace SampleNetCoreMVC.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us!";
            return View();
        }
    }
}