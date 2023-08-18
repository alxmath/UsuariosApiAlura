using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UsuariosApiAlura.Data.Dtos;
using UsuariosApiAlura.Models;

namespace UsuariosApiAlura.Services
{
    public class CadastroService
    {
        private readonly IMapper _mapper;
        private readonly UserManager<Usuario> _userManager;

        public CadastroService(IMapper mapper, UserManager<Usuario> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task Cadastrar(CreateUsuarioDto dto)
        {
            Usuario usuario = _mapper.Map<Usuario>(dto);

            var resultado = await _userManager.CreateAsync(usuario, dto.Password);

            if (!resultado.Succeeded) { throw new ApplicationException("Falha ao cadastrar usuário"); }

        }
    }
}
