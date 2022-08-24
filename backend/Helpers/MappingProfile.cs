using AutoMapper;
using backend.Dto;
using backend.Models;

namespace backend.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MotionPicture, MotionPictureDto>();
            CreateMap<MotionPictureDto, MotionPicture>();
        }
    }
}
