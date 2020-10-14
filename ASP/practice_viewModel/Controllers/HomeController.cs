using Microsoft.AspNetCore.Mvc;
using practice_viewModel.Models;
using System.Collections.Generic;
namespace practice_viewModel
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string message = new string("Here is the message using @model string from the controller");
            return View("Index", message);
        }

        [HttpGet("numbers")]
        public IActionResult Number()
        {
            int[] numArray = new int[]
            {
                1, 2, 3, 10, 43, 5
            };

            return View("Number", numArray);
        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User moose = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            User sarah = new User()
            {
                FirstName = "Sarah",
            };

            User jerry = new User()
            {
                FirstName = "Jerry",
            };

            User rene = new User()
            {
                FirstName = "Rene",
                LastName = "Ricky"
            };

            User barbarah = new User()
            {
                FirstName = "Barbarah",
            };


            List<User> userList = new List<User>()
            {
                moose, sarah, jerry, rene, barbarah
            };

            return View("Users", userList);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User moose = new User()
            {
                FirstName = "Moose",
                LastName = "Phillips"
            };

            return View("User", moose);
        }
    }
}