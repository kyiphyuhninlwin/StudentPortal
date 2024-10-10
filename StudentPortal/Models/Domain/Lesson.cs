namespace StudentPortal.Models.Domain
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        #region Relationships
        public Guid SubjectID { get; set; }
        public Subject Subject { get; set; }
        #endregion
    }
}
