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
        public List<LessonDTO> Lessons { get; set; } = new List<LessonDTO>();
        public Guid AssignmentID { get; set; }
        public Assignment Assignment { get; set; }
    }
}
