namespace ASPNetCoreMVC.Models
{
    public class Alumno : ObjetoEscuelaBase
    {
        public string CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Evaluación> Evaluaciones { get; set; }

        //public string EvaluacionId { get; set; }
    }
}
