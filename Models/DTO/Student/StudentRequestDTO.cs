using System.ComponentModel.DataAnnotations;

namespace Crudv3.Models.DTO.Student;

public record StudentRequestDTO(
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string FirstName,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string LastName,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    int Age,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string Identidade,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string Matricula);

public record UpdateNameStudentDTO(
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string FirstName,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string LastName);