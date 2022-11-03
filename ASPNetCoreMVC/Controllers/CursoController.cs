using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASPNetCoreMVC.Controllers
{
    public class CursoController : Controller
    {

        public IActionResult Index(string id)
        {
            if (!string.IsNullOrEmpty(id))//si no es nula
            {
                var cursos = from curso in _context.Cursos
                              where curso.Id == id
                              select curso;
                return View(cursos.Single());
            }
            else
            {
                return View("MultiCurso", _context.Cursos);
            }
        }
        public IActionResult MultiCurso()
        {
            return View("MultiCurso", _context.Cursos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]//El siguiente métodod solo se va a usar cuando se de
                    //click al botón submit
        public IActionResult Create(Curso curso)
        {
            if (ModelState.IsValid)
            {
                var escuela = _context.Escuelas.FirstOrDefault();

                curso.EscuelaId = escuela.Id;    
                _context.Cursos.Add(curso);//Aquí se agrega el curso a la lista de cursos
                _context.SaveChanges();
                return View();
            }
            else
            {
                return View(curso);
            }
        }

        private EscuelaContext _context;

        public CursoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
