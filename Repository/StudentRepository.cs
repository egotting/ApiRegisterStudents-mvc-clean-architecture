using crudv3.Exceptions;
using Crudv3.Models;
using crudv3.Repository.interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace crudv3.Repository;

public class StudentRepository : IStudentsRepository
{
    public readonly DBStudentContextModels _context;

    public StudentRepository(DBStudentContextModels context)
    {
        _context = context;
    }

    public IEnumerable<DBStudentsModels> GetStudent()
    {
        return _context.DBStudents.ToList();
    }

    public DBStudentsModels GetStudentById(string identidade)
    {
        return _context.DBStudents.Where(d => d.Identidade == identidade)
            .FirstOrDefault(x => x.Identidade == identidade) ?? 
               throw new NotFoundStudent("Not found this student");
    }

    public DBStudentsModels SaveStudent(DBStudentsModels newStudent)
    {
         _context.DBStudents.Add(newStudent);
         _context.SaveChangesAsync();
         return newStudent;
    }
}