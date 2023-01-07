using Microsoft.AspNetCore.Mvc;
using aspnetCoreCourse.Models;

namespace aspnetCoreCourse.Controllers;

public class AsignaturaController : Controller
{
    public IActionResult Index()
    {  
        var Asignatura = new Asignatura();
        Asignatura.Nombre = "Programacion";

        return View(Asignatura);
    }

}