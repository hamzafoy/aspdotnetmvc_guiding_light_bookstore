using Microsoft.AspNetCore.Mvc;
using SampleNetCoreMVC.Models;
using SampleNetCoreMVC.Services;

namespace SampleNetCoreMVC.Controllers
{
    public class AppController : Controller
    {
        private readonly IConsoleMailService _mailService;
        public AppController(IConsoleMailService ConsoleMailService)
        {
            _mailService = ConsoleMailService;
        }
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
            if (ModelState.IsValid)
            {
                //Send email
                _mailService.SendMessage("hamzaoflouisville@gmail.com", model.MessageSubject, $"From: {model.FullName} {model.Email}, Message: {model.MessageBody}");
                ViewBag.UserMessage = "Email Sent";
                ModelState.Clear();
            }
            else
            {
                //Show errors
            }
            return View();
        }
    }
}