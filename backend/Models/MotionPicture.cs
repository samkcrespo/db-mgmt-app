using System;
using System.Collections.Generic;

namespace backend.Models
{
    public class MotionPicture
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int ReleaseYear { get; set; }

        //public MotionPicture(int id, string name, string description, int releaseYear)
        //{
        //    //Id = 1;
        //    //Name = "The Shawshenk Redemption";
        //    //Description = "Andy Dufresne (Tim Robbins) is sentenced to two consecutive life terms in prison for the murders of his wife and her lover and is sentenced to a tough prison. However, only Andy knows he didn't commit the crimes. While there, he forms a friendship with Red (Morgan Freeman), experiences brutality of prison life, adapts, helps the warden, etc., all in 19 years.";
        //    //ReleaseYear = 1994;
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    ReleaseYear = releaseYear;
        //}
    }
}