namespace api_reservas.Models
{
    public class Usuario : BaseEntity
    {

        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

    }
}
