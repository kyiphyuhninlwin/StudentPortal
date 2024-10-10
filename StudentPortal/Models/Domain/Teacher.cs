namespace StudentPortal.Models.Domain
{
    public class Teacher
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
                if(JoinDate > today.AddYears(-service))
                {
                    service--;
                };
                return service;
            }
        }
        public string Address { get; set; }
        public Guid GenderID { get; set; }
        public Gender Gender { get; set; }

        #region Relationships
        public Guid SubjectId { get; set; } 
        public Subject Subject { get; set; }
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        #endregion
    }
}
