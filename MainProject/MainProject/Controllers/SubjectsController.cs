using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MainProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World! Salman Says hi");
        }
    }
}
