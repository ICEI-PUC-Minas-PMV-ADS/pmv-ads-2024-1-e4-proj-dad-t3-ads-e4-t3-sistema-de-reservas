

namespace api_reservas.Models
{
    public class Condominio : BaseEntity
    {
        public string Nome { get; set; }
        public Condomino[]? Condominos { get; set; } 
        public Local[]? Locais { get; set; }
        public Reserva[]? Reservas { get; set; }
    }
}
