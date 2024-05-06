using Microsoft.EntityFrameworkCore;

namespace Crudv3.Models;

public class DBStudentContextModels : DbContext
{
    public DBStudentContextModels(DbContextOptions<DBStudentContextModels> options):base(options)
    {
    }



    public DbSet<DBStudentsModels> DBStudents { get; set; }
}