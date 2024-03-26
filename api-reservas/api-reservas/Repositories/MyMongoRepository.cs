using api_reservas.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace api_reservas.Repositories
{
    public class MyMongoRepository
    {
        public IMongoDatabase mongoDatabase;

        public MyMongoRepository(
            IOptions<DatabaseSettings> dabaseSettings)
        {
            var mongoClient = new MongoClient(dabaseSettings.Value.ConnectionString);

            mongoDatabase = mongoClient.GetDatabase(dabaseSettings.Value.DatabaseName);
        }
    }
}
