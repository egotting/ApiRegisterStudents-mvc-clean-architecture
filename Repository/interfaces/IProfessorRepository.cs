using Crudv3.Models;

namespace crudv3.Repository.interfaces;

public interface IProfessorRepository
{
    IEnumerable<Professor> GetProfessors();
}