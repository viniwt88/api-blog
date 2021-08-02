using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blogApi.Interfaces.Repositories;
using blogApi.Models;

namespace blogApi.Controllers
{
    [Route("users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;   
        }

        [HttpPost]
        [Route("user")]
        public IActionResult CadastrarUsuario([FromBody] User user)
        {
            try
            {
                // ValidarUsuario(User)

                var success = _userRepository.CreateUser(user);

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
