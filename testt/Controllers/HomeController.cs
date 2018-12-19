using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testt.Models;
using Microsoft.AspNetCore.Http;


namespace testt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("isim", "ssaas");
            HttpContext.Session.SetInt32("no", 1321);
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Kullanıcı bilgileri";
            ViewBag.Name = HttpContext.Session.GetString("isim");
            ViewBag.Age = HttpContext.Session.GetInt32("no");
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
