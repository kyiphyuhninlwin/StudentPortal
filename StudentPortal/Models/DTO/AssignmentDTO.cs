using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class AssignmentDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime DueDate { get; set; }
        public Guid StudentID { get; set; }
        public Student Students { get; set; }
        public Guid SubjectID { get; set; }
        public Subject Subjects { get; set; }
        public Guid CourseID { get; set; }
        public Course Courses { get; set; }
    }
}
