using InterviewTest.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace InterviewTest.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ProductList product)
        {
            return View();
        }
        public IActionResult View()
        {
            return View();
        }
    }

}
