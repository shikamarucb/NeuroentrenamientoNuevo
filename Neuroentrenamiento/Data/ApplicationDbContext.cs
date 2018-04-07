using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Neuroentrenamiento.Models;

namespace Neuroentrenamiento.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Prueba> Prueba { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
        public DbSet<PruebaPeriodo> PruebaPeriodo { get; set; }
        public DbSet<Resultado> Resultados { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Resultado>().HasKey(c => new { c.Id_PruebaPeriodo, c.Id_ApplicationUser });
        }
    }
}
