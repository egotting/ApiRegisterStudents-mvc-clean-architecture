using Crudv3.Models;
using Crudv3.Models.DTO.Professor;
using crudv3.Repository.interfaces;
using crudv3.Services.Interfaces;

namespace crudv3.Services;

public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _repo;

    public ProfessorService(IProfessorRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<ProfessorResponseDTO> GetAll()
    {
        return _repo.GetProfessors()
            .Select(professor => new ProfessorResponseDTO(professor.Id, professor.FirstName,
                professor.LastName,professor.Age, professor.Identidade))
            .ToList();
    }
}