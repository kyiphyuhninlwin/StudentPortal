using StudentPortal.Models.Domain;

namespace StudentPortal.Repository.Interface
{
    public interface IStudentRepository
    {
        Task<Student> CreateStudent (Student student);
    }
}
