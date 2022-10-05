using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVC.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura
            {
                UniqueId = Guid.NewGuid().ToString(),
                Nombre = "Programación"
            };
            return View(asignatura);
        }
    }
}
