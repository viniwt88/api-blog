using System;
using blogApi.Models;
using blogApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using blogApi.Interfaces;
using blogApi.Interfaces.Repositories;
using blogApi.Interfaces.Services;
using blogApi.Repositories;

namespace blogApi.Controllers
{
    [Route("auth")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IUserRepository _userRepositoy;

        public AuthenticationController(ITokenService tokenService, IUserRepository userRepositoy)
        {
            _tokenService = tokenService;
            _userRepositoy = userRepositoy; 
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            try
            {
                // Recupera o usuário
                var user = await _userRepositoy.GetUser(model.Username, model.Password);

                // Verifica se o usuário existe
                if (user == null)
                    return NotFound(new { message = "Usuário ou senha inválidos" });

                // Gera o Token
                var token = _tokenService.GenerateToken(user);

                // Oculta a senha
                user.Password = "";

                // Retorna os dados
                return new
                {
                    user = user,
                    token = token
                };
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    success = false,
                    message = ex.Message
                });
            }

        }
    }
}
