using Crudv3.Models;

namespace crudv3.Repository.interfaces;

public interface IStudentsRepository
{
    IEnumerable<Student> GetStudent();
    Student GetStudentById(string identidade);
    Student SaveStudent(Student newStudent);

    bool DeleteStudent(Student student);

    Student UpdateStudent(Student student);
}