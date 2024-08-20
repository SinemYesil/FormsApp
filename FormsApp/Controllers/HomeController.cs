using System.Diagnostics;
using System.Globalization;
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

                products = products.Where(p => p.Name.IndexOf(searchString, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            } //p.Name.ToLower().Contains(searchString)).ToList();

            if (!String.IsNullOrEmpty(category) && category!="0")
            {
                products = products.Where(p => p.CategoryId==int.Parse(category)).ToList();
            }

            //ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category );
            var model = new ProductViewModel
            {
                Products = products, 
                Categories = Repository.Categories, 
                SelectedCategory = category
            };
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = Repository.Categories;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product model)
        {
            return View();
        }
    
    }
}