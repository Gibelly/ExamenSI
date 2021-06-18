using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Examen.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string PacienteNombre { get; set; }

        [Display(Name = "Segundo nombre")]
        [Required]
        public string PacienteNombre2 { get; set; }

        [Display(Name = "Apellido")]
        [Required]
        public string PacienteApellido { get; set; }

        [Display(Name = "example@example.com")]
        [Required]
        public string PacienteCorreo { get; set; }

        [Display(Name = "Nombre")]
        public string AcompNombre { get; set; }

        [Display(Name = "Apellido")]
        public string AcompApellido { get; set; }

        [Display(Name = "Dirección de la calle")]
        [Required]
        public string PacienteDireccionCalle { get; set; }

        [Display(Name = "Dirección de la calle linea 2")]
        [Required]
        public string PacienteDireccionCalle2 { get; set; }

        [Display(Name = "Ciudad")]
        [Required]
        public string PacienteCiudad { get; set; }

        [Display(Name = "Estado/Provincia")]
        [Required]
        public string PacienteProvincia { get; set; }

        [Display(Name = "Código Postal")]
        public int PacienteCodPostal { get; set; }

        [Display(Name = "Código de area")]
        public int PacienteCodArea { get; set; }

        [Display(Name = "Número de telefono")]
        public int PacienteTelefono { get; set; }

        [Display(Name = "Código de area")]
        public int PacienteCodArea2 { get; set; }

        [Display(Name = "Número de telefono")]
        public int PacienteWhatsapp { get; set; }
    }
}
