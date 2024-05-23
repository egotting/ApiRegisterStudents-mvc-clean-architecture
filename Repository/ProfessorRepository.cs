using Crudv3.Models;
using crudv3.Repository.interfaces;

namespace crudv3.Repository;

public class ProfessorRepository : IProfessorRepository
{
    private readonly DBContext _context;

    public ProfessorRepository(DBContext context)
    {
        _context = context;
    }

    public IEnumerable<Professor> GetProfessors()
    {
        return _context.Professors.ToList();
    }
}