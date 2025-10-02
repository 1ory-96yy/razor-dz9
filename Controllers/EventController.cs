using Microsoft.AspNetCore.Mvc;

public class EventController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(EventRegistration model)
    {
        if (!ModelState.IsValid)
            return View(model);

        return RedirectToAction("Success");
    }
}
