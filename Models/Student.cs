using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Crudv3.Models;

public class Student
{
    [Key] public Guid Id { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Precisa por um valor")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string Identidade { get; set; }

    [Required] public string Matricula { get; set; }


    public Student()
    {
    }

    public Student(string firstName, string lastName, int age, string identidade, string matricula)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Identidade = identidade;
        Matricula = matricula;
    }
}