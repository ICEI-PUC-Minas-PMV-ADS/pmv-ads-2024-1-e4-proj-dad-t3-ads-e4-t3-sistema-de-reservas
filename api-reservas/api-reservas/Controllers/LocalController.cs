using api_reservas.Models;
using api_reservas.Repositories;
using api_reservas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class LocalController : BaseController<Local>
    {
        public LocalController(MyMongoRepository repo) : base(repo)
        {
        }
    }
}
