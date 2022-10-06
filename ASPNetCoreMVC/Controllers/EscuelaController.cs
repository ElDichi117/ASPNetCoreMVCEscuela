using System;
using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASPNetCoreMVC.Controllers
{
    public class EscuelaController : Controller
    {
        private EscuelaContext _context; 
        public IActionResult Index()
        {
            var escuela = _context.Escuelas.FirstOrDefault();
            return View(escuela);
        }

        public EscuelaController (EscuelaContext context)
        {
            _context = context;
        }
    }
}
