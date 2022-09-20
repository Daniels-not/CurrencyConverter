using CurrencyConverter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Application.Services;
using Application.Models;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public double res;

        public CurrencyConverterServices _converterServices = new();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_converterServices.getResult());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CurrencyCoverterModel data)
        {
            _converterServices.ConvertTo(data);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}