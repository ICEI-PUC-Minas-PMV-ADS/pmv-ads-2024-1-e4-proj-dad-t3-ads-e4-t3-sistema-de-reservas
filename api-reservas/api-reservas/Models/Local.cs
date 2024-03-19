using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace api_reservas.Models
{
    public class Local : BaseEntity
    {
        public string Nome { get; set; }
    }
}
