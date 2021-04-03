using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Context
{
    public interface IContextDb
    {
        DbSet<Usuario> Usuario { get; set; }
        DbSet<Deportista> Deportista { get; set; }
        DbSet<Club> Club { get; set; }
        DbSet<DeportistaClub> Invitacion { get; set; }
        DbSet<DeportistasBaneados> DeportistasBaneados { get; set; }
        DbSet<Categorias> Categorias { get; set; }
        DbSet<ClubCategoria> ClubCategoria { get; set; }
        DbSet<Video> Video { get; set; }
        DbSet<Nivel> Nivel { get; set; }
        DbSet<DeportistasNiveles> DeportistasNiveles { get; set; }
        DbSet<Contenido> Contenido { get; set; }
        DbSet<ContenidoVideo> ContenidoVideo { get; set; }
        DbSet<Invitaciones> Invitaciones { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

    }
}
