//--------------------------------------------------------//
// The Home controller connects to the view
// (localhost:{}/Home)
//--------------------------------------------------------//

using Lab3_S4675880.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab3_S4675880.Controllers
{
    public class HomeController : Controller
    {
        // This interface is used for logging in .NET applications.
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Important: returning View which can be found in folder Views > Home > Index
        public IActionResult Index()
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
