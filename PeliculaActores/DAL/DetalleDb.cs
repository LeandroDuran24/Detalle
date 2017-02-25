using System.Data.Entity;
using PeliculaActores.Entidades;

namespace PeliculaActores.DAL
{
    public class DetalleDb : DbContext
    {
        public DetalleDb() : base("ConStr")
        {

        }

        public DbSet<Peliculas> p { get; set; }
        public DbSet<Actores> a { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actores>()
            .HasMany(actor => actor.pelicula)
            .WithMany(peli => peli.actor)
            .Map(peliculaActores =>
            {
                peliculaActores.MapLeftKey("PeliculaId");
                peliculaActores.MapRightKey("ActoresId");
                peliculaActores.ToTable("PeliculasActores");
            });
        }
    }
}
