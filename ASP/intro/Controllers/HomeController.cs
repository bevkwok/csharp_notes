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


        //Rendering Views 
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

    }
}