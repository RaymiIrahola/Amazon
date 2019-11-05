using System;
using System.Collections.Generic;
using System.Diagnostics;
using LiteDB;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Amazon.Web.Models;

namespace Amazon.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
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
