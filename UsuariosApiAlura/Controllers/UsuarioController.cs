using Microsoft.AspNetCore.Mvc;
using UsuariosApiAlura.Data.Dtos;
using UsuariosApiAlura.Services;

namespace UsuariosApiAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioController(UsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastrar(dto);
            return Ok("Usuário cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);

            return Ok(token);
        }
    }
}
