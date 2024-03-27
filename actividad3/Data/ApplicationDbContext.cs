using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using actividad3.Models;

namespace actividad3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Empleado> Empleados { get; set; } // DbSet para la entidad Empleado

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aquí puedes configurar restricciones adicionales o relaciones si es necesario
            base.OnModelCreating(modelBuilder);
        }
    }
}
