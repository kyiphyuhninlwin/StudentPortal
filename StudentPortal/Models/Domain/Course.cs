namespace StudentPortal.Models.Domain
{
    public class Course
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

        #region Relationships
        public ICollection<TeacherCourse> TeacherCourses { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        #endregion
    }
}
