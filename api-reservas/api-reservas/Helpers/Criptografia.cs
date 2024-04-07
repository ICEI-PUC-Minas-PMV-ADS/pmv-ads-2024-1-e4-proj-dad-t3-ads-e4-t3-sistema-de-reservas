using BCrypt.Net;

namespace api_reservas.Services
{
    public static class Criptografia
    {
        public static string GerarHash(this string valor)
        {
            return BCrypt.Net.BCrypt.HashPassword(valor);
        }

        public static bool VerificarHash(this string valor, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(valor, hash);
        }
    }
}