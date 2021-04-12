using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


using System.Text;


namespace Context
{
    public class Contex : DbContext, IContextDb
    {
        public Contex(DbContextOptions<Contex> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Deportista> Deportista { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<DeportistaClub> DeportistaClub { get; set; }
        public DbSet<DeportistasBaneados> DeportistasBaneados { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<ClubCategoria> ClubCategoria { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Nivel> Nivel { get; set; }
        public DbSet<DeportistasNiveles> DeportistasNiveles { get; set; }
        public DbSet<Contenido> Contenido { get; set; }
        public DbSet<ContenidoVideo> ContenidoVideo { get; set; }
        
        public DbSet<Invitaciones> Invitaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Deportista>().ToTable("Deportista");
            modelBuilder.Entity<Club>().ToTable("Club");
            modelBuilder.Entity<DeportistaClub>().ToTable("DeportistaClub");
            modelBuilder.Entity<DeportistasBaneados>().ToTable("DeportistasBaneados");
            modelBuilder.Entity<Categorias>().ToTable("Categorias");
            modelBuilder.Entity<ClubCategoria>().ToTable("ClubCategoria");
            modelBuilder.Entity<Video>().ToTable("Video");
            modelBuilder.Entity<Nivel>().ToTable("Nivel");
            modelBuilder.Entity<DeportistasNiveles>().ToTable("DeportistasNiveles");
            modelBuilder.Entity<Contenido>().ToTable("Contenido");
            modelBuilder.Entity<ContenidoVideo>().ToTable("ContenidoVideo");
            modelBuilder.Entity<Invitaciones>().ToTable("Invitaciones");
        }
    }
}
