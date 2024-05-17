using Crudv3.Models;
using Crudv3.Models.DTO.Student;

namespace crudv3.Services.Interfaces;

public interface IStudentService
{
    IEnumerable<StudentResponseDTO> GetAll();
    DBStudentsModels GetStudentById(string identidade);

    StudentResponseDTO SaveStudent(StudentRequestDTO studentResponseDto);

     bool DeleteStudentById(string identidade);

     StudentResponseDTO UpdateNameStudent(string identidade, UpdateNameStudentDTO request);
}
