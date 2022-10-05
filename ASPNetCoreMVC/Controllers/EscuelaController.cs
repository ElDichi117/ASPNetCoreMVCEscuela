using System;
using ASPNetCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreMVC.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuelas = new Escuela();
            escuelas.AñoDeCreación = 2005;
            escuelas.UniqueId = Guid.NewGuid().ToString();
            escuelas.Nombre = "PLATZI SCHOOL";
            return View(escuelas);
        }
    }
}
