using api_reservas.Dtos;
using api_reservas.Models;
using api_reservas.Repositories;
using api_reservas.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace api_reservas.Controllers

{
    

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : BaseController<Usuario>
    {

        private readonly PasswordHasher passwordHasher;

        public UsuarioController(MyMongoRepository repo) : base(repo)
        {
            passwordHasher = new PasswordHasher();
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(Usuario usuario)
        {
            usuario.PasswordHash = passwordHasher.HashPassword(usuario.PasswordHash);

            await _baseService.CreateAsync(usuario);

            return NoContent();
        }



        //[HttpPost("login")]
        //public async Task<IActionResult> Login(LoginDto loginDto)
        //{
        //    var usuarios = await _baseService.GetAsync();

        //    var buscaUsuario = usuarios.Find(usuario => usuario.Email.Equals(loginDto.Email));

        //    if (buscaUsuario == null)
        //        return NotFound();

        //    // TODO: validar senha
        //    // TODO: produzir token

        //    return Ok("Login com sucesso");
        //}

        [HttpPost("login")]
        [AllowAnonymous] // Permitir acesso sem autenticação
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var usuarios = await _baseService.GetAsync();

            var buscaUsuario = usuarios.Find(usuario => usuario.Email.Equals(loginDto.Email));

            if (buscaUsuario == null)
                return NotFound();

            // Verificar senha (utilize sua lógica aqui)
            if (!passwordHasher.VerifyPassword(buscaUsuario.PasswordHash, loginDto.Password))
                return Unauthorized();

            // Gerar token
            var token = GenerateToken(buscaUsuario.Id, buscaUsuario.Email);

            return Ok(new { Token = token });
        }


    }
}