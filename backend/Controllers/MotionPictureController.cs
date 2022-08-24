using AutoMapper;
using backend.Dto;
using backend.Interfaces;
using backend.Models;
using backend.Repository;
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

        //GET motion pictures
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<MotionPicture>))]

        public IActionResult GetMotionPictures()
        {
            var motionPictures = _mapper.Map<List<MotionPictureDto>>(_motionPictureRepository.GetMotionPictures());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(motionPictures);
        }

        //GET motionpictures/id

        [HttpGet("{mpId}")]
        [ProducesResponseType(200, Type = typeof(MotionPicture))]
        [ProducesResponseType(400)]

        public IActionResult GetMotionPicture(int mpId)
        {
            if (!_motionPictureRepository.MotionPictureExists(mpId))

                return NotFound();

            var mp = _mapper.Map<MotionPictureDto>(_motionPictureRepository.GetMotionPicture(mpId));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            return Ok(mp);

        }
        [HttpPost]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]

        public IActionResult CreateMotionPicture([FromBody] MotionPictureDto motionPictureCreate)
        {
            if (motionPictureCreate == null)
                return BadRequest(ModelState);
            var motionPicture = _motionPictureRepository.GetMotionPictures()
              .Where(c => c.Name.Trim().ToUpper() == motionPictureCreate.Name.TrimEnd().ToUpper())
              .FirstOrDefault();

            if (motionPicture != null)
            {
                ModelState.AddModelError("", "Motion Picture already exists");
                return StatusCode(422, ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest();


            var motionPictureMap = _mapper.Map<MotionPicture>(motionPictureCreate);
            if (!_motionPictureRepository.CreateMotionPicture(motionPictureMap))
            {
                ModelState.AddModelError("", "Something went wrong while saving");
                return StatusCode(500, ModelState);
            }
            return Ok("Successfuly created");
        }

        [HttpPut("{mpId}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]

        public IActionResult UpdateMotionPicture(int mpId, [FromBody] MotionPictureDto updatedMotionPicture)
        {
            if (updatedMotionPicture == null)
                return BadRequest(ModelState);

            if (mpId != updatedMotionPicture.Id)
                return BadRequest(ModelState);

            if (!_motionPictureRepository.MotionPictureExists(mpId))
                return NotFound();

            if (!ModelState.IsValid)
                return BadRequest();

            var motionPictureMap = _mapper.Map<MotionPicture>(updatedMotionPicture);

            if (!_motionPictureRepository.UpdateMotionPicture(motionPictureMap))
            {
                ModelState.AddModelError("", "Something went wrong updating Motion Picture");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
        //[HttpDelete("{mpId}")]
        //[ProducesResponseType(400)]
        //[ProducesResponseType(204)]
        //[ProducesResponseType(404)]
        //public IActionResult DeleteMotionPicture(int mpId)
        //{
        //    if (!_motionPictureRepository.MotionPictureExists(mpId))
        //    {
        //        return NotFound();
        //    }


        //    var motionPictureToDelete = _motionPictureRepository.GetMotionPicture(mpId);

        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);



        //    if (!_motionPictureRepository.DeleteMotionPicture(motionPictureToDelete))
        //    {
        //        ModelState.AddModelError("", "Something went wrong deleting Motion Picture");
        //    }

        //    return NoContent();
        //}

    }
}
