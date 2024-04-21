

using System.ComponentModel.DataAnnotations;

namespace api_reservas.Models
{
    public class Condominio : BaseEntity
    {
        [Required(ErrorMessage = "O Nome do Condominio é obrigatório")]
        [MaxLength(50, ErrorMessage = "O tamanho não pode exceder 50 caracteres")]
        public string Nome { get; set; }
        public Condomino[]? Condominos { get; set; } 
        public Local[]? Locais { get; set; }
        public Reserva[]? Reservas { get; set; }
    }
}
