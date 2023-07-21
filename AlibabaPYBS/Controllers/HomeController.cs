using AlibabaPBYS.Core.Interfaces.Services;
using AlibabaPYBS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AlibabaPYBS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarService _carService;

        public HomeController(ILogger<HomeController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        public async Task<IActionResult> Index()
        {
            var cars = await _carService.GetAllCars();
            return View(cars);
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