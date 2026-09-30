using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc; // Changed from System.Web.Mvc
using Products.Models;

namespace Products.Controllers
{
    public class ProductController : Controller
    {
        // Static dataset list
        private static List<Product> productList = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop for work and gaming.", Price = 75000, Category = "Electronics" },
            new Product { Id = 2, Name = "Running Shoes", Description = "Comfortable and durable athletic footwear.", Price = 6000, Category = "Sports" },
            new Product { Id = 3, Name = "Coffee Maker", Description = "Automatic drip coffee maker with programmable timer.", Price = 4550, Category = "Home" }
        };

        // GET: /Product/ or /Product/Index
        public IActionResult Index() // Changed from ActionResult to IActionResult
        {
            return View(productList);
        }

        // GET: /Product/Details/1
        public IActionResult Details(int id)
        {
            var product = productList.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound(); // Changed from HttpNotFound()
            }

            return View(product);
        }
    }
}
