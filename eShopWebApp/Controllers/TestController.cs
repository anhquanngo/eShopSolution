using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopWebApp.Controllers
{
    public class TestController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }

        public IActionResult Hello()
        {
            ViewData["Greeting"] = "Hello World!";
            return View();
        }

        public IActionResult Quan()
        {
            return View("Views/Test/hello.cshtml");
        }

    }
}
