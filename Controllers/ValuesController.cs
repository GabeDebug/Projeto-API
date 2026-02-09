using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : MyfirstAPiController1
    {
        [HttpGet("get-by-id")] // tudo que eu passa aqui vai tá indo pra url
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult Get()
        {
            return Ok(Author);
        }
    }
}
