using Microsoft.AspNetCore.Mvc;

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
                name = "gabriel"
            };

            return Ok(response);
        }
    }
}
