namespace StudentPortal.Models.Domain
{
    public class Student
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
                if (DateofBirth > today.AddYears(-age)) {
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
        public Course Course { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}
