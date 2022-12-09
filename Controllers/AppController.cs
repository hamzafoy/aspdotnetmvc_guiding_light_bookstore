using Microsoft.AspNetCore.Mvc;
using SampleNetCoreMVC.Models;

namespace SampleNetCoreMVC.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us!";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            return View();
        }
    }
}