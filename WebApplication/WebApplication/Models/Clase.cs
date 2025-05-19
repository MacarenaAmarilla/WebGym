using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GimnasioWeb.Models
{
    public class Clase
    {
        [Key]
        public int IdClase { get; set; }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int CupoMaximo { get; set; }
        public int CupoActual { get; set; }

        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}