using api_reservas.Models.Interfaces;
using api_reservas.Repositories;
using MongoDB.Driver;

namespace api_reservas.Services
{
    public class BaseService<T> where T : class, IBaseEntity, new()
    {

        private readonly IMongoCollection<T> _collection;


        public BaseService(MyMongoRepository myRepository)
        {
            string className = typeof(T).Name;
            _collection = myRepository.mongoDatabase.GetCollection<T>(className);
        }

        public async Task<List<T>> GetAsync() =>
          await _collection.Find(_ => true).ToListAsync();

        public async Task<T?> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(T newItem) =>
            await _collection.InsertOneAsync(newItem);

        public async Task UpdateAsync(string id, T updatedItem) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedItem);

        public async Task RemoveAsync(string id) => await _collection.DeleteOneAsync(x => x.Id == id);
    }
}
