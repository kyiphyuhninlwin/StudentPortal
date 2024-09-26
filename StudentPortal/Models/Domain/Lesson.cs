namespace StudentPortal.Models.Domain
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid SubjectID { get; set; }
        public Subject Subject { get; set; }
        public Guid CourseID { get; set; }
        public Course Course { get; set; }
    }
}
