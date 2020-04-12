using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestApiController : ControllerBase
    {
        [HttpGet]
        [Route("message/{name}")]
        public ActionResult<string> GetMessage(string name)
        {
            return name;
        }
    }
}