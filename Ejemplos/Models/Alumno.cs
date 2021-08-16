using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejemplos.Models
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public List<Materia> materias { get; set; }

    }

    public class Materia
    {
        public string Nombre { get; set; }
        public decimal Calificacion { get; set; }
    }
}
