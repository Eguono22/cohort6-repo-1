using Microsoft.AspNetCore.Mvc;

namespace legacyapp.Controllers;

public class ServicesController : Controller
{
    private readonly ILogger<ServicesController> _logger;

    public ServicesController(ILogger<ServicesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ManagedDevOps()
    {
        ViewData["Title"] = "Managed DevOps";
        return View();
    }

    public IActionResult CloudMigration()
    {
        ViewData["Title"] = "Cloud Migration";
        return View();
    }

    public IActionResult CloudOptimization()
    {
        ViewData["Title"] = "Cloud Optimization";
        return View();
    }

    public IActionResult SecurityCompliance()
    {
        ViewData["Title"] = "Managed Security & Compliance";
        return View();
    }
}
