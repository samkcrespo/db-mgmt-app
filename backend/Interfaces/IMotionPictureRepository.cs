using backend.Models;

namespace backend.Interfaces
{
    public interface IMotionPictureRepository
    {
        ICollection<MotionPicture> GetMotionPictures();
    }
}
