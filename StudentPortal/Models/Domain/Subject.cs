namespace StudentPortal.Models.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region Relationships
        public Guid TeacherId { get; set; }  // Assuming a foreign key for Teacher
        public Teacher Teacher { get; set; }

        public Guid CourseID { get; set; } // Foreign key for Course
        public Course Course { get; set; }
        public Assignment Assignment { get; set; }

        public ICollection<Lesson> Lessons { get; set; } // One subject can have many lessons
        #endregion

        public Subject()
        {
            Lessons = new List<Lesson>(); // Initialize the collection to prevent null reference exceptions
        }
    }

}
