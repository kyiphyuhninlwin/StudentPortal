namespace StudentPortal.Models.Domain
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid TeacherID { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
        public Guid AssignmentID { get; set; }
        public Assignment Assignment { get; set; }
    }
}
