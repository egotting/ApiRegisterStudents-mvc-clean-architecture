using Crudv3.Models;

namespace crudv3.Repository.interfaces;

public interface IStudentsRepository
{
    IEnumerable<DBStudentsModels> GetStudent();
    DBStudentsModels GetStudentById(string identidade);
    DBStudentsModels SaveStudent(DBStudentsModels newStudent);
}