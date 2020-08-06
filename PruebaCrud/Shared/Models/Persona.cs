using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaCrud.Shared.Models
{
    public class Persona
    {
        public int id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string nombre { get; set; }
    }
}
