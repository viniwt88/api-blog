using blogApi.Interfaces.Services;
using blogApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace blogApi.Controllers
{
    [Route("posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }


        [HttpPost]
        [Route("post")]
        [Authorize(Roles = "autor, admin")]
        public IActionResult RealizarPost([FromBody] Post post)
        {
            try
            {
                // validações....

                var sucesso = _postService.RealizarPostagem(post);

                if (sucesso)
                {
                    return Ok(new
                    {
                        success = sucesso,
                        message = "Post realizado com sucesso !"
                    });
                }

                return BadRequest(new
                {
                    success = false,
                    message = "Falha não tratada no sistema, um alerta foi criado para análise deste caso..."
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

        [HttpGet]
        [Route("post")]
        [AllowAnonymous]
        public IActionResult VisualizarPost([FromBody] int postId)
        {
            try
            {
                // validações....

                var post = _postService.VisualizarPost(postId);

                if (post == null)
                {
                    return Ok(new
                    {
                        success = true,
                        message = "Post não encontrado...!"
                    });
                }

                return Ok(new
                {
                    success = true,
                    message = post
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
