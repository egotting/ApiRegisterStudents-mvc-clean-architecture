namespace Crudv3.Models.DTO.Student;

public record StudentResponseDTO(
    Guid Id,
    string FirstName,
    string LastName,
    int Age,
    string Identidade,
    string Matricula);
