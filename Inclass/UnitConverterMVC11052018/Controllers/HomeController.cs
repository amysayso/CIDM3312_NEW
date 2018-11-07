using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitConverterMVC11052018.Models;

namespace UnitConverterMVC11052018.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string anotherHello(int age)
        {
            return $"another hello, you are {++age} year old";
        }
        public string Hello(string name)
        {
            //return String.Format("Hello there{0}", name)
            return $"Hello there, {name} ";
        }

        public string CelsiusToFahrenheit(int temp)
        {
            decimal output = temp * (9m/5m) + 32;
            return $"{temp} in C is {output} in F";
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
