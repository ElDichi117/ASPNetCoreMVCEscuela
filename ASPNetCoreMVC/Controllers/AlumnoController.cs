using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASPNetCoreMVC.Controllers
{
    public class AlumnoController : Controller
    {

        public IActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id))//si no es nula
            {
                var alumnos = from alumn in _context.Alumnos
                              where alumn.Id == id
                              select alumn;
                return View(alumnos.Single());
            }
            else
            {
                return View("MultiAlumno", _context.Alumnos);
            }
        }
        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno", _context.Alumnos);
        }

        private EscuelaContext _context;

        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
