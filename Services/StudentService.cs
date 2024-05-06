using crudv3.Exceptions;
using Crudv3.Models;
using Crudv3.Models.DTO.Student;
using crudv3.Repository.interfaces;
using crudv3.Services.Interfaces;
namespace crudv3.Services;

public class StudentService : IStudentService
{
    private readonly IStudentsRepository _studentsRepository;

    public StudentService(IStudentsRepository studentsRepository)
    {
        _studentsRepository = studentsRepository;
    }

    public IEnumerable<StudentResponseDTO>  GetAll()
    {
        return _studentsRepository.GetStudent()
            .Select(student => new StudentResponseDTO(student.Id, student.FirstName,
                student.LastName, student.Age, student.Identidade, student.Matricula))
            .ToList();
    }
    

    
    public DBStudentsModels GetStudentById(string identidade)
    {
        var studentById = _studentsRepository.GetStudentById(identidade);
        
        Console.WriteLine(studentById);
        return studentById;
    }

    public StudentResponseDTO SaveStudent(StudentRequestDTO studentRequestDto)
    {
        var student = new DBStudentsModels(studentRequestDto.FirstName, studentRequestDto.LastName,
            studentRequestDto.Age,studentRequestDto.Identidade, studentRequestDto.Matricula);
        
        student = _studentsRepository.SaveStudent(student);
        return new StudentResponseDTO(student.Id,student.FirstName, student.LastName,
            student.Age,student.Identidade, student.Matricula);
    }

}