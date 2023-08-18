using AutoMapper;
using UsuariosApiAlura.Data.Dtos;
using UsuariosApiAlura.Models;

namespace UsuariosApiAlura.Profiles
{
    public class UsuarioProfile : Profile
    {
        public UsuarioProfile()
        {
            CreateMap<CreateUsuarioDto, Usuario>();
        }
    }
}
