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

        //public bool CreateMotionPicture(MotionPicture motionpicture)
        //{
        //    var MotionPicture = new MotionPicture()
        //    {
        //        MotionPicture = motionpicture,
        //    };
        //    _context.Add(motionpicture);

        //    return Save();
        //}

        //public bool DeleteMotionPicture(MotionPicture motionpicture)
        //{
        //    _context.Remove(motionpicture);
        //    return Save();
        //}

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

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        //public bool UpdateMotionPicture(MotionPicture motionpicture)
        //{
        //    _context.Update(motionpicture);
        //    return Save();
        //}

       
    }
}
