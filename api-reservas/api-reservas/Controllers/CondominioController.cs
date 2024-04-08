using api_reservas.Models;
using api_reservas.Repositories;
using api_reservas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CondominioController : BaseController<Condominio>
    {
        public CondominioController(MyMongoRepository repo) : base(repo)
        {
            
        }
    }
}
