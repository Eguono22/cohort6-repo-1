using Microsoft.AspNetCore.Mvc;
using legacyapp.Models;

namespace legacyapp.Controllers;

public class ContactController : Controller
{
    private readonly ILogger<ContactController> _logger;

    public ContactController(ILogger<ContactController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(ContactFormModel model)
    {
        if (ModelState.IsValid)
        {
            // Process the contact form (e.g., send email, save to database)
            TempData["Message"] = "Thank you for contacting us! We'll get back to you soon.";
            return RedirectToAction(nameof(Index));
        }
        return View(model);
    }
}
