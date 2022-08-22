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

        public ICollection<MotionPicture> GetMotionPictures()
        {
            return _context.MotionPictures.OrderBy(m => m.Id).ToList();
        }
    }
}
