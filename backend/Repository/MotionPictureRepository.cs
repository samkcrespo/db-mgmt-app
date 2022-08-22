using backend.Data;
using backend.Interfaces;
using backend.Models;

namespace backend.Repository
{
    public class MotionPictureRepository : IMotionPictureRepository
    {
        private readonly DataContext _context;

        public MotionPictureRepository(DataContext context)
        {
            _context = context;
        }

        public MotionPicture GetMotionPicture(int id)
        {
            return _context.MotionPictures.Where(m => m.Id == id).FirstOrDefault();
        }

        public MotionPicture GetMotionPicture(string name)
        {
            return _context.MotionPictures.Where(m => m.Name == name).FirstOrDefault();
        }

        public ICollection<MotionPicture> GetMotionPictures()
        {
            return _context.MotionPictures.OrderBy(m => m.Id).ToList();
        }

        public bool MotionPictureExists(int mpId)
        {
            return _context.MotionPictures.Any(m => m.Id == mpId);
        }
    }
}
