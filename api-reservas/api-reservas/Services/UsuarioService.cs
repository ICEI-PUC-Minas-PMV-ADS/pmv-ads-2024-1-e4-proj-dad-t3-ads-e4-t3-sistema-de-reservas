using api_reservas.Models;
using api_reservas.Repositories;

namespace api_reservas.Services
{
    public class UsuarioService : BaseService<Usuario>
    {
        public UsuarioService(MyMongoRepository myRepository) : base(myRepository)
        {
        }
    }
}
