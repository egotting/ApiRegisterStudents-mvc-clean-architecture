using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Crudv3.Models;

public class DBStudentsModels
{

  [Key] public Guid Id { get; set; }

  [Required]public string FirstName { get; set; }
  [Required]public string LastName { get; set; }

  [Required]  public int Age { get; set; }


  [Required]public string Identidade { get; set; }

  [Required]public string Matricula { get; set; }


  public DBStudentsModels()
  {
  }
  public DBStudentsModels(string firstName, string lastName, int age, string identidade, string matricula)
  {
    Id = Guid.NewGuid();
    FirstName = firstName;
    LastName = lastName ; 
    Age = age;
    Identidade = identidade;
    Matricula = matricula;
  }
}
