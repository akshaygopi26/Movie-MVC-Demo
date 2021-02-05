using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MovieMVC.Controllers
{
    public class Helloworld : Controller
    {
        // 
        // GET: /HelloWorld/

        //public string Index()
        //{
        //  return "This is my default action...";
        //}
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 



        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        // public string Welcome(string name, int numTimes = 1)
        // {
        //   return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        //  }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
