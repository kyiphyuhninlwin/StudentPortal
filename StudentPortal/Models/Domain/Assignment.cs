namespace StudentPortal.Models.Domain
{
    public class Assignment
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime DueDate { get; set; }
        public Guid StudentID { get; set; }
        public Student Student { get; set; }
        public Guid SubjectID { get; set; }
        public Subject Subject { get; set; }
        public Guid TeacherID { get; set; }
        public Teacher Teacher { get; set; }
    }
}
