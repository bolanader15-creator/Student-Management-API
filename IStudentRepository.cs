using StudentAPI.Models;

namespace StudentAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(int id, Student student);
        Task<bool> Delete(int id);
    }
}
