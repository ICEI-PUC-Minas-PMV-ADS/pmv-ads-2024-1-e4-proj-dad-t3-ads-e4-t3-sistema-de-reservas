using api_reservas.Models;
using api_reservas.Repositories;

namespace api_reservas.Services
{
    public class ReservaService : BaseService<Reserva>
    {
        public ReservaService(MyMongoRepository repository) : base(repository)
        {

        }
    }
}
