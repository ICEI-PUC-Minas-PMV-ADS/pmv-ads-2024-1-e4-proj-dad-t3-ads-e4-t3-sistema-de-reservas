using api_reservas.Models;
using api_reservas.Repositories;

namespace api_reservas.Services
{
    public class LocalService : BaseService<Local>
    {
        public LocalService(MyMongoRepository repository) : base(repository)
        {

        }
    }
}
