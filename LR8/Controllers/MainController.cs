using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Text;

public class MainController : Controller
{
    [Route("")]
    public IActionResult Index()
    {
        return RedirectToAction("ProductOrder", "Main");
    }

    [HttpGet]
    [Route("ProductOrder")]
    public IActionResult ProductOrder()
    {
        return View();
    }

    [HttpPost]
    [Route("ProductOrder")]
    public IActionResult ProductOrderPut(string name, string price)
    {
        bool result = false;
        try
        {
            Product product = new Product(name, decimal.Parse(price, CultureInfo.InvariantCulture), DateTime.Now);
            result = ProductValue.ProductOrder(product);
        }
        catch { }
        TempData["Status"] = result;
        return View("ProductOrder");
    }

    [HttpGet]
    [HttpPost]
    [Route("ProductView")]
    public IActionResult ProductView(string? mode)
    {
        if (mode == null)
        {
            TempData["mode"] = "list";
        }
        else
        {
            TempData["mode"] = mode;

        }
        TempData["Products"] = ProductValue.GetProductList();
        return View();
    }

}