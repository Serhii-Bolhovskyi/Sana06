using Microsoft.AspNetCore.Mvc;
using Sana06.Models;

namespace Sana06.Controllers;

public class ExperienceController : Controller
{
  
    public IActionResult Education()
    {
        var education = new List<Education>
        {
            new Education()
            {
                Name = "Software Engineering",
                Institution = "Zhytomyr technical university",
                Year = "2024 - present",
                Status = "In progress"
            }
        };

        var courses = new List<Course>
        {
            new Course()
            {
                Name = "Modern JavaScript",
                Platform = "Udemy",
                Year = "2023",
                Status = "Completed",
                Technologies = new List<string> { "JavaScript", "NPM" }
            }
        };
        
        var model = new EducationViewModel
        {
            Education = education,
            Courses = courses
        };
        return View(model);
    }
}