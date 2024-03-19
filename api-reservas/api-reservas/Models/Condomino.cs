using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_reservas.Models
{
    public class Condomino : BaseEntity
    {
        public string Nome { get; set; }    
        public Reserva[] Reservas { get; set; }
    }
}
