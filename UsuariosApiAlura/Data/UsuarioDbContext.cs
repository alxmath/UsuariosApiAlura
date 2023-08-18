using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsuariosApiAlura.Models;

namespace UsuariosApiAlura.Data
{
    public class UsuarioDbContext : IdentityDbContext<Usuario>
    {
        public UsuarioDbContext(DbContextOptions<UsuarioDbContext> options) : base(options)
        {
        }
    }
}
