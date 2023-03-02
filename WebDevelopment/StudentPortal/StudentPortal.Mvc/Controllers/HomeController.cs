using Microsoft.AspNetCore.Mvc;
using StudentPortal.Mvc.Models;
using System.Diagnostics;

namespace StudentPortal.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public string CurrentTime()
        {
            return DateTime.Now.ToString("MMM dd, yyyy hh:mm:ss");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Download()
        {
            return File(new byte[100], "");
        }
    }
}