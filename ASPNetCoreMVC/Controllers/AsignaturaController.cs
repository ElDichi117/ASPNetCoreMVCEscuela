using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASPNetCoreMVC.Controllers
{
    public class AsignaturaController : Controller
    {
        //Cambiando enrutamiento de este método
        [Route("Asignatura/Index")]
        [Route("Asignatura/Index/{asignaturaId}")]
        public IActionResult Index(string asignaturaId)
        {
            var asignatura = from asig in _context.Asignaturas
                             where asig.Id == asignaturaId
                             select asig;
            return View(asignatura.Single());
        }

        public IActionResult MultiAsignatura()
        {
            //Va al contexto y trae la lista completa de las asignaturas   
            return View("MultiAsignatura", _context.Asignaturas);
        }

        private EscuelaContext _context;

        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
