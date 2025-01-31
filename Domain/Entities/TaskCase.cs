using System.ComponentModel.DataAnnotations;

namespace Domain;

public class TaskCase
{
    [Key]
    public int TaskId { get; set; } // PK, Identity
    public string TaskDetail { get; set; }
    public int CaseId { get; set; }
    public string TaskState { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public bool Active { get; set; } = true;

    // Relación con Cases
    public Case Case { get; set; }
}
