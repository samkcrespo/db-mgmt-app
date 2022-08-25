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
    }
}