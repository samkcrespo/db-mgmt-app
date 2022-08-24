using backend.Models;

namespace backend.Interfaces
{
    public interface IMotionPictureRepository
    {
        ICollection<MotionPicture> GetMotionPictures();
        MotionPicture GetMotionPicture(int id);
        MotionPicture GetMotionPicture(string name);
        //bool CreateMotionPicture(MotionPicture motionpicture);
        //bool UpdateMotionPicture(MotionPicture motionpicture);
        //bool DeleteMotionPicture(MotionPicture motionpicture);
        bool Save();

        bool MotionPictureExists(int mpId);

    }
}
