using Microsoft.AspNetCore.Mvc;

public class ProductController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
            return View(product);
        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        return View();
    }
}
