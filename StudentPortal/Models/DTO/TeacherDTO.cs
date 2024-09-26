using StudentPortal.Models.Domain;

namespace StudentPortal.Models.DTO
{
    public class TeacherDTO
    {
        public Guid Id { get; set; }
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
        public DateTime JoinDate { get; set; }
        public int Service
        {
            get
            {
                var today = DateTime.Today;
                var service = today.Year - JoinDate.Year;
                if (JoinDate > today.AddYears(-service))
                {
                    service--;
                };
                return service;
            }
        }
        public string Address { get; set; }
        public Guid GenderID { get; set; }
        public Gender Gender { get; set; }
        public Guid DeptID { get; set; }
        public Department Department { get; set; }
        public Guid CourseID { get; set; }
        public Course Course { get; set; }
        public Guid SubjID { get; set; }
        public Subject Subject { get; set; }
    }
}
