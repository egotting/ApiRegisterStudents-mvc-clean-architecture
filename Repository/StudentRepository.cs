using crudv3.Exceptions;
using Crudv3.Models;
using crudv3.Repository.interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace crudv3.Repository;

public class StudentRepository : IStudentsRepository
{
    public readonly DBContext _context;

    public StudentRepository(DBContext context)
    {
        _context = context;
    }

    public IEnumerable<Student> GetStudent()
    {
        return _context.Students.ToList();
    }

    public Student GetStudentById(string identidade)
    {
        return _context.Students.Where(d => d.Identidade == identidade)
                   .FirstOrDefault(x => x.Identidade == identidade) ??
               throw new NotFoundStudent("Not found this student");
    }

    public Student SaveStudent(Student newStudent)
    {
        _context.Students.Add(newStudent);
        _context.SaveChangesAsync();
        return newStudent;
    }

    public bool DeleteStudent(Student student)
    {
        _context.Students.Remove(student);
        _context.SaveChanges();
        return true;
    }

    public Student UpdateStudent(Student student)
    {
        _context.Entry(student).State = EntityState.Modified;
        _context.SaveChanges();
        return student;
    }
}