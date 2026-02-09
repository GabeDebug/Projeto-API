using Microsoft.AspNetCore.Mvc;
using WebApplication1.Comunication.Request;
using WebApplication1.Comunication.Response;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : MyfirstAPiController1
    {
        [HttpGet] // aqui recebo um get para buscar um usuario
        ///  [Route("{id}/person/{nickname}")] // passando valores na rota
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)] // metodo para qual status vou querer que fique
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)] // para da uma status de bad request caso tenha algum erro
        public IActionResult GetByid([FromHeader] int id, [FromHeader] string? nickname) // vamos aceita valores null quando usar o ?
        {
            var response = new user
            {
                id = 1,
                Age = 7,
                name = "gabriel"
            };

            return Ok(response);
        }

        [HttpPost] // aqui estamos usando o verbo post para criar um usuario
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

        [HttpPut] // aqui estamos usando o verbo put para atualizar um usuario
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

        [HttpGet("get-all")]
        [ProducesResponseType(typeof(List<User>),StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new List<user>
            {
                new User { id = 1, Age = 7, name = "gabriel1" },
                new User { id = 2, Age = 8, name = "gabriel" },
            };
            return Ok(response);
        }

        [HttpPut("change-password")] // aqui estamos usando o verbo put para atualizar a senha do usuario, e passando a rota change-password para diferenciar do update normal
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult ChangePassword([FromBody] RequestChancePasswordJson request)
        {
            return NoContent();
        }
    }
}
