namespace StudentPortal.Models.DTO
{
    public class TeacherCourseDTO
    {
        public Guid TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; } // Navigation property to Teacher DTO

        public Guid CourseId { get; set; }
        public CourseDTO Course { get; set; } // Navigation property to Course DTO
    }

}
