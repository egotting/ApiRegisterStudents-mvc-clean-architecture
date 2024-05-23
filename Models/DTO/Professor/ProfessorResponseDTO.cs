namespace Crudv3.Models.DTO.Professor;

public record ProfessorResponseDTO(
    int Id,
    string FirstName,
    string LastName,
    int Age,
    string Identidade
);