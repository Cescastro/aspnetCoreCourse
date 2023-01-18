using aspnetCoreCourse.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace aspnetCoreCourse.Controllers;

public class EscuelaController : Controller
{
    private EscuelaContext _context;
    public IActionResult Index()
    {
       
        ViewBag.CualquierDato ="cualquier dato";

        var escuela = _context.Escuelas.FirstOrDefault();


        return View(escuela);
    }

    public EscuelaController(EscuelaContext context)
    {
        _context = context;        
    }
}