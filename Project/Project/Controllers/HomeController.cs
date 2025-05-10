using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        List<PersonModel> people = new List<PersonModel>();
        people.Add(new PersonModel { id = 1, name = "John" });
        people.Add(new PersonModel { id = 2, name = "Jane" });
        people.Add(new PersonModel { id = 3, name = "Doe" });
        people.Add(new PersonModel { id = 4, name = "Smith" });
        people.Add(new PersonModel { id = 5, name = "Emily" });

        return View(people);
    }

    public IActionResult Privacy()
    {
        var info = new InformationModel { Code = "123", Description = "Description", Name = "Name"};

        return View(info);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
