using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ConexionLINQ.Models
{
    public class PepinoUsuarioModel
    {
        [Required]
        public int PepinoId { get; set; }
        [Required]
        public int UsuarioId { get; set; }
    }
}