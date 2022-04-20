using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        readonly ILogger<PlatformsController> _logger;
        public PlatformsController(ILogger<PlatformsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            //
            _logger.LogInformation("----Inbound post request---");
            return Ok("outboud response");
        }
    }
}