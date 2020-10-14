using Microsoft.AspNetCore.Mvc;
using form_with_validation.Models;
namespace form_with_validation
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }
    }
}