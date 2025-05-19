using System.Data.Entity;

namespace GimnasioWeb.Models
{
    public class GimnasioContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Clase> Clases { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}