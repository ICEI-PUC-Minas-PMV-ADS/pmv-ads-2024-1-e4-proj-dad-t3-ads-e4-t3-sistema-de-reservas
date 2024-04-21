using api_reservas.Models;
using api_reservas.Repositories;

namespace api_reservas.Services
{
    public class CondominoService : BaseService<Condomino>
    {
        public CondominoService(MyMongoRepository repository) : base(repository)
        {

        }
    }
}
