using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConexionLINQ.Models
{
    public class AgricultorModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario especificar un Nombre.")]
        [StringLength(100, ErrorMessage = "{0} necesita tener como mínimo {2} caracteres.", MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario especificar una Población.")]
        [StringLength(100, ErrorMessage = "{0} necesita tener como mínimo {2} caracteres.", MinimumLength = 3)]
        public string Poblacion { get; set; }
        [Required(ErrorMessage = "Es necesario especificar un Código Postal.")]
        [StringLength(10, ErrorMessage = "{0} necesita tener como mínimo {2} caracteres.", MinimumLength = 5)]
        public string CP { get; set; }
    }
}