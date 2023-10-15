using Microsoft.AspNetCore.Mvc;
using Movie_Api.Repository;

namespace Movie_Api.Controllers
{
    public class HomeController : Controller
    {
        [ApiController]
        [Route("api/[controller]/[action]")]
        public class MovieController : ControllerBase
        {
            private readonly IService _service;

            public MovieController(IService service)
            {
                _service = service;
            }
            [HttpGet]
            public async Task<IActionResult> GetAllMoveis()
            {
                var res = await _service.GetAllMoveisAsync();

                return Ok(res);

            }
        }
    }
}

