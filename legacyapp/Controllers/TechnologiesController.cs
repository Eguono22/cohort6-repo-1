using Microsoft.AspNetCore.Mvc;

namespace legacyapp.Controllers;

public class TechnologiesController : Controller
{
    private readonly ILogger<TechnologiesController> _logger;

    public TechnologiesController(ILogger<TechnologiesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
