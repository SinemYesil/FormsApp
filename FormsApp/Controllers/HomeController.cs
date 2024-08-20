using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult Index(string searchString, string category)
        {

            var products = Repository.Products;

            if (!String.IsNullOrEmpty(searchString))
            {

                products = products.Where(p => p.Name.ToLower().Contains(searchString.ToLower())).ToList();
            } //p.Name.ToLower().Contains(searchString)).ToList();

            if (!String.IsNullOrEmpty(category) && category!="0")
            {
                products = products.Where(p => p.CategoryId==int.Parse(category)).ToList();
            }

            ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name");
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}