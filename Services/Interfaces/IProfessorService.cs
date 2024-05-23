using Crudv3.Models.DTO.Professor;

namespace crudv3.Services.Interfaces;

public interface IProfessorService
{
    IEnumerable<ProfessorResponseDTO> GetAll();
}