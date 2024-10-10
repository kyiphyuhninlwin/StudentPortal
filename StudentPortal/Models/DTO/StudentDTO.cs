using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class StudentDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public DateTime DateofBirth { get; set; }

        // Computed Age Property (based on DateOfBirth)
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateofBirth.Year;
                if (DateofBirth > today.AddYears(-age))
                {
                    age--;
                };
                return age;
            }
        }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderID { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public DateTime JoinDate { get; set; }
        public Guid CourseID { get; set; }
        public CourseDTO Course { get; set; }
        public ICollection<TeacherDTO> Teachers { get; set; } = new List<TeacherDTO>();
        public ICollection<SubjectDTO> Subjects { get; set; } = new List<SubjectDTO>();
        public ICollection<LessonDTO> Lessons { get; set; } = new List<LessonDTO>();
        public ICollection<AssignmentDTO> Assignments { get; set; } = new List<AssignmentDTO>();

    }

}
