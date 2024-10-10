using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class LessonDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
