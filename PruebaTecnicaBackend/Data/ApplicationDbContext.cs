using Microsoft.EntityFrameworkCore;
using Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Articulos> Articuloss { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar la precisión y escala para la propiedad Precio
            modelBuilder.Entity<Articulos>()
                .Property(a => a.Precio)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
