using BCryptNet = BCrypt.Net.BCrypt;


namespace api_reservas.Utils
{
    public class PasswordHasher
    {

        public string HashPassword(string password)
        {
            return BCryptNet.HashPassword(password);
        }

        public bool IsPasswordCorrect(string password, string storedHash) { 
            return BCryptNet.Verify(password, storedHash);
        }

    }
}
