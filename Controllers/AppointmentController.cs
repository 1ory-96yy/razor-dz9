using Microsoft.AspNetCore.Mvc;

public class AppointmentController : Controller
{
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Appointment model)
    {
        if (!ModelState.IsValid)
            return View(model);

        return RedirectToAction("Success");
    }
}
