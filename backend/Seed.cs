using backend.Data;
using backend.Models;

namespace backend
{
    public class Seed
    {
        private readonly DataContext dataContext;


        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!dataContext.MotionPictures.Any())
            {
                var motionPictures = new List<MotionPicture>()
                {
                    new MotionPicture()
                    {
                        Name = "Shawshenk Redemption",
                       Description = "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.",
                       ReleaseYear = 1994,
                    },
                     new MotionPicture()
                    {
                        Name = "Flight",
                       Description = "Commerical airline Pilot Whip Whitaker(Denzel Washington) has a problem with drugs and alcohol, though so far he's managed to complete his flight's safely. His luck runs out when a disastrous mechanical malfunction sends his plane hurtling towards the ground. Whip pulls off the crash landing...",
                       ReleaseYear = 2012,
                    },
               
        };
                dataContext.MotionPictures.AddRange(motionPictures);
                dataContext.SaveChanges();
            }
        }
    }
}
