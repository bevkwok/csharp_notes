using Microsoft.AspNetCore.Mvc;
namespace razor
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult index()
        {
            return View();
        }
    }
}