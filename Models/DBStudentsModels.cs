using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Crudv3.Models;

public class DBStudentsModels
{

    [Key] public Guid Id { get; set; }

    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public int? Age { get; set; }


    public string? Identidade { get; set; }

    public string? Matricula { get; set; }
    

    public DBStudentsModels()
    {
    }
    [JsonConstructor]
    public DBStudentsModels(string? firstName, string? lastName, int? age, string? identidade, string? matricula)
    {
        Id = Guid.NewGuid();
        firstName = FirstName;
        lastName = LastName;
        age = Age;
        identidade = Identidade;
        matricula = Matricula;
    }

}