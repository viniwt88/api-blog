using blogApi.Interfaces.Repositories;
using blogApi.Interfaces.Services;
using blogApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace blogApi.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("user")]
        public IActionResult CadastrarUsuario([FromBody] User user)
        {
            try
            {
                // ValidarUsuario(User)

                var success = _userService.CreateUser(user);

                if (success)
                {
                    return Ok(new
                    {
                        success = true,
                        message = "usuário cadastro com sucesso!"
                    });
                }

                return BadRequest(new
                {
                    success = false,
                    message = "Ocorreu algum erro que será tratado em breve..."
                });
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
