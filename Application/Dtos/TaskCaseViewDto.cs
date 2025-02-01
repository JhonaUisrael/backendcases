namespace Application;

public class TaskCaseViewDto
{
    public string Detail { get; set; }
    public string State { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool Active { get; set; } = true;

    // Relación con Cases
    public CaseViewDto Case { get; set; }
}
