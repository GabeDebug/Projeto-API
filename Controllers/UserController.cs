using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("{id}/person/{nickname}")]
        [ProducesResponseType(typeof(user), StatusCodes.Status200OK)] // metodo para qual status vou querer que fique
        public IActionResult Get(int id, string nickname)
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
