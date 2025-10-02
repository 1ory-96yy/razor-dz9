using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(UserRegistration model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        return RedirectToAction("Success");
    }

    public IActionResult Success()
    {
        return View();
    }
}