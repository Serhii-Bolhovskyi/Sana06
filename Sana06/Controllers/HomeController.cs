using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sana06.Models;

namespace Sana06.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    private List<Skill> GetSkills()
    {
        return new List<Skill>
        {
            new Skill { Name = "JavaScript", Level = "Advanced", Range = 3 },
            new Skill { Name = "HTML", Level = "Advanced", Range = 3 },
            new Skill { Name = "CSS/TailwindCss", Level = "Intermediate", Range = 2 },
            new Skill { Name = "C#", Level = "Intermediate", Range = 2 },
            new Skill { Name = "ASP.NET", Level = "Beginner", Range = 1 },
            new Skill { Name = "React", Level = "Beginner", Range = 1 },
            new Skill { Name = "Git", Level = "Intermediate", Range = 2 },
        };
    }

    public IActionResult Index()
    {
        var skills = GetSkills();
        return View(skills);
    }

    public IActionResult Skills()
    {
        var skills = GetSkills();
        return View(skills);
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