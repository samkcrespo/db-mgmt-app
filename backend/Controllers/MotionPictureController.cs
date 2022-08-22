using AutoMapper;
using backend.Dto;
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
        private readonly IMapper _mapper;

        public MotionPictureController(IMotionPictureRepository motionPictureRepository, IMapper mapper)
        {
            _motionPictureRepository = motionPictureRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MotionPicture>))]

        public IActionResult GetMotionPictures()
        {
            var motionPictures = _mapper.Map<List<MotionPictureDto>>(_motionPictureRepository.GetMotionPictures());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(motionPictures);
        }

        [HttpGet("{mpId}")]
        [ProducesResponseType(200, Type = typeof(MotionPicture))]
        [ProducesResponseType(400)]

        public IActionResult GetMotionPicture(int mpId)
        {
            //if (!_motionPictureRepository.MotionPictureExists(mpId))

            //    return NotFound();

            var mp = _mapper.Map<MotionPictureDto>(_motionPictureRepository.GetMotionPicture(mpId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(mp);

        }
    }
}
