using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.Extensions.Logging; 

namespace FormsApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchString)
        {

            var products = Repository.Products;

            if (!String.IsNullOrEmpty(searchString))
            {

                products = products.Where(p => p.Name.ToLower().Contains(searchString.ToLower())).ToList();
            } //p.Name.ToLower().Contains(searchString)).ToList();


            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}