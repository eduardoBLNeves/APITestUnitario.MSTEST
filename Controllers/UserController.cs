using APITestUnitario.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITestUnitario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            var usuarioBD = new User();

            if (usuarioBD.Nome == user.Nome &&
                usuarioBD.Idade == user.Idade
               )
                return Ok();

            return BadRequest();





        }

    }
}
