using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotionPictureController : Controller
    {
        private readonly IMotionPictureRepository _motionPictureRepository;

        public MotionPictureController(IMotionPictureRepository motionPictureRepository)
        {
            _motionPictureRepository = motionPictureRepository;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MotionPicture>))]

        public IActionResult GetMotionPictures()
        {
            var motionPictures = _motionPictureRepository.GetMotionPictures();
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(motionPictures);
        }
    }
}
