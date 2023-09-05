using ASP.NET_MVC_Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_Demo.Controllers
{
    public class DemoController : Controller //Controller
    {
        public IActionResult Index() //Action method
        {
            UserModel u = new UserModel();
            u.Id = 1;
            u.Name = "Test";
            u.Email = "Test@gmail.com";
            string tmp = "Hello World!";
            return View(u);
        }

    }
}
