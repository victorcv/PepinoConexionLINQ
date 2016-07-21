using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ConexionLINQ.Models
{
    public class PepinoModel
    {
        public PepinoModel()
        {
            Agricultors = new List<SelectListItem>();
        }
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Es necesario especificar un Nombre.")]
        //The {0} index is the display name of property, {1} is the MaximumLength, {2} is the MinimumLength
        [StringLength(100, ErrorMessage = "{0} necesita tener como mínimo {2} caracteres.", MinimumLength = 3)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Es necesario especificar un Peso.")]
        [DisplayName("Peso(g)")]
        [Range(0.01, 5000.00, ErrorMessage = "El peso debe de estar entre 0.01 y 5000.00 g")]
        public decimal Peso { get; set; }
        [Required(ErrorMessage = "Es necesario especificar una Longitud.")]
        [DisplayName("Longitud(cm)")]
        [Range(0.01, 100.00, ErrorMessage = "La longitud debe de estar entre 0.01 y 100.00 cm")]
        public decimal Longitud { get; set; }
        public int AgricultorId { get; set; }
        [Required(ErrorMessage = "Es necesario que selecciones un Agricultor")]
        [DisplayName("Agricultor")]
        public string AgricultorNombre { get; set; }
        public IEnumerable<SelectListItem> Agricultors { get; set; }
        [Required(ErrorMessage = "Es necesario que estés logeado")]
        public string Usuario { get; set; }
    }
}