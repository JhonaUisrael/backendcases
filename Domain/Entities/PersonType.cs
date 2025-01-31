using System.ComponentModel.DataAnnotations;

namespace Domain;

public class PersonType
{
    [Key]

    public int PersonTypeId { get; set; } // PK, Identity
    public string PersonTypeName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;

    // Relación inversa con Person
    public ICollection<Person> Persons { get; set; }
}