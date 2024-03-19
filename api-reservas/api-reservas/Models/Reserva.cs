using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_reservas.Models
{
    public class Reserva : BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public Condominio Condominio { get; set; }
        public Condomino Condomino { get; set; }
        public DateTime DataHorario { get; set; }
    }
}
