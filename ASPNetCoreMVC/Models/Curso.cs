using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreMVC.Models
{
    public class Curso : ObjetoEscuelaBase
    {
        [Required]//hacemos que el nombres solamente sea requerido
                  //para este modelo
        public override string? Nombre { get; set; }//Agregando ? hacemos que no se generen los required automaticos
        public TiposJornada? Jornada { get; set; }
        public List<Asignatura>? Asignaturas { get; set; }
        public List<Alumno>? Alumnos { get; set; }
        //public string Dirección { get; set; }
        public string? EscuelaId { get; set; }
        public Escuela? Escuela { get; set; }
    }
}
