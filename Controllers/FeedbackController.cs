using Microsoft.AspNetCore.Mvc;

public class FeedbackController : Controller
{
    [HttpGet]
    public IActionResult Submit()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(Feedback model)
    {
        if (model.Message?.ToLower().Contains("bad") == true)
        {
            ModelState.AddModelError("Message", "Повідомлення не може містити заборонені слова");
        }

        if (!ModelState.IsValid)
            return View(model);

        return RedirectToAction("Success");
    }
}
