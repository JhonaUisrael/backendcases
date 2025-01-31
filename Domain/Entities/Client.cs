using System.ComponentModel.DataAnnotations;

namespace Domain;

public class Client
{
    [Key]
    public int ClientId { get; set; }

    [Required]
    [MaxLength(100)]
    public string ClientName { get; set; }

    [Required]
    [MaxLength(100)]
    public string ClientLastName { get; set; }

    [MaxLength(20)]
    public string ClientPhone { get; set; }

    [MaxLength(150)]
    [EmailAddress]
    public string ClientEmail { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public bool Active { get; set; } = true;

    public ICollection<Case> Cases { get; set; }

    // Constructor vacío requerido por EF Core
    public Client() { }

    // Constructor para inicialización
    public Client(string clientName, string clientLastName, string clientPhone, string clientEmail)
    {
        ClientName = clientName;
        ClientLastName = clientLastName;
        ClientPhone = clientPhone;
        ClientEmail = clientEmail;
        CreatedAt = DateTime.Now;
        Active = true;
    }
}
