using cloud2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace cloud2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GoToLogin()
        {
            return RedirectToAction("Login", "Login"); 
        }

        public IActionResult GoToRegister()
        {
            return RedirectToAction("Register", "Register");
        }

        public IActionResult GoToAccount()
        {
            return RedirectToAction("Account", "Account");
        }

        public IActionResult GoToChangePassword()
        {
            return RedirectToAction("EditPassword", "Account");
        }

        public IActionResult GoToFile()
        {
            return RedirectToAction("File", "File");
        }

        public IActionResult GoToDashboard() {
            return RedirectToAction("Dashboard", "Dashboard");
        }

        public IActionResult GoToAddFile()
        {
            return RedirectToAction("FileAdd", "File");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}