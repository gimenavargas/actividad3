using Microsoft.EntityFrameworkCore;
using actividad3.Models; // Asegúrate de incluir la referencia al espacio de nombres donde se encuentra la clase empleado

namespace actividad3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<empleados> empleados { get; set; } // DbSet para la entidad Empleado

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aquí puedes configurar restricciones adicionales o relaciones si es necesario
            base.OnModelCreating(modelBuilder);
        }
    }
}