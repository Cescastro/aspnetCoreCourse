using aspnetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetCoreCourse.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.annoFundacion = 2005;
        escuela.EscuelaId = Guid.NewGuid().ToString();
        escuela.Nombre = "Colegio Salgar";

        return View(escuela);
    }
}