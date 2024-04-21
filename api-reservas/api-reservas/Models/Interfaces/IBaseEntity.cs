using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_reservas.Models.Interfaces
{
    public interface IBaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        string? Id { get; set; }
    }
}
