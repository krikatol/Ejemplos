using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplos.Models;
using Microsoft.AspNetCore.Mvc;
using Rotativa.AspNetCore;

namespace Ejemplos.Controllers
{
    public class CreatePDFController : Controller
    {
        public IActionResult Index()
        {
            var alumno = new Alumno()
            {
                Nombre = "Emmanuel Reyes",
                Ciudad = "Puebla",
                materias = new List<Materia>()
                {
                    new Materia()
                    {
                        Nombre = "Programacion",
                        Calificacion = 10.0m
                    },
                    new Materia()
                    {
                        Nombre = "Redes",
                        Calificacion = 9.2m
                    },
                    new Materia()
                    {
                        Nombre = "Base de datos",
                        Calificacion = 8.9m
                    }
                }
            };

            return new ViewAsPdf("Index", alumno)
            {

            };
        }
    }
}
