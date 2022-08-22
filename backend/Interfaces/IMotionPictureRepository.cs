using backend.Models;

namespace backend.Interfaces
{
    public interface IMotionPictureRepository
    {
        ICollection<MotionPicture> GetMotionPictures();
        //MotionPicture GetMotionPicture(int id);
        //MotionPicture GetMotionPicture(string name);
        
        

    }
}
