using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTest.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is the main method";
        }

        public string Welcome()
        {
            return "This is the welcome method";
        }
    }
}
        
        // GET: /<controller>/
        /*public IActionResult Index()
        {
            return View();
        }*/
    
