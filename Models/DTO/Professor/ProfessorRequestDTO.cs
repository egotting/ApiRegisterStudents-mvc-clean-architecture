using System.ComponentModel.DataAnnotations;

namespace Crudv3.Models.DTO.Professor;

public record ProfessorRequestDTO(
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string FirstName,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string LastName,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    int Age,
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    string Identidade);