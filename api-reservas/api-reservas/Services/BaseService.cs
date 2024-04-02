using api_reservas.Models.Interfaces;
using api_reservas.Repositories;
using MongoDB.Driver;

namespace api_reservas.Services
{
    /// <summary>
    /// Generic service class providing basic CRUD operations for entities.
    /// </summary>
    /// <typeparam name="T">The type of entity this service operates on.</typeparam>
    public class BaseService<T> where T : class, IBaseEntity, new()
    {

        private readonly IMongoCollection<T> _collection;

        /// <summary>
        /// Initializes a new instance of the BaseService class with the specified MyMongoRepository.
        /// </summary>
        /// <param name="myRepository">The MyMongoRepository instance to use for database access.</param>
        public BaseService(MyMongoRepository myRepository)
        {
            string className = typeof(T).Name;
            _collection = myRepository.mongoDatabase.GetCollection<T>(className);
        }

        /// <summary>
        /// Retrieves all entities from the database.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation, returning a list of entities.</returns>
        public async Task<List<T>> GetAsync() =>
          await _collection.Find(_ => true).ToListAsync();

        /// <summary>
        /// Retrieves a single entity by its ID from the database.
        /// </summary>
        /// <param name="id">The ID of the entity to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation, returning the entity with the specified ID, or null if not found.</returns>
        public async Task<T?> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();

        /// <summary>
        /// Inserts a new entity into the database.
        /// </summary>
        /// <param name="newItem">The entity to insert.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task CreateAsync(T newItem) =>
            await _collection.InsertOneAsync(newItem);

        /// <summary>
        /// Updates an existing entity in the database.
        /// </summary>
        /// <param name="id">The ID of the entity to update.</param>
        /// <param name="updatedItem">The updated entity.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task UpdateAsync(string id, T updatedItem) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedItem);

        /// <summary>
        /// Deletes an entity from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the entity to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task RemoveAsync(string id) => await _collection.DeleteOneAsync(x => x.Id == id);
    }
}
