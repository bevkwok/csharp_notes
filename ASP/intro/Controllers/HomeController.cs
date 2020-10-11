using Microsoft.AspNetCore.Mvc;
namespace intro //namespace ProjectName
{
    public class HomeController : Controller //labeling it to be a controller - inheritance
    {
        //this is the place to handler request and delivering responses.

        //Requests - need a route

        //localhost:5000/
        [Route("")]
        //What type of request - default : get request
        [HttpGet]
        //Response - A method or an action
        public string HelloFromController()
        {
            return "Hello From Controller!";
        }

        //localhost:5000/hello
        [Route("hello")]
        [HttpGet] // can be merge [HttpGet("hello)]

        public string Hello()
        {
            return "Hi, again!";
        }

        //add parameter in Route
        //localhost:5000/users/???
        [HttpGet("users/{username}")]
        public string HelloUser(string username)
        {
            return $"Hello {username}";
        }


        //Rendering Views ------------------------------
        //use type - ViewResult
        [HttpGet("view")]
        public ViewResult index()
        {
            //View will try to find the file according to the action
            // in this case view will look for index.cshtml
            // because our action name is index()

            return View(); 
            // returning nothing in view will look for action name cshtml file
            // can also provide name and it will look for whatever you provide

            // ViewResult myView = View();
            // return myView;
        }

        //Redirecting ------------------------------
        //Method - RedirectToAction
        //Type - RedirectToActionResult
        public RedirectToActionResult Method()
        {
            return RedirectToAction("Other");
        }

        public ViewResult Other()
        {
            return View();
        }

        //Redicecting and passing argument ----------
        public RedirectToActionResult TheMethod()
        {
            return RedirectToAction("OtherMethod", new {Food = "chicken", Flavor = "salty"});
        }
        
        [HttpGet]
        [Route("other/{Food}/{Flavor}")]
        public ViewResult OtherMethod(string Food, string Flavor)
        {
            System.Console.WriteLine($"I ate {Flavor} {Food}");

            return View();
        }


        // Another example of redirecting and passing argument ----------
        [HttpGet("example2")]
        public RedirectToActionResult Example2()
        {
            System.Console.WriteLine("Redirecting...");
            var param = new {username="Devon", ResponseCacheLocation="Seattle"};
            return RedirectToAction("HelloUser", param); 
            //will be directed to the action called HelloUser
        }


        //IActionResult ---------------------------------
        //it implemetns all possible action results
        //not limited to one type of return
        [HttpGet("iaction")]
        public IActionResult Example3(string something)
        {
            if(something == "redirect")
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Json(new {Something = something});
            }
        }


        //UseInterface as a return type
        public interface IMovable
        {
            void Move();
        }

        // one class called person : IMovable
        // one other class called Car : IMovable

        public IMovable GetMovable() // IActionResult is also usiable
        {
            if(isPerson)
            {
                return new Person();
            }
            return new Car();
        }

        
        //ViewBag
        //a way to send data from controllers to views
        //is a dictionary, persists over one view return
        [HttpGet("viewBag")]
        public IActionResult VBExample()
        {
            ViewBag.Example = "Hello World";
            return View();
            //then move to VBExample.cshtml
            //<p>@ViewBag.Example</p>
            //Or
            // @{
            //     string VBSentence = ViewBag.Example + "Hi!";
            // }
            // <p>@VBSentence</p>
        }

    }
}