using Microsoft.AspNetCore.Mvc;
using UsuariosApiAlura.Data.Dtos;
using UsuariosApiAlura.Services;

namespace UsuariosApiAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly CadastroService _cadastroService;

        public UsuarioController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario(CreateUsuarioDto dto)
        {
            await _cadastroService.Cadastrar(dto);
            return Ok("Usuário cadastrado!");
        }
    }
}
