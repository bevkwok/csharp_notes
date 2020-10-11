using Microsoft.AspNetCore.Mvc;
using System.Globalization;
namespace redo_profolioII
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            // DateTime localDate = DateTime.Now;
            // ViewBag.CurrentTime = DateTime.Now.ToString("hh:mm dddd, dd MMMM yyyy");

            return View();
        }


        [HttpGet("/projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }


    }
}