using Microsoft.AspNetCore.Mvc;
using Movie_Api.Model;
using Movie_Api.Repository;

namespace Movie_Api.Controllers
{

    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly IService _service;

        public HomeController(IService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetMoveis(int moveiId)
        {
            var res = await _service.GetByIdMoveisAsync(moveiId);
            return Ok(res);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMoveis()
        {
            var res = await _service.GetAllMoveisAsync();

            return Ok(res);

        }
        [HttpPost]
        public async Task<IActionResult> AddMoveis([FromForm] Moveis moveis)
        {
            await _service.AddMoveisAsync(moveis);
            return Ok(moveis);

        }

        [HttpDelete]

        public async Task<IActionResult> MoviyDalate(int id)
        {
            var res = await _service.GetImageAsync(id);
            bool res1 = await _service.DelateMovieAsync(id);
            if (res == false)
            {
                return NotFound();

            }
            return Ok(res);
        }
    }
}



    