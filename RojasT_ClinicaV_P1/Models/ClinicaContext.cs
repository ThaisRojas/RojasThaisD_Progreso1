using Microsoft.EntityFrameworkCore;

namespace RojasT_ClinicaV_P1.Models
{
    public class ClinicaContext : DbContext
    {
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options) { }

        // Constructor sin parámetros para permitir las migraciones en tiempo de diseño
        public ClinicaContext() { }

        public DbSet<PropietarioMascota> Propietarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Visita> Visitas { get; set; }
    }
}
