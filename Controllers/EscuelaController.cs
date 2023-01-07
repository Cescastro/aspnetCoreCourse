using aspnetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetCoreCourse.Controllers;

public class EscuelaController : Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela("Escuela Salgar",1980);      
        escuela.Ciudad = "Medellin";
        escuela.Pais = "Colombia";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        escuela.Direccion = "Av EverGreen";

        ViewBag.CualquierDato ="cualquier dato";


        return View(escuela);
    }
}