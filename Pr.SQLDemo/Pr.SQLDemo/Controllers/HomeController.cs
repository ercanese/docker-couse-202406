using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pr.SQLDemo.Models;

namespace Pr.SQLDemo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UsersDBContext _usersDBContext;
   

    public HomeController(UsersDBContext usersDBContext)
    {
        _usersDBContext = usersDBContext;
    }
    public IActionResult Index()
    {
        _usersDBContext.Users.ToList();
        return View(_usersDBContext.Users.ToList());
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
