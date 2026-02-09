using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyfirstAPiController1 : ControllerBase
    {
        public string Author { get; set; } = "passou a req";
    }
}
