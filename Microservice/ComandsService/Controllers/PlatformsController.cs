using Microsoft.AspNetCore.Mvc;

namespace ComandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine(" Test Inbound command service");

            return Ok("Inbound test of from Platforms controller");
        }
    }
}
