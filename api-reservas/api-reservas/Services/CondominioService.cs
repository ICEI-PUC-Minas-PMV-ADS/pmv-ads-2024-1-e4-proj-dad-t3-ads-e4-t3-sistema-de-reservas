using api_reservas.Models;
using api_reservas.Repositories;

namespace api_reservas.Services
{
    public class CondominioService : BaseService<Condominio>
    {
        public CondominioService(MyMongoRepository repository) : base(repository)
        {

        }
    }
}
