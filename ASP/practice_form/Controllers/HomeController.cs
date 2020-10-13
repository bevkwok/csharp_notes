using Microsoft.AspNetCore.Mvc;
using System;
namespace practice_form
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("form")]
        public IActionResult form(string name, string email)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            return View("form");
        }
    }
}