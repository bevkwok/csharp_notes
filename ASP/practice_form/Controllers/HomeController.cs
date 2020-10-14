using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using practice_form.Models;
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
            //first way of passing info from Controller to View
            ViewBag.Name = name;
            ViewBag.Email = email;

            //second way (have to pass someUser in View())
            // -first need to make a model
            User someUser = new User()
            {
                Name = name,
                Email = email
            };

            //Passing a list of User to View
            User oneUser = new User()
            {
                Name = "other",
                Email = "123@gmail.com"
            };

            List<User> userList = new List<User>()
            {
                someUser, oneUser
            };

            return View("form", someUser); 
            //first pass in the string of the View, follow by the object you want to pass in
            //change someUser to userList if want to pass in the List of User
        }
    }
}