using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class SubjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TeacherID { get; set; }
        public TeacherDTO Teacher { get; set; }
        public Assignment Assignment { get; set; }
        public Guid CourseID { get; set; }
        public Course Course { get; set; }
        public ICollection<LessonDTO> Lessons { get; set; } = new List<LessonDTO>();
    }
}
