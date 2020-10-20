using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using candy.Models;

namespace candy.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // List<Candy> AllCandies = dbContext.Candies.ToList();
            ViewBag.AllCandies = dbContext.Candies.ToList();
            return View();
        }

        [HttpGet("new")]
        public IActionResult NewCandy()
        {
            return View();
        }

        [HttpPost("add_candy")]
        public IActionResult AddCandy(Candy newCandy)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(newCandy);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewCandy");
            }
        }

        [HttpGet("{id}")]
        public IActionResult CandyInfo(int id)
        {
            ViewBag.TheCandy = dbContext.Candies.FirstOrDefault(c => c.CandyId == id);
            return View();
        }

        [HttpGet("edit/{id}")]
        public IActionResult EditCandy(int id)
        {
            ViewBag.TheCandy = dbContext.Candies.FirstOrDefault(c => c.CandyId == id);
            
            return View();
        }

    }
}
