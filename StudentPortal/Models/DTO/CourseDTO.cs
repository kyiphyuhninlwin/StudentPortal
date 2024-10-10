using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class CourseDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int Duration
        {
            get
            {
                return (ToDate - FromDate).Days;  // Returns duration in full days
            }
        }
        public decimal Price { get; set; }
        public ICollection<TeacherCourseDTO> TeacherCourses { get; set; } = new List<TeacherCourseDTO>();
        public ICollection<SubjectDTO> Subjects { get; set; } = new List<SubjectDTO>();

    }
}
