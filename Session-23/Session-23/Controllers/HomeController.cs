using Microsoft.AspNetCore.Mvc;
using Session_23.EF;
using Session_23.Model;
using Session_23.Models;
using System.Diagnostics;

namespace Session_23.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;



        public HomeController(ILogger<HomeController> logger, IEntityRepo<Customer> customerRepo) {
            _logger = logger;
        }

        public IActionResult Index() {

            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}