using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestCICD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(new { message = "Test GET API is working!" });
        }

        [HttpGet("getAwsCiCdStatus")]
        public IActionResult GetAwsCiCdStatus()
        {
            return Ok(new { message = "CiCd Pipeline is working and apprunner is hosting automated successfully" });
        }

        [HttpPost("post")]
        public IActionResult Post()
        {
            return Ok(new { message = "Test POST API is working!" });
        }
    }
}
