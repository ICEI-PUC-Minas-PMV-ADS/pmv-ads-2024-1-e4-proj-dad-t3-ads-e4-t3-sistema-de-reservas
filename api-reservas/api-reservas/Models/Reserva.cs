using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_reservas.Models
{
    public class Reserva : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string CondominioId { get; set; }
        public string CondominoId { get; set; }
        public DateTime DataHorario { get; set; }
    }
}
