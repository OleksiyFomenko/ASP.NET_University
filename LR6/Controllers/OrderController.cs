using LR6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LR6.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(User user)
        {
            if (user.Age > 16)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Result(Product[] products)
        {
            if (products == null || products.Length == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            try
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Product Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }

                return View(products);
            }
            catch (Exception)
            {
                return RedirectToAction("Error", "Home");
            }
        }
    }
}