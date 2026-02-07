using Microsoft.AspNetCore.Mvc;
using WebApplication1.Comunication.Request;
using WebApplication1.Comunication.Response;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
      ///  [Route("{id}/person/{nickname}")] // passando valores na rota
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)] // metodo para qual status vou querer que fique
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] // para da uma status de bad request caso tenha algum erro
        public IActionResult GetByid([FromHeader] int id, [FromHeader] string? nickname) // vamos aceita valores null quando usar o ?
        {
            var response = new user
            {
                id = 1,
                Age = 7,
                name = "doppy"
            };

            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(typeof(RequestRegisterUserJson), StatusCodes.Status201Created)]
        public IActionResult Create([FromBody] RequestRegisterUserJson request)
        {
            var response = new RegisterUserResponseJson // aqui estamos criando um objeto de resposta para retornar o id e o nome do usuario criado
            {
                Id = 1,
                Name = request.name,
            };
            return Created(string.Empty, response);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Update([FromBody] RequestUpdateJson request)
        {
            var debug = request;
            return NoContent();
        }

        [HttpDelete] // aqui estamos usando o verbo delete para deletar um usuario
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Delete()
        {
            return NoContent();
        }
    }
}
