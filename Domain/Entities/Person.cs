using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Person
{
        [Key]
    public int PersonId { get; set; } // PK, Identity
    public string PersonName { get; set; }
    public string PersonLastName { get; set; }
    public string PersonIdentification { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;

    // Relación con PersonType
    public int PersonTypeId { get; set; }
    public PersonType PersonType { get; set; }

    // Relación muchos a muchos con Cases
    public ICollection<PersonCase> PersonCases { get; set; }
}

