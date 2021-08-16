using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ejemplos.Models
{
    public partial class Peliculas
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Año { get; set; }
        public string Duracion { get; set; }
    }
}
