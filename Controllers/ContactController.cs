using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    [HttpGet]
    public IActionResult Send()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Send(ContactForm form)
    {
        if (!ModelState.IsValid)
            return View(form);
        return RedirectToAction("Success");
    }
}
