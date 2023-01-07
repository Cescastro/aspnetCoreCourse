using Microsoft.AspNetCore.Mvc;
using aspnetCoreCourse.Models;

namespace aspnetCoreCourse.Controllers;

public class AsignaturaController : Controller
{
    public IActionResult Index()
    {  
        var Asignatura = new Asignatura();
        Asignatura.Nombre = "Programacion";

        var listaAsignaturas = new List<Asignatura> () {
            new Asignatura {
            Nombre = "Matemáticas"
            },
            new Asignatura {
            Nombre = "Educación Física"
            },
            new Asignatura {
            Nombre = "Castellano"
            },
            new Asignatura {
            Nombre = "Ciencias Naturales"
            },
            new Asignatura {
            Nombre = "Programacion"
            },
        };

        return View(listaAsignaturas);
    }

}