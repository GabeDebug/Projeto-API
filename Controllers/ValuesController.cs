using Microsoft.AspNetCore.Mvc;
using WebApplication1.Entities;

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
            var laptop = new Laptop();
            var model = laptop.GetModel();
            return Ok(model);
        }
    }
}
