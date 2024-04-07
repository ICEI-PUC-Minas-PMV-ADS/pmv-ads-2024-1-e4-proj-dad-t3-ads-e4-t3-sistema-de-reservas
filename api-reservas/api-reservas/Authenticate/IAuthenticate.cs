using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace api_reservas.Authenticate
{
    public interface IAuthenticate
    {
        //public string GenerateToken(int id, string login)
        //{
        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var key = Encoding.ASCII.GetBytes("sua-chave-secreta");

        //    var tokenDescriptor = new SecurityTokenDescriptor
        //    {
        //        Subject = new ClaimsIdentity(new Claim[]
        //        {
        //    new Claim(ClaimTypes.NameIdentifier, id.ToString()),
        //    new Claim(ClaimTypes.Name, login)
        //        }),
        //        Expires = DateTime.UtcNow.AddDays(7), // Defina o tempo de expiração do token conforme necessário
        //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        //    };

        //    var token = tokenHandler.CreateToken(tokenDescriptor);
        //    return tokenHandler.WriteToken(token);
        //}

        Task<bool> AuthenticateAsync(string login, string password);

        Task<bool> UserExists(string login);

        public string GenerateToken(int id, string login);
            
     }
}
