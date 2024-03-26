using api_reservas.Models;
using api_reservas.Repositories;
using api_reservas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class CondominoController : BaseController<Condomino>
    {
        public CondominoController(MyMongoRepository repo) : base(repo)
        {
        }
    }
}
