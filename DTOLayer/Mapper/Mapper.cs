using AutoMapper;
using Domain;
using DTOLayer.DtoClasses;

namespace DTOLayer.Mapper
{
    public class Mapper : Profile
    {
        public Mapper() {

            //Mapeas las DTO
            CreateMap<CategoriasDTO, Categorias>();
            CreateMap<Categorias, CategoriasDTO>();

            CreateMap<ClubDTO, Club>();
            CreateMap<Club, ClubDTO>();

            CreateMap<ClubCategoriaDTO, ClubCategoria>();
            CreateMap<ClubCategoria, ClubCategoriaDTO>();

            CreateMap<ContenidoVideoDTO, ContenidoVideo>();
            CreateMap<ContenidoVideo, ContenidoVideoDTO>();

            CreateMap<DeportistaDTO, Deportista>();
            CreateMap<Deportista, DeportistaDTO>();

            CreateMap<DeportistaClubDTO, DeportistaClub>();
            CreateMap<DeportistaClub, DeportistaClubDTO>();

            CreateMap<DeportistasBaneadosDTO, DeportistasBaneados>();
            CreateMap<DeportistasBaneados, DeportistasBaneadosDTO>();

            CreateMap<DeportistasNivelesDTO, DeportistasNiveles>();
            CreateMap<DeportistasNiveles, DeportistasNivelesDTO>();

            CreateMap<InvitacionesDTO, Invitaciones>();
            CreateMap<Invitaciones, InvitacionesDTO>();

            CreateMap<NivelDTO, Nivel>();
            CreateMap<Nivel, NivelDTO>();

            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();

            CreateMap<VideoDTO, Video>();
            CreateMap<Video, VideoDTO>();
        }
    }
}
