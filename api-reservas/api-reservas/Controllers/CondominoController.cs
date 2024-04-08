using api_reservas.Models;
using api_reservas.Repositories;
using api_reservas.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CondominoController : BaseController<Condomino>
    {
        private static int ultimoUsuarioId = 0;

        public CondominoController(MyMongoRepository repo) : base(repo)
        {

        }
        private int ProximoUsuarioId()
        {
            return ++ultimoUsuarioId;
        }
        private Condomino CriarNovoCondomino(string nome)
        {
            return new Condomino
            {
                usuarioId = ProximoUsuarioId(),
                Nome = nome
            };
        }
        [HttpPost]
        public override async Task<IActionResult> Post(Condomino entity)
        {
            var novoCondomino = CriarNovoCondomino(entity.Nome);
            await _baseService.CreateAsync(novoCondomino);

            return NoContent();
        }
    }
}
