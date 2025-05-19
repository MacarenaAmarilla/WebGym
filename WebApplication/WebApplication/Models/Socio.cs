using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GimnasioWeb.Models
{
    public class Socio
    {
        [Key]
        public int IdSocio { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Contraseña { get; set; }

        public string Telefono { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}