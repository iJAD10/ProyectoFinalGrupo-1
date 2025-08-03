using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoFinalGrupo_1.Models
{
    public class Event 
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        [Display(Name = "Fecha del Evento")]
        public DateTime FechaEvento { get; set; }

        public string Lugar { get; set; }

        public string Banner { get; set; } 

        [Display(Name = "¿Está vendido?")]
        public bool EstaVendido { get; set; }


    }
}
