using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //GET
        public IActionResult Index()
        {
            //Object initialization
            var model = new FizzandBuzz();
            return View(model);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FizzandBuzz input)
        {
            //Input numbers
            //int firstNum = input.FirstNum;
            //int secondNum = input.SecondNum;

            for (int loop = input.FirstNum; loop <= input.SecondNum; loop++)
            {
                int fizz = loop % 3;
                int buzz = loop % 5;
                
                if(fizz == 0 && buzz == 0)
                {
                    input.Message += " FizzBuzz";
                }
                else if(fizz == 0)
                {
                    input.Message += " Fizz";
                }
                else if(buzz == 0)
                {
                    input.Message += " Buzz";
                }
                else
                {
                    input.Message += $" {loop}";
                }

            }

                return View(input);
        }

        private IActionResult Privacy()
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
