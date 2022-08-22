namespace backend.Dto
{
    public class MotionPictureDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int ReleaseYear { get; set; }
    }
}
