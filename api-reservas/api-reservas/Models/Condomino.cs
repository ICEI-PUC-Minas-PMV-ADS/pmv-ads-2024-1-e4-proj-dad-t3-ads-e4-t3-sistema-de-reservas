using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace api_reservas.Models
{
    public class Condomino : BaseEntity
    {
        public int usuarioId { get; set; }
        [Required(ErrorMessage = "O Nome é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho não pode exceder 50 caracteres")]
        public string Nome { get; set; }
        public Reserva[]? Reservas { get; set; }
    }
}
