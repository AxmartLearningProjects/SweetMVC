using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SweetMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            Models.Bakery bakery1 = new Models.Bakery() { Id = 1, Name = "Sweet Paradise Bakery", Bakery_Value = 200000.00M, Founding_Date = new DateTime(2017, 8, 2) };


            return View(bakery1);
        }
    }
}
