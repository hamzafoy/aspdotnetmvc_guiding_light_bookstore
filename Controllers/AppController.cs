using Microsoft.AspNetCore.Mvc;
using SampleNetCoreMVC.Data.Context;
using SampleNetCoreMVC.Models;
using SampleNetCoreMVC.Services;

namespace SampleNetCoreMVC.Controllers
{
    public class AppController : Controller
    {
        private readonly IConsoleMailService _mailService;
        private readonly GLBContext _context;

        public AppController(IConsoleMailService ConsoleMailService, GLBContext context)
        {
            _mailService = ConsoleMailService;
            _context = context;
        }
        public IActionResult Index()
        {
            var results = _context.Products.ToList();
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us!";
            return View();
        }

        [HttpGet("library")]
        public IActionResult Library()
        {
            var results = _context.Products
                .OrderBy(product => product.PublishingHouse)
                .ToList();
            //Also correct syntax
            //var results = from product in _context.Products
            //              orderby product.PublishingHouse
            //              select product;
            return View(results);
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