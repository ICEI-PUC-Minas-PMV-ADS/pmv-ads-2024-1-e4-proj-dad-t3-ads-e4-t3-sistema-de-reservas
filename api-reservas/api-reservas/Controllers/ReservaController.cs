using api_reservas.Models;
using api_reservas.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class ReservaController : BaseController<Reserva>
    {
        public ReservaController(MyMongoRepository repo) : base(repo)
        {
        }
    }
}
