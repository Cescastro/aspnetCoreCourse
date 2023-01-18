using Microsoft.AspNetCore.Mvc;
using aspnetCoreCourse.Models;

namespace aspnetCoreCourse.Controllers;

public class AlumnoController : Controller
{
    public IActionResult Index()
    {       
       
        return View();
    }
}