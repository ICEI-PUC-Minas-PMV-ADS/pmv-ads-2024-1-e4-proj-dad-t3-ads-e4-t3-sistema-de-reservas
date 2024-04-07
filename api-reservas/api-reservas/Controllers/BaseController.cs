using api_reservas.Models.Interfaces;
using api_reservas.Repositories;
using api_reservas.Services;
using Microsoft.AspNetCore.Mvc;

namespace api_reservas.Controllers
{
    //[Route("api/Local")]
    [Controller]
    public class BaseController<T> : ControllerBase where T  : class, IBaseEntity, new()
    {
        public readonly BaseService<T> _baseService;

        //public BaseController(BaseService<T> baseService) => _baseService = baseService;

        public BaseController(MyMongoRepository repo)
        {
            _baseService = new BaseService<T>(repo);
        }

        [HttpGet]
        public async Task<List<T>> Get() => await _baseService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<T>> Get(string id)
        {
            var book = await _baseService.GetAsync(id);

            if (book is null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post(T entity)
        {
            await _baseService.CreateAsync(entity);

            return NoContent();
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, T entity)
        {
            var result = await _baseService.GetAsync(id);

            if (result is null)
            {
                return NotFound();
            }

            entity.Id = result.Id;

            await _baseService.UpdateAsync(id, entity);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var result = await _baseService.GetAsync(id);

            if (result is null)
            {
                return NotFound();
            }

            await _baseService.RemoveAsync(id);

            return NoContent();
        }
    }
}
