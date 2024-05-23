using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudv3.Models;

public class Professor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Precisa por um valor")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Precisa por um valor", AllowEmptyStrings = false)]
    public string Identidade { get; set; }

    public Professor()
    {
        
    }
    public Professor(int id, string firstName, string lastName, int age, string identidade)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Identidade = identidade;
    }

}