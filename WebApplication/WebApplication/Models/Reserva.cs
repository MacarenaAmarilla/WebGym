using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimnasioWeb.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }

        public int SocioId { get; set; }
        [ForeignKey("SocioId")]
        public Socio Socio { get; set; }

        public int ClaseId { get; set; }
        [ForeignKey("ClaseId")]
        public Clase Clase { get; set; }

        public string Estado { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}