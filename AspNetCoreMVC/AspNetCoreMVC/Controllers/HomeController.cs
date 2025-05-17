using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreMVC.Models;

namespace AspNetCoreMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<PersonModel> people = new List<PersonModel>
        {
            new PersonModel { id = 1, name = "John Doe" },
            new PersonModel { id = 2, name = "Jane Smith" },
            new PersonModel { id = 3, name = "Sam Brown" }
        };

        return View(people);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
