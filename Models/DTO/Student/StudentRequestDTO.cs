using System.ComponentModel.DataAnnotations;

namespace Crudv3.Models.DTO.Student;

public record StudentRequestDTO(
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    [MaxLength(100, ErrorMessage = "O campo Nome precisa ter no maximo 100 caracteres")]
    string? FirstName, 
    
    [Required(ErrorMessage = "O campo Sobrenome é obrigatorio")]
    [MaxLength(100, ErrorMessage = "O campo nome precisa ter no maximo 100 caracteres")]
    string? LastName, 
    
    [Required(ErrorMessage = "O campo idade é obrigatorio")]
    int? Age,
    
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    [MaxLength(100, ErrorMessage = "O campo nome precisa ter no maximo 100 caracteres")]
    string? Identidade,
    
    [Required(ErrorMessage = "O campo nome é obrigatorio")]
    [MaxLength(100, ErrorMessage = "O campo nome precisa ter no maximo 100 caracteres")]
    string? Matricula);